// TaskPaneManager.cs

using System;
using System.Collections.Generic;
using Microsoft.Office.Tools;
using CommonUtilities.Utility; // Add for Logger

namespace TaskPaneManager01.TaskPane
{
    public class TaskPaneManager
    {
        private static readonly Logger Logger = new Logger(typeof(TaskPaneManager));

        private readonly CustomTaskPaneCollection _panes;
        private readonly ITaskPaneFactory        _factory;
        private readonly Dictionary<PaneType, CustomTaskPane> _cache;
        private readonly IPowerPointContext _context;

        public TaskPaneManager(CustomTaskPaneCollection panes, 
            ITaskPaneFactory factory, IPowerPointContext context)
        {
            Logger.Info("TaskPaneManager constructor called.");
            _panes   = panes ?? throw new ArgumentNullException("panes");
            _factory = factory ?? throw new ArgumentNullException("factory");
            _cache   = new Dictionary<PaneType, CustomTaskPane>();
            _context = context ?? throw new ArgumentNullException("context");
            Logger.Info("TaskPaneManager initialized.");
        }

        /// <summary>Toggle visibility of the specified pane.</summary>
        public void Toggle(PaneType which)
        {
            Logger.Info($"Toggle called for pane: {which}");
            try
            {
                CustomTaskPane pane = GetOrCreate(which);
                pane.Visible = !pane.Visible;
                Logger.Debug($"Pane '{which}' visibility set to {pane.Visible}.");
            }
            catch (Exception ex)
            {
                Logger.Error($"Exception in Toggle for pane: {which}", ex);
                throw;
            }
        }

        /// <summary>Show the specified pane.</summary>
        public void Show(PaneType which)
        {
            Logger.Info($"Show called for pane: {which}");
            try
            {
                CustomTaskPane pane = GetOrCreate(which);
                pane.Visible = true;
                Logger.Debug($"Pane '{which}' set to visible.");
            }
            catch (Exception ex)
            {
                Logger.Error($"Exception in Show for pane: {which}", ex);
                throw;
            }
        }

        /// <summary>Hide the specified pane if it exists.</summary>
        public void Hide(PaneType which)
        {
            Logger.Info($"Hide called for pane: {which}");
            try
            {
                if (_cache.TryGetValue(which, out var value))
                {
                    value.Visible = false;
                    Logger.Debug($"Pane '{which}' set to hidden.");
                }
                else
                {
                    Logger.Debug($"Pane '{which}' not found in cache. Nothing to hide.");
                }
            }
            catch (Exception ex)
            {
                Logger.Error($"Exception in Hide for pane: {which}", ex);
                throw;
            }
        }

        private CustomTaskPane GetOrCreate(PaneType which)
        {
            Logger.Debug($"GetOrCreate called for pane: {which}");
            if (_cache.TryGetValue(which, out var existing))
            {
                Logger.Debug($"Pane '{which}' found in cache.");
                return existing;
            }

            try
            {
                Logger.Debug($"Pane '{which}' not found in cache. Creating new pane.");
                var ctl   = _factory.Create(which, _context);
                var title = _factory.GetTitle(which);
                var pane  = _panes.Add(ctl, title);

                // configure docking & size
                pane.DockPosition = _factory.GetDockPosition(which);
                pane.Width        = _factory.GetWidth(which);

                Logger.Info($"Pane '{which}' created with title '{title}', dock position '{pane.DockPosition}', width {pane.Width}.");

                // ** forward visibility changes **
                pane.VisibleChanged += (sender, args) =>
                {
                    var ctp = (CustomTaskPane)sender;
                    Logger.Debug($"VisibleChanged event for pane '{which}', visible: {ctp.Visible}.");
                    if (ctp.Control is ITaskPaneAware aware)
                    {
                        Logger.Debug($"Notifying ITaskPaneAware.OnToggle for pane '{which}'.");
                        aware.OnToggle(ctp.Visible);
                    }
                };

                _cache.Add(which, pane);
                Logger.Debug($"Pane '{which}' added to cache.");
                return pane;
            }
            catch (Exception ex)
            {
                Logger.Error($"Exception in GetOrCreate for pane: {which}", ex);
                throw;
            }
        }
    }
}