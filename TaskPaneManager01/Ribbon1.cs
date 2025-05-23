using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskPaneManager01.TaskPane;

namespace TaskPaneManager01
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnMain_Click(object sender, RibbonControlEventArgs e)
        {
            ThisAddIn.PaneManager.Toggle(PaneType.Main);
        }

        private void btnSettings_Click(object sender, RibbonControlEventArgs e)
        {
            ThisAddIn.PaneManager.Toggle(PaneType.Settings);

        }

        private void btnHelp_Click(object sender, RibbonControlEventArgs e)
        {
            ThisAddIn.PaneManager.Toggle(PaneType.Help);

        }
    }
}
