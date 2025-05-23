using System;
using System.Text;

namespace CommonUtilities.Extensions
{
    public static class ExceptionExtensions
    {
        public static string GetFullMessage(this Exception ex, string tab = "")
        {
            if (ex == null)
                return "";
            var msg = ex.Message;
            if (ex.InnerException != null)
            {
                var tempTab = tab + "\t";
                msg += $"{Environment.NewLine}Inner Message : {ex.InnerException.GetFullMessage(tempTab)}";
            }
            return msg;
        }

        public static string GetExtFullMessage(this Exception ex, string tab = "")
        {
            var sb = new StringBuilder();
            sb.AppendLine($"The Exception of type {typeof(Exception)} was thrown. {ex.GetFullMessage()}");
            sb.AppendLine(ex.StackTrace);
            return sb.ToString();
        }
    }
}