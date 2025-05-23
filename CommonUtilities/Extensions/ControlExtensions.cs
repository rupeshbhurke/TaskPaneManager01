using System;
using System.Windows.Forms;

namespace CommonUtilities.Extensions
{
    public static class ControlExtensions
    {
        public static void UiThread(this Control control, Action action)
        {
            if (control == null)
                throw new ArgumentNullException(nameof(control), "Control cannot be null.");

            if (control.InvokeRequired)
            {
                control.BeginInvoke(action);
            }
            else
            {
                action?.Invoke();
            }
        }
    }
}