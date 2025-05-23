using System;
using System.Collections.Generic;
using Microsoft.Office.Interop.PowerPoint;

namespace TaskPaneManager01.TaskPane
{
    public class PowerPointContext : IPowerPointContext
    {
        private readonly Application _app;
        private readonly List<Shape> _selected = 
            new List<Shape>();

        public PowerPointContext(
            Application application)
        {
            _app = application ?? throw new ArgumentNullException(nameof(application));

            // hook into PPT events
            _app.WindowSelectionChange += OnWindowSelectionChange;
            _app.WindowActivate        += OnWindowActivate;
        }

        public Presentation ActivePresentation
            => _app.ActivePresentation;

        public DocumentWindow ActiveWindow
            => _app.ActiveWindow;

        public IReadOnlyList<Shape> SelectedShapes
            => _selected.AsReadOnly();

        public event EventHandler SelectionChanged;
        public event EventHandler ActiveWindowChanged;

        private void OnWindowActivate(
            Presentation _,
            DocumentWindow docWin)
        {
            ActiveWindowChanged?.Invoke(this, EventArgs.Empty);
            // Refresh selection as well
            CaptureSelection(docWin);
        }

        private void OnWindowSelectionChange(
            Selection selection)
        {
            CaptureSelection(_app.ActiveWindow);
        }

        private void CaptureSelection(
            DocumentWindow window)
        {
            _selected.Clear();
            if (window != null && window.Selection?.ShapeRange != null)
            {
                foreach (Shape shp 
                         in window.Selection.ShapeRange)
                    _selected.Add(shp);
            }
            SelectionChanged?.Invoke(this, EventArgs.Empty);
        }
    }

}
