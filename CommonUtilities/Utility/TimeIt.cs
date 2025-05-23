using System;
using System.Diagnostics;
using System.Threading.Tasks;
namespace CommonUtilities.Utility
{
    public static class TimeIt
    {
        public static TResult Exec<TResult>(Action<string> loggerFunc, string functionName,
            Func<TResult> func)
        {
            Stopwatch sw = Stopwatch.StartNew();
            TResult result = func();
            sw.Stop();
            loggerFunc($"(TimeIt.Exec){functionName} took {sw.ElapsedMilliseconds}ms.");
            return result;
        }

        public static void Exec(Action<string> loggerFunc, string actionName,
            Action func)
        {
            Stopwatch sw = Stopwatch.StartNew();
            func();
            sw.Stop();
            loggerFunc($"(TimeIt.Exec){actionName} took {sw.ElapsedMilliseconds}ms.");
        }

        public static async Task<TResult> ExecAsync<TResult>(Action<string> loggerFunc,
            string funcName, Func<Task<TResult>> func)
        {
            Stopwatch sw = Stopwatch.StartNew();
            var result = await func().ConfigureAwait(false);
            sw.Stop();
            loggerFunc($"(TimeIt.ExecAsync){funcName} took {sw.ElapsedMilliseconds}ms.");
            return result;
        }

    }
}
