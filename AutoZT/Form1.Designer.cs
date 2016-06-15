namespace AutoZT
{
    partial class Form1
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
            this.openExcelFile = new System.Windows.Forms.OpenFileDialog();
            this.fileMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openExcelFileStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonIGS = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.comboDriverBox = new System.Windows.Forms.ComboBox();
            this.tabConTrolSetup = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxDriver = new System.Windows.Forms.GroupBox();
            this.groupBoxSiteName = new System.Windows.Forms.GroupBox();
            this.txtSiteBox = new System.Windows.Forms.TextBox();
            this.txtAONumberBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxOPC = new System.Windows.Forms.GroupBox();
            this.labelPLCNameOPC = new System.Windows.Forms.Label();
            this.labelCHNameOPC = new System.Windows.Forms.Label();
            this.txtPLCBoxOPC = new System.Windows.Forms.TextBox();
            this.txtChannelBoxOPC = new System.Windows.Forms.TextBox();
            this.buttonOPCFile = new System.Windows.Forms.Button();
            this.fileMenu.SuspendLayout();
            this.tabConTrolSetup.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxDriver.SuspendLayout();
            this.groupBoxSiteName.SuspendLayout();
            this.groupBoxOPC.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileMenu
            // 
            this.fileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.fileMenu.Location = new System.Drawing.Point(0, 0);
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(613, 24);
            this.fileMenu.TabIndex = 3;
            this.fileMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openExcelFileStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // openExcelFileStripMenuItem
            // 
            this.openExcelFileStripMenuItem.Name = "openExcelFileStripMenuItem";
            this.openExcelFileStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openExcelFileStripMenuItem.Text = "Open";
            this.openExcelFileStripMenuItem.Click += new System.EventHandler(this.openExcelFileStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // buttonIGS
            // 
            this.buttonIGS.Enabled = false;
            this.buttonIGS.Location = new System.Drawing.Point(53, 108);
            this.buttonIGS.Name = "buttonIGS";
            this.buttonIGS.Size = new System.Drawing.Size(171, 30);
            this.buttonIGS.TabIndex = 4;
            this.buttonIGS.Text = "Save IGS File...";
            this.buttonIGS.UseVisualStyleBackColor = true;
            this.buttonIGS.Click += new System.EventHandler(this.buttonIGS_Click);
            // 
            // comboDriverBox
            // 
            this.comboDriverBox.FormattingEnabled = true;
            this.comboDriverBox.Items.AddRange(new object[] {
            "IGS",
            "GE9"});
            this.comboDriverBox.Location = new System.Drawing.Point(53, 50);
            this.comboDriverBox.Name = "comboDriverBox";
            this.comboDriverBox.Size = new System.Drawing.Size(171, 21);
            this.comboDriverBox.TabIndex = 3;
            this.comboDriverBox.Text = "Select the driver used...";
            this.comboDriverBox.SelectedIndexChanged += new System.EventHandler(this.comboDriverBox_SelectedIndexChanged);
            // 
            // tabConTrolSetup
            // 
            this.tabConTrolSetup.Controls.Add(this.tabPage1);
            this.tabConTrolSetup.Location = new System.Drawing.Point(0, 33);
            this.tabConTrolSetup.Name = "tabConTrolSetup";
            this.tabConTrolSetup.SelectedIndex = 0;
            this.tabConTrolSetup.Size = new System.Drawing.Size(613, 442);
            this.tabConTrolSetup.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxDriver);
            this.tabPage1.Controls.Add(this.groupBoxSiteName);
            this.tabPage1.Controls.Add(this.groupBoxOPC);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(605, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Blackbox Setup";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxDriver
            // 
            this.groupBoxDriver.Controls.Add(this.comboDriverBox);
            this.groupBoxDriver.Controls.Add(this.buttonIGS);
            this.groupBoxDriver.Location = new System.Drawing.Point(3, 186);
            this.groupBoxDriver.Name = "groupBoxDriver";
            this.groupBoxDriver.Size = new System.Drawing.Size(288, 224);
            this.groupBoxDriver.TabIndex = 9;
            this.groupBoxDriver.TabStop = false;
            this.groupBoxDriver.Text = "Driver Information";
            // 
            // groupBoxSiteName
            // 
            this.groupBoxSiteName.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxSiteName.Controls.Add(this.txtSiteBox);
            this.groupBoxSiteName.Controls.Add(this.txtAONumberBox);
            this.groupBoxSiteName.Controls.Add(this.label2);
            this.groupBoxSiteName.Controls.Add(this.label1);
            this.groupBoxSiteName.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSiteName.Name = "groupBoxSiteName";
            this.groupBoxSiteName.Size = new System.Drawing.Size(594, 177);
            this.groupBoxSiteName.TabIndex = 8;
            this.groupBoxSiteName.TabStop = false;
            this.groupBoxSiteName.Text = "Site Information";
            // 
            // txtSiteBox
            // 
            this.txtSiteBox.Location = new System.Drawing.Point(61, 88);
            this.txtSiteBox.Name = "txtSiteBox";
            this.txtSiteBox.Size = new System.Drawing.Size(501, 20);
            this.txtSiteBox.TabIndex = 1;
            // 
            // txtAONumberBox
            // 
            this.txtAONumberBox.Location = new System.Drawing.Point(61, 42);
            this.txtAONumberBox.Name = "txtAONumberBox";
            this.txtAONumberBox.Size = new System.Drawing.Size(501, 20);
            this.txtAONumberBox.TabIndex = 0;
            this.txtAONumberBox.TextChanged += new System.EventHandler(this.txtAONumberBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Site Name (ie NorthLake)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AO Number (ie 500357)";
            // 
            // groupBoxOPC
            // 
            this.groupBoxOPC.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxOPC.Controls.Add(this.labelPLCNameOPC);
            this.groupBoxOPC.Controls.Add(this.labelCHNameOPC);
            this.groupBoxOPC.Controls.Add(this.txtPLCBoxOPC);
            this.groupBoxOPC.Controls.Add(this.txtChannelBoxOPC);
            this.groupBoxOPC.Controls.Add(this.buttonOPCFile);
            this.groupBoxOPC.Location = new System.Drawing.Point(300, 183);
            this.groupBoxOPC.Name = "groupBoxOPC";
            this.groupBoxOPC.Size = new System.Drawing.Size(297, 227);
            this.groupBoxOPC.TabIndex = 7;
            this.groupBoxOPC.TabStop = false;
            this.groupBoxOPC.Text = "OPC Trend Information";
            // 
            // labelPLCNameOPC
            // 
            this.labelPLCNameOPC.AutoSize = true;
            this.labelPLCNameOPC.Location = new System.Drawing.Point(51, 102);
            this.labelPLCNameOPC.Name = "labelPLCNameOPC";
            this.labelPLCNameOPC.Size = new System.Drawing.Size(89, 13);
            this.labelPLCNameOPC.TabIndex = 9;
            this.labelPLCNameOPC.Text = "Driver PLC Name";
            // 
            // labelCHNameOPC
            // 
            this.labelCHNameOPC.AutoSize = true;
            this.labelCHNameOPC.Location = new System.Drawing.Point(51, 41);
            this.labelCHNameOPC.Name = "labelCHNameOPC";
            this.labelCHNameOPC.Size = new System.Drawing.Size(108, 13);
            this.labelCHNameOPC.TabIndex = 8;
            this.labelCHNameOPC.Text = "Driver Channel Name";
            // 
            // txtPLCBoxOPC
            // 
            this.txtPLCBoxOPC.Location = new System.Drawing.Point(54, 118);
            this.txtPLCBoxOPC.Name = "txtPLCBoxOPC";
            this.txtPLCBoxOPC.Size = new System.Drawing.Size(171, 20);
            this.txtPLCBoxOPC.TabIndex = 7;
            // 
            // txtChannelBoxOPC
            // 
            this.txtChannelBoxOPC.Location = new System.Drawing.Point(54, 57);
            this.txtChannelBoxOPC.Name = "txtChannelBoxOPC";
            this.txtChannelBoxOPC.Size = new System.Drawing.Size(171, 20);
            this.txtChannelBoxOPC.TabIndex = 6;
            // 
            // buttonOPCFile
            // 
            this.buttonOPCFile.Location = new System.Drawing.Point(54, 178);
            this.buttonOPCFile.Name = "buttonOPCFile";
            this.buttonOPCFile.Size = new System.Drawing.Size(171, 31);
            this.buttonOPCFile.TabIndex = 5;
            this.buttonOPCFile.Text = "Save OPC Database File...";
            this.buttonOPCFile.UseVisualStyleBackColor = true;
            this.buttonOPCFile.Click += new System.EventHandler(this.buttonOPCFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 474);
            this.Controls.Add(this.tabConTrolSetup);
            this.Controls.Add(this.fileMenu);
            this.MainMenuStrip = this.fileMenu;
            this.Name = "Form1";
            this.Text = "ZenoTrac Automation Tool";
            this.fileMenu.ResumeLayout(false);
            this.fileMenu.PerformLayout();
            this.tabConTrolSetup.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxDriver.ResumeLayout(false);
            this.groupBoxSiteName.ResumeLayout(false);
            this.groupBoxSiteName.PerformLayout();
            this.groupBoxOPC.ResumeLayout(false);
            this.groupBoxOPC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openExcelFile;
        private System.Windows.Forms.MenuStrip fileMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openExcelFileStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.ComboBox comboDriverBox;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button buttonIGS;
        private System.Windows.Forms.TabControl tabConTrolSetup;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBoxOPC;
        private System.Windows.Forms.Button buttonOPCFile;
        private System.Windows.Forms.GroupBox groupBoxSiteName;
        private System.Windows.Forms.GroupBox groupBoxDriver;
        private System.Windows.Forms.TextBox txtSiteBox;
        private System.Windows.Forms.TextBox txtAONumberBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPLCBoxOPC;
        private System.Windows.Forms.TextBox txtChannelBoxOPC;
        private System.Windows.Forms.Label labelPLCNameOPC;
        private System.Windows.Forms.Label labelCHNameOPC;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

