// DefaultTaskPaneFactory.cs
using System;
using System.Windows.Forms;
using Microsoft.Office.Core;
using CommonUtilities.Utility; // Add this for Logger

namespace TaskPaneManager01.TaskPane
{
    public class DefaultTaskPaneFactory : ITaskPaneFactory
    {
        private static readonly Logger Logger = new Logger(typeof(DefaultTaskPaneFactory));

        public UserControl Create(PaneType paneType, IPowerPointContext context)
        {
            Logger.Info($"Create called with paneType={paneType}, context={(context != null ? "not null" : "null")}");

            if (context == null)
            {
                Logger.Error("ArgumentNullException: context is null.");
                throw new ArgumentNullException(nameof(context));
            }

            try
            {
                UserControl ctl;
                switch (paneType)
                {
                    case PaneType.Main:
                        Logger.Debug("Creating MainTaskPaneControl.");
                        ctl = new UserControls.MainTaskPaneControl();
                        break;
                    case PaneType.Settings:
                        Logger.Debug("Creating SettingsTaskPaneControl.");
                        ctl = new UserControls.SettingsTaskPaneControl();
                        break;
                    case PaneType.Help:
                        Logger.Debug("Creating HelpTaskPaneControl.");
                        ctl = new UserControls.HelpTaskPaneControl();
                        break;
                    default:
                        Logger.Error($"ArgumentOutOfRangeException: Unknown paneType {paneType}");
                        throw new ArgumentOutOfRangeException(nameof(paneType));
                }
                if (ctl is IPowerPointHost host)
                {
                    Logger.Debug("Initializing IPowerPointHost with context.");
                    host.Initialize(context);
                }
                Logger.Info($"Create returning control of type {ctl.GetType().Name}.");
                return ctl;
            }
            catch (Exception ex)
            {
                Logger.Error("Exception in Create.", ex);
                throw;
            }
        }

        public string GetTitle(PaneType paneType)
        {
            Logger.Info($"GetTitle called with paneType={paneType}");
            try
            {
                switch (paneType)
                {
                    case PaneType.Main:
                        return "Content Transfer";
                    case PaneType.Settings:
                        return "Transfer Options";
                    case PaneType.Help:
                        return "Help";
                    default:
                        Logger.Error($"ArgumentOutOfRangeException: Unknown paneType {paneType}");
                        throw new ArgumentOutOfRangeException("paneType");
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Exception in GetTitle.", ex);
                throw;
            }
        }

        public MsoCTPDockPosition GetDockPosition(PaneType paneType)
        {
            Logger.Info($"GetDockPosition called with paneType={paneType}");
            try
            {
                switch (paneType)
                {
                    case PaneType.Settings:
                        return MsoCTPDockPosition.msoCTPDockPositionLeft;
                    default:
                        return MsoCTPDockPosition.msoCTPDockPositionRight;
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Exception in GetDockPosition.", ex);
                throw;
            }
        }

        public int GetWidth(PaneType paneType)
        {
            Logger.Info($"GetWidth called with paneType={paneType}");
            try
            {
                switch (paneType)
                {
                    case PaneType.Main:
                        return 300;
                    case PaneType.Settings:
                        return 250;
                    case PaneType.Help:
                        return 200;
                    default:
                        return 300;
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Exception in GetWidth.", ex);
                throw;
            }
        }
    }
}