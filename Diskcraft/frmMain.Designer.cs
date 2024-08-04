
namespace Diskcraft
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnScripts = new System.Windows.Forms.Button();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnOS = new System.Windows.Forms.Button();
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnDeploy = new System.Windows.Forms.Button();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.tsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTools = new System.Windows.Forms.ToolStripMenuItem();
            this.gbElements = new System.Windows.Forms.GroupBox();
            this.btnControl = new System.Windows.Forms.Button();
            this.tsView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMinimize = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMaximize = new System.Windows.Forms.ToolStripMenuItem();
            this.captureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deployToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.injectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deployOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCredits = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDiskcraft = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSeperator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlpMain.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.gbElements.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnScripts
            // 
            this.btnScripts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScripts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScripts.Image = global::Diskcraft.Properties.Resources.injectscript;
            this.btnScripts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScripts.Location = new System.Drawing.Point(3, 76);
            this.btnScripts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnScripts.Name = "btnScripts";
            this.btnScripts.Size = new System.Drawing.Size(224, 65);
            this.btnScripts.TabIndex = 3;
            this.btnScripts.Text = "Inject Script";
            this.btnScripts.UseVisualStyleBackColor = true;
            this.btnScripts.Click += new System.EventHandler(this.btnScripts_Click);
            // 
            // tlpMain
            // 
            this.tlpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.btnScripts, 0, 1);
            this.tlpMain.Controls.Add(this.btnOS, 1, 1);
            this.tlpMain.Controls.Add(this.btnCapture, 0, 0);
            this.tlpMain.Controls.Add(this.btnDeploy, 1, 0);
            this.tlpMain.Location = new System.Drawing.Point(12, 28);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpMain.Size = new System.Drawing.Size(460, 145);
            this.tlpMain.TabIndex = 5;
            // 
            // btnOS
            // 
            this.btnOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOS.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOS.Image = ((System.Drawing.Image)(resources.GetObject("btnOS.Image")));
            this.btnOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOS.Location = new System.Drawing.Point(233, 76);
            this.btnOS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOS.Name = "btnOS";
            this.btnOS.Size = new System.Drawing.Size(224, 65);
            this.btnOS.TabIndex = 4;
            this.btnOS.Text = "Deploy OS";
            this.btnOS.UseVisualStyleBackColor = true;
            this.btnOS.Click += new System.EventHandler(this.btnOS_Click);
            // 
            // btnCapture
            // 
            this.btnCapture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapture.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapture.Image = global::Diskcraft.Properties.Resources.capture;
            this.btnCapture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapture.Location = new System.Drawing.Point(3, 4);
            this.btnCapture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(224, 64);
            this.btnCapture.TabIndex = 1;
            this.btnCapture.Text = "Capture Image";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnDeploy
            // 
            this.btnDeploy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeploy.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeploy.Image = global::Diskcraft.Properties.Resources.deploy;
            this.btnDeploy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeploy.Location = new System.Drawing.Point(233, 4);
            this.btnDeploy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeploy.Name = "btnDeploy";
            this.btnDeploy.Size = new System.Drawing.Size(224, 64);
            this.btnDeploy.TabIndex = 2;
            this.btnDeploy.Text = "Deploy Image";
            this.btnDeploy.UseVisualStyleBackColor = true;
            this.btnDeploy.Click += new System.EventHandler(this.btnDeploy_Click);
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFile,
            this.tsView,
            this.tsTools,
            this.tsAbout});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(484, 24);
            this.menuMain.TabIndex = 6;
            this.menuMain.Text = "Main";
            // 
            // tsFile
            // 
            this.tsFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSettings,
            this.tsSeparator1,
            this.tsExit});
            this.tsFile.Name = "tsFile";
            this.tsFile.Size = new System.Drawing.Size(37, 20);
            this.tsFile.Text = "&File";
            // 
            // tsExit
            // 
            this.tsExit.Name = "tsExit";
            this.tsExit.Size = new System.Drawing.Size(180, 22);
            this.tsExit.Text = "&Exit";
            // 
            // tsTools
            // 
            this.tsTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.captureToolStripMenuItem,
            this.deployToolStripMenuItem,
            this.tsSeperator2,
            this.injectToolStripMenuItem,
            this.deployOSToolStripMenuItem});
            this.tsTools.Name = "tsTools";
            this.tsTools.Size = new System.Drawing.Size(46, 20);
            this.tsTools.Text = "&Tools";
            // 
            // gbElements
            // 
            this.gbElements.Controls.Add(this.btnControl);
            this.gbElements.Location = new System.Drawing.Point(12, 214);
            this.gbElements.Name = "gbElements";
            this.gbElements.Size = new System.Drawing.Size(475, 103);
            this.gbElements.TabIndex = 7;
            this.gbElements.TabStop = false;
            this.gbElements.Text = "Elements";
            // 
            // btnControl
            // 
            this.btnControl.Location = new System.Drawing.Point(16, 26);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(80, 40);
            this.btnControl.TabIndex = 0;
            this.btnControl.Text = "Control";
            this.btnControl.UseVisualStyleBackColor = true;
            // 
            // tsView
            // 
            this.tsView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMinimize,
            this.tsMaximize});
            this.tsView.Name = "tsView";
            this.tsView.Size = new System.Drawing.Size(44, 20);
            this.tsView.Text = "&View";
            // 
            // tsAbout
            // 
            this.tsAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCredits,
            this.tsDiskcraft});
            this.tsAbout.Name = "tsAbout";
            this.tsAbout.Size = new System.Drawing.Size(52, 20);
            this.tsAbout.Text = "&About";
            // 
            // tsMinimize
            // 
            this.tsMinimize.Name = "tsMinimize";
            this.tsMinimize.Size = new System.Drawing.Size(180, 22);
            this.tsMinimize.Text = "&Minimize";
            // 
            // tsMaximize
            // 
            this.tsMaximize.Name = "tsMaximize";
            this.tsMaximize.Size = new System.Drawing.Size(180, 22);
            this.tsMaximize.Text = "&Maximize";
            // 
            // captureToolStripMenuItem
            // 
            this.captureToolStripMenuItem.Name = "captureToolStripMenuItem";
            this.captureToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.captureToolStripMenuItem.Text = "&Capture";
            // 
            // deployToolStripMenuItem
            // 
            this.deployToolStripMenuItem.Name = "deployToolStripMenuItem";
            this.deployToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.deployToolStripMenuItem.Text = "&Deploy";
            // 
            // injectToolStripMenuItem
            // 
            this.injectToolStripMenuItem.Name = "injectToolStripMenuItem";
            this.injectToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.injectToolStripMenuItem.Text = "&Inject Scripts";
            // 
            // deployOSToolStripMenuItem
            // 
            this.deployOSToolStripMenuItem.Name = "deployOSToolStripMenuItem";
            this.deployOSToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.deployOSToolStripMenuItem.Text = "Deploy &Operating System";
            // 
            // tsCredits
            // 
            this.tsCredits.Name = "tsCredits";
            this.tsCredits.Size = new System.Drawing.Size(180, 22);
            this.tsCredits.Text = "&Credits";
            // 
            // tsDiskcraft
            // 
            this.tsDiskcraft.Name = "tsDiskcraft";
            this.tsDiskcraft.Size = new System.Drawing.Size(180, 22);
            this.tsDiskcraft.Text = "&Diskcraft";
            // 
            // tsSettings
            // 
            this.tsSettings.Name = "tsSettings";
            this.tsSettings.Size = new System.Drawing.Size(180, 22);
            this.tsSettings.Text = "&Settings";
            // 
            // tsSeparator1
            // 
            this.tsSeparator1.Name = "tsSeparator1";
            this.tsSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // tsSeperator2
            // 
            this.tsSeperator2.Name = "tsSeperator2";
            this.tsSeperator2.Size = new System.Drawing.Size(205, 6);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 186);
            this.Controls.Add(this.gbElements);
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.menuMain);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(500, 225);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diskcraft";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tlpMain.ResumeLayout(false);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.gbElements.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOS;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Button btnScripts;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Button btnDeploy;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem tsFile;
        private System.Windows.Forms.ToolStripMenuItem tsExit;
        private System.Windows.Forms.ToolStripMenuItem tsTools;
        private System.Windows.Forms.GroupBox gbElements;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.ToolStripMenuItem tsView;
        private System.Windows.Forms.ToolStripMenuItem tsAbout;
        private System.Windows.Forms.ToolStripMenuItem tsSettings;
        private System.Windows.Forms.ToolStripSeparator tsSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsMinimize;
        private System.Windows.Forms.ToolStripMenuItem tsMaximize;
        private System.Windows.Forms.ToolStripMenuItem captureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deployToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem injectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deployOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsCredits;
        private System.Windows.Forms.ToolStripMenuItem tsDiskcraft;
        private System.Windows.Forms.ToolStripSeparator tsSeperator2;
    }
}

