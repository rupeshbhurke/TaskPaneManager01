using System.Windows.Forms;
using Microsoft.Office.Core;

namespace TaskPaneManager01.TaskPane
{
    // ITaskPaneFactory.cs

    public interface ITaskPaneFactory
    {
        /// <summary>Create the UserControl for the given pane type, wired to the PPT context.</summary>
        UserControl Create(PaneType paneType, IPowerPointContext context);

        /// <summary>Title to display in the task pane header.</summary>
        string GetTitle(PaneType paneType);

        /// <summary>Dock position (Left/Right) for the pane.</summary>
        MsoCTPDockPosition GetDockPosition(PaneType paneType);

        /// <summary>Width in pixels for the pane.</summary>
        int GetWidth(PaneType paneType);
    }
}
