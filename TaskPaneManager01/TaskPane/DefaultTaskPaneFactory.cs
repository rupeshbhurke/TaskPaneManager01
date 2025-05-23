// DefaultTaskPaneFactory.cs

using System;
using System.Windows.Forms;
using Microsoft.Office.Core;

namespace TaskPaneManager01.TaskPane
{
    public class DefaultTaskPaneFactory : ITaskPaneFactory
    {
        public UserControl Create(PaneType paneType, IPowerPointContext context)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));

            UserControl ctl = null;
            switch (paneType)
            {
                case PaneType.Main:
                    ctl = new UserControls.MainTaskPaneControl();
                    break;
                case PaneType.Settings:
                    ctl = new UserControls.SettingsTaskPaneControl();
                    break;
                case PaneType.Help:
                    ctl = new UserControls.HelpTaskPaneControl();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(paneType));
            }
            if (ctl is IPowerPointHost host)
                host.Initialize(context);
            return ctl;
        }

        public string GetTitle(PaneType paneType)
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
                    throw new ArgumentOutOfRangeException("paneType");
            }
        }

        public MsoCTPDockPosition GetDockPosition(PaneType paneType)
        {
            switch (paneType)
            {
                case PaneType.Settings:
                    return MsoCTPDockPosition.msoCTPDockPositionLeft;
                default:
                    return MsoCTPDockPosition.msoCTPDockPositionRight;
            }
        }

        public int GetWidth(PaneType paneType)
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
    }
}
