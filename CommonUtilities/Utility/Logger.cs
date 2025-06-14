﻿using CommonUtilities.Helpers;
using System;
using System.IO;
using System.Text;
using System.Threading;

namespace CommonUtilities.Utility
{
    public sealed class Logger
    {
        #region Log File Writing

        private const int MaxStringLength = 500;

        private static readonly string NewLine = Environment.NewLine;

        public static bool Listening { get; private set; }

        public static FileInfo TargetLogFile { get; private set; }

        public static DirectoryInfo TargetDirectory { get { return TargetLogFile?.Directory; } }

        public static bool LogToConsole = false;
        public static int BatchInterval = 1000;
        public static bool IgnoreDebug = false;

        private static readonly Timer Timer = new Timer(Tick);
        private static readonly StringBuilder LogQueue = new StringBuilder();

        public static void Start(FileInfo targetLogFile)
        {
            if (Listening)
                return;

            Listening = true;
            TargetLogFile = targetLogFile;
            VerifyTargetDirectory();

            Timer.Change(BatchInterval, Timeout.Infinite); // A one-off tick event that is reset every time.
        }

        private static void VerifyTargetDirectory()
        {
            if (TargetDirectory == null)
                throw new DirectoryNotFoundException("Target logging directory not found.");

            TargetDirectory.Refresh();
            if (!TargetDirectory.Exists)
                TargetDirectory.Create();
        }

        private static void Tick(object state)
        {
            try
            {
                string logMessage;
                lock (LogQueue)
                {
                    logMessage = LogQueue.ToString();
                    LogQueue.Length = 0;
                }

                if (string.IsNullOrEmpty(logMessage))
                    return;

                if (LogToConsole)
                    Console.Write(logMessage);

                VerifyTargetDirectory(); // File may be deleted after initialization.
                File.AppendAllText(TargetLogFile.FullName, logMessage);
            }
            finally
            {
                if (Listening)
                    Timer.Change(BatchInterval, Timeout.Infinite); // Reset timer for next tick.
            }
        }

        public static void ShutDown()
        {
            if (!Listening)
                return;

            Listening = false;
            Timer.Dispose();
            Tick(null); // Flush.
        }
        #endregion

        private readonly string Name;
        public EventHandler<LogMessageInfo> LogMessageAdded;
        private bool _startedErrorShown;

        public const string DEBUG = "DEBUG";
        public const string INFO = "INFO";
        public const string WARN = "WARN";
        public const string ERROR = "ERROR";

        public Logger(Type t) : this(t.Name)
        {
        }

        public Logger(string name)
        {
            Name = name;
        }

        public void Debug(string message)
        {
            if (IgnoreDebug)
                return;

            Log(DEBUG, message);
        }

        public void Info(string message)
        {
            Log(INFO, message);
        }

        public void Warn(string message, Exception ex = null)
        {
            Log(WARN, message, ex);
        }

        public void Error(string message, Exception ex = null)
        {
            Log(ERROR, message, ex);
        }

        private void Log(string level, string message, Exception ex = null)
        {
            if (!CheckListening())
                return;

            if (ex != null)
                message += $"{NewLine}{ex.Message}{NewLine}{ex.StackTrace}";

            if (message.Length > MaxStringLength)
            {
                BooleanResult tempFileResult = DirectoryHelper.MakeTempPath(
                    TargetDirectory.FullName, Name);
                File.WriteAllText(tempFileResult.Message, message);
                message = message.Substring(0, MaxStringLength);
                message += $@"{NewLine}{NewLine}Message length > {MaxStringLength}. " +
                           @"Please refer to for full " +
                           $@"message: {tempFileResult.Message}.";
            }

            var info = new LogMessageInfo(level, Name, message);
            var msg = info.ToString();

            lock (LogQueue)
            {
                LogQueue.AppendLine(msg);
            }

            LogMessageAdded?.Invoke(this, info); // Block caller.
        }

        private bool CheckListening()
        {
            if (Listening)
                return true;

            if (_startedErrorShown) return false;
            //Console.WriteLine("Logging has not been started.");
            _startedErrorShown = true; // No need to excessively repeat this message.
            return false;
        }
    }

    public sealed class LogMessageInfo : EventArgs
    {
        public readonly DateTime Timestamp;
        public readonly string ThreadId;
        public readonly string Level;
        public readonly string Logger;
        public readonly string Message;

        public bool IsError => Utility.Logger.ERROR.Equals(Level, StringComparison.Ordinal);
        public bool IsWarning => Utility.Logger.WARN.Equals(Level, StringComparison.Ordinal);
        public bool IsInformation => Utility.Logger.INFO.Equals(Level, StringComparison.Ordinal);
        public bool IsDebug => Utility.Logger.DEBUG.Equals(Level, StringComparison.Ordinal);

        public LogMessageInfo(string level, string logger, string message)
        {
            Timestamp = DateTime.UtcNow;
            var thread = Thread.CurrentThread;
            ThreadId = string.IsNullOrEmpty(thread.Name) ? thread.ManagedThreadId.ToString() : thread.Name;
            Level = level;
            Logger = logger;
            Message = message;
        }

        public override string ToString()
        {
            return string.Format("{0:yyyy/MM/dd HH:mm:ss.fff} {1} {2} {3} {4}",
                Timestamp, ThreadId, Logger, Level, Message);
        }
    }
}
