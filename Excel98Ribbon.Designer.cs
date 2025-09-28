namespace Excel98
{
    partial class Excel98Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Excel98Ribbon()
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
            this.tabexcel98 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.btnSetUser = this.Factory.CreateRibbonButton();
            this.btnCreateHomepage = this.Factory.CreateRibbonButton();
            this.btnCreateForumList = this.Factory.CreateRibbonButton();
            this.btnCreateNewTopics = this.Factory.CreateRibbonButton();
            this.tabexcel98.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabexcel98
            // 
            this.tabexcel98.Groups.Add(this.group1);
            this.tabexcel98.Label = "Excel98";
            this.tabexcel98.Name = "tabexcel98";
            // 
            // group1
            // 
            this.group1.Items.Add(this.btnSetUser);
            this.group1.Items.Add(this.btnCreateHomepage);
            this.group1.Items.Add(this.btnCreateForumList);
            this.group1.Items.Add(this.btnCreateNewTopics);
            this.group1.Label = "Excel98";
            this.group1.Name = "group1";
            // 
            // btnSetUser
            // 
            this.btnSetUser.Label = "设置用户";
            this.btnSetUser.Name = "btnSetUser";
            this.btnSetUser.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSetUser_Click);
            // 
            // btnCreateHomepage
            // 
            this.btnCreateHomepage.Label = "98主页";
            this.btnCreateHomepage.Name = "btnCreateHomepage";
            this.btnCreateHomepage.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnCreateHomepage_Click);
            // 
            // btnCreateForumList
            // 
            this.btnCreateForumList.Label = "版面列表";
            this.btnCreateForumList.Name = "btnCreateForumList";
            this.btnCreateForumList.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnCreateForumList_Click);
            // 
            // btnCreateNewTopics
            // 
            this.btnCreateNewTopics.Label = "新帖列表";
            this.btnCreateNewTopics.Name = "btnCreateNewTopics";
            this.btnCreateNewTopics.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnCreateNewTopics_Click);
            // 
            // Excel98Ribbon
            // 
            this.Name = "Excel98Ribbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tabexcel98);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Excel98Ribbon_Load);
            this.tabexcel98.ResumeLayout(false);
            this.tabexcel98.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tabexcel98;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSetUser;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnCreateHomepage;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnCreateForumList;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnCreateNewTopics;
    }

    partial class ThisRibbonCollection
    {
        internal Excel98Ribbon Excel98Ribbon
        {
            get { return this.GetRibbon<Excel98Ribbon>(); }
        }
    }
}
