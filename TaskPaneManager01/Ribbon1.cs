using Microsoft.Office.Tools.Ribbon;
using System;
using TaskPaneManager01.TaskPane;
using CommonUtilities.Utility; // Add for Logger

namespace TaskPaneManager01
{
    public partial class Ribbon1
    {
        private static readonly Logger Logger = new Logger(typeof(Ribbon1));

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            Logger.Info("Ribbon1_Load called.");
        }

        private void btnMain_Click(object sender, RibbonControlEventArgs e)
        {
            Logger.Info("btnMain_Click called.");
            try
            {
                ThisAddIn.PaneManager.Toggle(PaneType.Main);
                Logger.Debug("PaneType.Main toggled.");
            }
            catch (Exception ex)
            {
                Logger.Error("Exception in btnMain_Click.", ex);
                throw;
            }
        }

        private void btnSettings_Click(object sender, RibbonControlEventArgs e)
        {
            Logger.Info("btnSettings_Click called.");
            try
            {
                ThisAddIn.PaneManager.Toggle(PaneType.Settings);
                Logger.Debug("PaneType.Settings toggled.");
            }
            catch (Exception ex)
            {
                Logger.Error("Exception in btnSettings_Click.", ex);
                throw;
            }
        }

        private void btnHelp_Click(object sender, RibbonControlEventArgs e)
        {
            Logger.Info("btnHelp_Click called.");
            try
            {
                ThisAddIn.PaneManager.Toggle(PaneType.Help);
                Logger.Debug("PaneType.Help toggled.");
            }
            catch (Exception ex)
            {
                Logger.Error("Exception in btnHelp_Click.", ex);
                throw;
            }
        }
    }
}