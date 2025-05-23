using TaskPaneManager01.TaskPane;

namespace TaskPaneManager01
{
    public partial class ThisAddIn
    {
        internal static TaskPaneManager PaneManager { get; set; }

        private static IPowerPointContext Context { get; set; }

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            // wire up with the default factory
            // 1) Build your shared context
            Context = new PowerPointContext(this.Application);

            // 2) Build your TaskPaneManager as before, passing in Context if it needs it
            var factory = new DefaultTaskPaneFactory();

            PaneManager = new TaskPaneManager(CustomTaskPanes, factory, Context);
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // optional cleanup:
            // foreach (var pane in PaneManager.AllPanes) this.CustomTaskPanes.Remove(pane);
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += ThisAddIn_Startup;
            this.Shutdown += ThisAddIn_Shutdown;
        }

        #endregion
    }
}
