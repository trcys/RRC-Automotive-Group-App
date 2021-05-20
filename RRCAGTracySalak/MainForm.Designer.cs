
namespace RRCAGTracySalak
{
    partial class MainForm
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenSalesQuote = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenCarWash = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataVehicle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.clsADEVTitle = new System.Windows.Forms.Label();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuData,
            this.mnuHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1067, 28);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "mnuMain";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpen,
            this.toolStripSeparator1,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(46, 24);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenSalesQuote,
            this.mnuOpenCarWash});
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(224, 26);
            this.mnuFileOpen.Text = "&Open";
            // 
            // mnuOpenSalesQuote
            // 
            this.mnuOpenSalesQuote.Name = "mnuOpenSalesQuote";
            this.mnuOpenSalesQuote.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.mnuOpenSalesQuote.Size = new System.Drawing.Size(224, 26);
            this.mnuOpenSalesQuote.Text = "&Sales Quote";
            // 
            // mnuOpenCarWash
            // 
            this.mnuOpenCarWash.Name = "mnuOpenCarWash";
            this.mnuOpenCarWash.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.mnuOpenCarWash.Size = new System.Drawing.Size(224, 26);
            this.mnuOpenCarWash.Text = "&Car Wash";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuFileExit.Size = new System.Drawing.Size(224, 26);
            this.mnuFileExit.Text = "E&xit";
            // 
            // mnuData
            // 
            this.mnuData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDataVehicle});
            this.mnuData.Name = "mnuData";
            this.mnuData.Size = new System.Drawing.Size(55, 24);
            this.mnuData.Text = "&Data";
            // 
            // mnuDataVehicle
            // 
            this.mnuDataVehicle.Name = "mnuDataVehicle";
            this.mnuDataVehicle.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.V)));
            this.mnuDataVehicle.Size = new System.Drawing.Size(239, 26);
            this.mnuDataVehicle.Text = "&Vehicle...";
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(55, 24);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(224, 26);
            this.mnuHelpAbout.Text = "&About...";
            // 
            // clsADEVTitle
            // 
            this.clsADEVTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clsADEVTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.clsADEVTitle.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.clsADEVTitle.Location = new System.Drawing.Point(0, 28);
            this.clsADEVTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clsADEVTitle.Name = "clsADEVTitle";
            this.clsADEVTitle.Size = new System.Drawing.Size(1067, 526);
            this.clsADEVTitle.TabIndex = 1;
            this.clsADEVTitle.Text = "ADEV2008";
            this.clsADEVTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.clsADEVTitle);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "RRC Automotive Group";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.Label clsADEVTitle;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuData;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenSalesQuote;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenCarWash;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuDataVehicle;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
    }
}

