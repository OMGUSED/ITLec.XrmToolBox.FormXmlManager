namespace ITLec.FormXmlManager.Forms
{
    partial class FormXmlEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGenerateNewGuid = new System.Windows.Forms.Button();
            this.ddlNewGuid = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTxtParent = new System.Windows.Forms.Panel();
            this.tecVisualizationDescription = new ICSharpCode.TextEditor.TextEditorControl();
            this.panelStatistics = new System.Windows.Forms.Panel();
            this.buttonUpdateStatistics = new System.Windows.Forms.Button();
            this.listViewControlsAnalysis = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFormXmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePublishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTitle.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTxtParent.SuspendLayout();
            this.panelStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.White;
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(916, 46);
            this.pnlTitle.TabIndex = 0;
            this.pnlTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitle_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "FormXml Editor";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGenerateNewGuid);
            this.panel2.Controls.Add(this.ddlNewGuid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 514);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 33);
            this.panel2.TabIndex = 1;
            // 
            // btnGenerateNewGuid
            // 
            this.btnGenerateNewGuid.Location = new System.Drawing.Point(10, 2);
            this.btnGenerateNewGuid.Name = "btnGenerateNewGuid";
            this.btnGenerateNewGuid.Size = new System.Drawing.Size(164, 23);
            this.btnGenerateNewGuid.TabIndex = 12;
            this.btnGenerateNewGuid.Text = "New Guid For All=>";
            this.btnGenerateNewGuid.UseVisualStyleBackColor = true;
            this.btnGenerateNewGuid.Click += new System.EventHandler(this.btnGenerateNewGuid_Click);
            // 
            // ddlNewGuid
            // 
            this.ddlNewGuid.FormattingEnabled = true;
            this.ddlNewGuid.Items.AddRange(new object[] {
            "tab",
            "section",
            "cell"});
            this.ddlNewGuid.Location = new System.Drawing.Point(180, 5);
            this.ddlNewGuid.Name = "ddlNewGuid";
            this.ddlNewGuid.Size = new System.Drawing.Size(93, 21);
            this.ddlNewGuid.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtDescription);
            this.panel3.Controls.Add(this.txtName);
            this.panel3.Controls.Add(this.lblDesc);
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Controls.Add(this.lblName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 46);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(916, 72);
            this.panel3.TabIndex = 10;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(11, 50);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(60, 13);
            this.lblDesc.TabIndex = 12;
            this.lblDesc.Text = "Description";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(11, 31);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(98, 47);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(807, 20);
            this.txtDescription.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(98, 28);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(807, 20);
            this.txtName.TabIndex = 9;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionToolStripMenuItem,
            this.controlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(916, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelTxtParent);
            this.panel1.Controls.Add(this.panelStatistics);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 118);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 396);
            this.panel1.TabIndex = 11;
            // 
            // panelTxtParent
            // 
            this.panelTxtParent.Controls.Add(this.tecVisualizationDescription);
            this.panelTxtParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTxtParent.Location = new System.Drawing.Point(0, 0);
            this.panelTxtParent.Margin = new System.Windows.Forms.Padding(2);
            this.panelTxtParent.Name = "panelTxtParent";
            this.panelTxtParent.Size = new System.Drawing.Size(733, 396);
            this.panelTxtParent.TabIndex = 11;
            // 
            // tecVisualizationDescription
            // 
            this.tecVisualizationDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tecVisualizationDescription.IsReadOnly = false;
            this.tecVisualizationDescription.Location = new System.Drawing.Point(0, 0);
            this.tecVisualizationDescription.Margin = new System.Windows.Forms.Padding(2);
            this.tecVisualizationDescription.Name = "tecVisualizationDescription";
            this.tecVisualizationDescription.Size = new System.Drawing.Size(733, 396);
            this.tecVisualizationDescription.TabIndex = 9;
            // 
            // panelStatistics
            // 
            this.panelStatistics.Controls.Add(this.buttonUpdateStatistics);
            this.panelStatistics.Controls.Add(this.listViewControlsAnalysis);
            this.panelStatistics.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelStatistics.Location = new System.Drawing.Point(733, 0);
            this.panelStatistics.Margin = new System.Windows.Forms.Padding(2);
            this.panelStatistics.Name = "panelStatistics";
            this.panelStatistics.Size = new System.Drawing.Size(183, 396);
            this.panelStatistics.TabIndex = 10;
            // 
            // buttonUpdateStatistics
            // 
            this.buttonUpdateStatistics.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonUpdateStatistics.Location = new System.Drawing.Point(0, 377);
            this.buttonUpdateStatistics.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdateStatistics.Name = "buttonUpdateStatistics";
            this.buttonUpdateStatistics.Size = new System.Drawing.Size(183, 19);
            this.buttonUpdateStatistics.TabIndex = 81;
            this.buttonUpdateStatistics.Text = "Recheck FormXml";
            this.buttonUpdateStatistics.UseVisualStyleBackColor = true;
            this.buttonUpdateStatistics.Click += new System.EventHandler(this.buttonUpdateStatistics_Click);
            // 
            // listViewControlsAnalysis
            // 
            this.listViewControlsAnalysis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewControlsAnalysis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewControlsAnalysis.FullRowSelect = true;
            this.listViewControlsAnalysis.HideSelection = false;
            this.listViewControlsAnalysis.Location = new System.Drawing.Point(0, 0);
            this.listViewControlsAnalysis.Name = "listViewControlsAnalysis";
            this.listViewControlsAnalysis.Size = new System.Drawing.Size(183, 396);
            this.listViewControlsAnalysis.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewControlsAnalysis.TabIndex = 80;
            this.listViewControlsAnalysis.UseCompatibleStateImageBehavior = false;
            this.listViewControlsAnalysis.View = System.Windows.Forms.View.Details;
            this.listViewControlsAnalysis.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewControlsAnalysis_ColumnClick);
            this.listViewControlsAnalysis.SelectedIndexChanged += new System.EventHandler(this.listViewControlsAnalysis_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Control Name";
            this.columnHeader1.Width = 148;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "#";
            this.columnHeader2.Width = 73;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.deleteFormXmlToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // deleteFormXmlToolStripMenuItem
            // 
            this.deleteFormXmlToolStripMenuItem.Name = "deleteFormXmlToolStripMenuItem";
            this.deleteFormXmlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteFormXmlToolStripMenuItem.Text = "&Delete FormXml";
            this.deleteFormXmlToolStripMenuItem.Click += new System.EventHandler(this.buttonDeleteFormXml_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.buttonSaveAs_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.publishToolStripMenuItem,
            this.updatePublishToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actionToolStripMenuItem.Text = "&Action";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateToolStripMenuItem.Text = "&Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // updatePublishToolStripMenuItem
            // 
            this.updatePublishToolStripMenuItem.Name = "updatePublishToolStripMenuItem";
            this.updatePublishToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updatePublishToolStripMenuItem.Text = "Update && Publish";
            this.updatePublishToolStripMenuItem.Click += new System.EventHandler(this.btnUpdatePublish_Click);
            // 
            // publishToolStripMenuItem
            // 
            this.publishToolStripMenuItem.Name = "publishToolStripMenuItem";
            this.publishToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.publishToolStripMenuItem.Text = "&Publish";
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortToolStripMenuItem});
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.controlToolStripMenuItem.Text = "&Control";
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nOrderToolStripMenuItem,
            this.zOrderToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sortToolStripMenuItem.Text = "&Sort";
            // 
            // nOrderToolStripMenuItem
            // 
            this.nOrderToolStripMenuItem.Name = "nOrderToolStripMenuItem";
            this.nOrderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nOrderToolStripMenuItem.Text = "&N-Order";
            // 
            // zOrderToolStripMenuItem
            // 
            this.zOrderToolStripMenuItem.Name = "zOrderToolStripMenuItem";
            this.zOrderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zOrderToolStripMenuItem.Text = "&Z-Order";
            // 
            // FormXmlEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlTitle);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormXmlEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormXml Editor";
            this.Load += new System.EventHandler(this.FormXmlEditor_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelTxtParent.ResumeLayout(false);
            this.panelStatistics.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel1;
        private ICSharpCode.TextEditor.TextEditorControl tecVisualizationDescription;
        private System.Windows.Forms.Panel panelStatistics;
        private System.Windows.Forms.Panel panelTxtParent;
        private System.Windows.Forms.ListView listViewControlsAnalysis;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button buttonUpdateStatistics;
        private System.Windows.Forms.Button btnGenerateNewGuid;
        private System.Windows.Forms.ComboBox ddlNewGuid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteFormXmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePublishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zOrderToolStripMenuItem;
    }
}