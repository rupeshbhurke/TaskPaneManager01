namespace TaskPaneManager01
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.grpTaskPane = this.Factory.CreateRibbonGroup();
            this.btnMain = this.Factory.CreateRibbonButton();
            this.btnSettings = this.Factory.CreateRibbonButton();
            this.btnHelp = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.grpTaskPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.grpTaskPane);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // grpTaskPane
            // 
            this.grpTaskPane.Items.Add(this.btnMain);
            this.grpTaskPane.Items.Add(this.btnSettings);
            this.grpTaskPane.Items.Add(this.btnHelp);
            this.grpTaskPane.Label = "TaskPane";
            this.grpTaskPane.Name = "grpTaskPane";
            // 
            // btnMain
            // 
            this.btnMain.Label = "Main";
            this.btnMain.Name = "btnMain";
            this.btnMain.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnMain_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Label = "Settings";
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSettings_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Label = "Help";
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnHelp_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.PowerPoint.Presentation";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.grpTaskPane.ResumeLayout(false);
            this.grpTaskPane.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpTaskPane;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnMain;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSettings;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnHelp;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
