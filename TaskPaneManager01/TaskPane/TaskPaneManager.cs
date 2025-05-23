// TaskPaneManager.cs

using System;
using System.Collections.Generic;
using Microsoft.Office.Tools;

namespace TaskPaneManager01.TaskPane
{
    public class TaskPaneManager
    {
        private readonly CustomTaskPaneCollection _panes;
        private readonly ITaskPaneFactory        _factory;
        private readonly Dictionary<PaneType, CustomTaskPane> _cache;
        private readonly IPowerPointContext _context;

        public TaskPaneManager(CustomTaskPaneCollection panes, 
            ITaskPaneFactory factory, IPowerPointContext context)
        {
            _panes   = panes ?? throw new ArgumentNullException("panes");
            _factory = factory ?? throw new ArgumentNullException("factory");
            _cache   = new Dictionary<PaneType, CustomTaskPane>();
            _context = context ?? throw new ArgumentNullException("context");
        }

        /// <summary>Toggle visibility of the specified pane.</summary>
        public void Toggle(PaneType which)
        {
            CustomTaskPane pane = GetOrCreate(which);
            pane.Visible = !pane.Visible;
        }

        /// <summary>Show the specified pane.</summary>
        public void Show(PaneType which)
        {
            CustomTaskPane pane = GetOrCreate(which);
            pane.Visible = true;
        }

        /// <summary>Hide the specified pane if it exists.</summary>
        public void Hide(PaneType which)
        {
            if (_cache.TryGetValue(which, out var value))
                value.Visible = false;
        }

        private CustomTaskPane GetOrCreate(PaneType which)
        {
            if (_cache.TryGetValue(which, out var existing))
                return existing;

            var ctl   = _factory.Create(which, _context);
            var title = _factory.GetTitle(which);
            var pane  = _panes.Add(ctl, title);

            // configure docking & size
            pane.DockPosition = _factory.GetDockPosition(which);
            pane.Width        = _factory.GetWidth(which);

            // ** forward visibility changes **
            pane.VisibleChanged += (sender, args) =>
            {
                var ctp = (CustomTaskPane)sender;
                if (ctp.Control is ITaskPaneAware aware)
                    aware.OnToggle(ctp.Visible);
            };

            _cache.Add(which, pane);
            return pane;
        }
    }
}
