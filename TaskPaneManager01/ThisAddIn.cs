using CommonUtilities.Utility;
using System;
using System.IO;
using System.Threading; // Add for Logger
using TaskPaneManager01.TaskPane;

namespace TaskPaneManager01
{
    public partial class ThisAddIn
    {
        private static readonly Logger _logger = new Logger(typeof(ThisAddIn));

        internal static TaskPaneManager PaneManager { get; set; }

        private static IPowerPointContext Context { get; set; }

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            string tempFolderPath = Path.GetTempPath();
            string logFileName = $"{AppConstants.AppName}_Log_{DateTime.Now:yyyyMMdd_HHmmss_fff}.log";
            var targetLogFile = new FileInfo(Path.Combine(tempFolderPath, logFileName));
            Logger.LogToConsole = true;  // Print log entries to console (optional).
            Logger.Start(targetLogFile); // Loggers will complains if you skip 

            _logger.Info($"*** Logger started at {DateTime.Now:yyyyMMdd_HHmmss.fff} ***");
            
            System.Windows.Forms.Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException       += CurrentDomain_UnhandledException;

            try
            {
                // wire up with the default factory
                // 1) Build your shared context
                _logger.Debug("Creating PowerPointContext.");
                Context = new PowerPointContext(this.Application);

                // 2) Build your TaskPaneManager as before, passing in Context if it needs it
                _logger.Debug("Creating DefaultTaskPaneFactory.");
                var factory = new DefaultTaskPaneFactory();

                _logger.Debug("Creating TaskPaneManager.");
                PaneManager = new TaskPaneManager(CustomTaskPanes, factory, Context);

                _logger.Info("ThisAddIn_Startup completed successfully.");
            }
            catch (System.Exception ex)
            {
                _logger.Error("Exception in ThisAddIn_Startup.", ex);
                throw;
            }
        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            // Log the exception details
            if (e.ExceptionObject is Exception exception)
            {
                _logger.Error("Unhandled exception in CurrentDomain_UnhandledException.", exception);
            }
            else
            {
                _logger.Error("Unhandled exception in CurrentDomain_UnhandledException.", new Exception("Unknown exception type."));
            }
        }

        private void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            // Log the exception details
            _logger.Error("Unhandled exception in Application_ThreadException.", e.Exception);
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            _logger.Info("ThisAddIn_Shutdown called.");
            try
            {
                // optional cleanup:
                // foreach (var pane in PaneManager.AllPanes) this.CustomTaskPanes.Remove(pane);
                _logger.Debug("Shutdown logic executed (if any).");
            }
            catch (System.Exception ex)
            {
                _logger.Error("Exception in ThisAddIn_Shutdown.", ex);
                throw;
            }
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            _logger.Info("InternalStartup called.");
            this.Startup += ThisAddIn_Startup;
            this.Shutdown += ThisAddIn_Shutdown;
        }

        #endregion
    }
}