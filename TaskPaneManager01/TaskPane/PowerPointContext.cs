using System;
using System.Collections.Generic;
using Microsoft.Office.Interop.PowerPoint;
using CommonUtilities.Utility; // Add for Logger

namespace TaskPaneManager01.TaskPane
{
    public class PowerPointContext : IPowerPointContext
    {
        private static readonly Logger Logger = new Logger(typeof(PowerPointContext));

        private readonly Application _app;
        private readonly List<Shape> _selected = 
            new List<Shape>();

        public PowerPointContext(
            Application application)
        {
            Logger.Info("PowerPointContext constructor called.");
            _app = application ?? throw new ArgumentNullException(nameof(application));

            // hook into PPT events
            _app.WindowSelectionChange += OnWindowSelectionChange;
            _app.WindowActivate        += OnWindowActivate;
            Logger.Info("PowerPointContext initialized and event handlers attached.");
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
            Logger.Info("OnWindowActivate called.");
            ActiveWindowChanged?.Invoke(this, EventArgs.Empty);
            // Refresh selection as well
            Logger.Debug("Calling CaptureSelection from OnWindowActivate.");
            CaptureSelection(docWin);
        }

        private void OnWindowSelectionChange(
            Selection selection)
        {
            Logger.Info("OnWindowSelectionChange called.");
            Logger.Debug("Calling CaptureSelection from OnWindowSelectionChange.");
            CaptureSelection(_app.ActiveWindow);
        }

        private void CaptureSelection(DocumentWindow window)
        {
            Logger.Debug("CaptureSelection called.");
            _selected.Clear();
            if (window?.Selection != null)
            {
                try
                {
                    if (window.Selection.ShapeRange != null)
                    {
                        Logger.Debug("ShapeRange is not null, adding shapes to _selected.");
                        foreach (Shape shp in window.Selection.ShapeRange)
                            _selected.Add(shp);
                        Logger.Info($"{_selected.Count} shapes selected.");
                    }
                    else
                    {
                        Logger.Debug("ShapeRange is null, no shapes selected.");
                    }
                }
                catch (System.Runtime.InteropServices.COMException ex)
                {
                    Logger.Warn("COMException caught in CaptureSelection (likely no valid shape selection).", ex);
                }
            }
            else
            {
                Logger.Debug("window or window.Selection is null in CaptureSelection.");
            }
            SelectionChanged?.Invoke(this, EventArgs.Empty);
            Logger.Debug("SelectionChanged event invoked.");
        }   
    }
}