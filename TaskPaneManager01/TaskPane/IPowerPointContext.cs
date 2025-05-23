using System;
using System.Collections.Generic;

namespace TaskPaneManager01.TaskPane
{
    public interface IPowerPointContext
    {
        /// <summary>Currently active presentation (null if none).</summary>
        Microsoft.Office.Interop.PowerPoint.Presentation ActivePresentation { get; }

        /// <summary>Currently active window (null if none).</summary>
        Microsoft.Office.Interop.PowerPoint.DocumentWindow ActiveWindow { get; }

        /// <summary>Currently selected shapes (empty if none).</summary>
        IReadOnlyList<Microsoft.Office.Interop.PowerPoint.Shape> SelectedShapes { get; }

        /// <summary>Fires whenever the selection changes.</summary>
        event EventHandler SelectionChanged;

        /// <summary>Fires whenever the ActiveWindow changes.</summary>
        event EventHandler ActiveWindowChanged;
    }

}