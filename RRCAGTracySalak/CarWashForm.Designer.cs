
namespace RRCAGTracySalak
{
    partial class CarWashForm
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
            this.mnuStripCarWash = new System.Windows.Forms.MenuStrip();
            this.mnuCarWashFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCarWashFileInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCarWashFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPackage = new System.Windows.Forms.ComboBox();
            this.cmbFragrance = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstBoxInterior = new System.Windows.Forms.ListBox();
            this.lstBoxExterior = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblOutSubtotal = new System.Windows.Forms.Label();
            this.lblOutPST = new System.Windows.Forms.Label();
            this.lblOutGST = new System.Windows.Forms.Label();
            this.lblOutTotal = new System.Windows.Forms.Label();
            this.mnuStripCarWash.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStripCarWash
            // 
            this.mnuStripCarWash.BackColor = System.Drawing.SystemColors.Control;
            this.mnuStripCarWash.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuStripCarWash.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCarWashFile});
            this.mnuStripCarWash.Location = new System.Drawing.Point(0, 0);
            this.mnuStripCarWash.Name = "mnuStripCarWash";
            this.mnuStripCarWash.Size = new System.Drawing.Size(460, 28);
            this.mnuStripCarWash.TabIndex = 0;
            this.mnuStripCarWash.Text = "menu";
            // 
            // mnuCarWashFile
            // 
            this.mnuCarWashFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCarWashFileInvoice,
            this.mnuCarWashFileExit});
            this.mnuCarWashFile.Name = "mnuCarWashFile";
            this.mnuCarWashFile.Size = new System.Drawing.Size(46, 24);
            this.mnuCarWashFile.Text = "&File";
            // 
            // mnuCarWashFileInvoice
            // 
            this.mnuCarWashFileInvoice.Name = "mnuCarWashFileInvoice";
            this.mnuCarWashFileInvoice.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.mnuCarWashFileInvoice.Size = new System.Drawing.Size(289, 26);
            this.mnuCarWashFileInvoice.Text = "Generate &Invoice";
            // 
            // mnuCarWashFileExit
            // 
            this.mnuCarWashFileExit.Name = "mnuCarWashFileExit";
            this.mnuCarWashFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuCarWashFileExit.Size = new System.Drawing.Size(289, 26);
            this.mnuCarWashFileExit.Text = "E&xit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Package:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fragrance:";
            // 
            // cmbPackage
            // 
            this.cmbPackage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPackage.FormattingEnabled = true;
            this.cmbPackage.Location = new System.Drawing.Point(37, 77);
            this.cmbPackage.Name = "cmbPackage";
            this.cmbPackage.Size = new System.Drawing.Size(164, 24);
            this.cmbPackage.TabIndex = 3;
            // 
            // cmbFragrance
            // 
            this.cmbFragrance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFragrance.FormattingEnabled = true;
            this.cmbFragrance.Location = new System.Drawing.Point(252, 77);
            this.cmbFragrance.Name = "cmbFragrance";
            this.cmbFragrance.Size = new System.Drawing.Size(164, 24);
            this.cmbFragrance.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstBoxExterior);
            this.groupBox1.Controls.Add(this.lstBoxInterior);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 220);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Interior:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Exterior:";
            // 
            // lstBoxInterior
            // 
            this.lstBoxInterior.FormattingEnabled = true;
            this.lstBoxInterior.ItemHeight = 16;
            this.lstBoxInterior.Location = new System.Drawing.Point(27, 56);
            this.lstBoxInterior.Name = "lstBoxInterior";
            this.lstBoxInterior.Size = new System.Drawing.Size(162, 116);
            this.lstBoxInterior.TabIndex = 2;
            // 
            // lstBoxExterior
            // 
            this.lstBoxExterior.FormattingEnabled = true;
            this.lstBoxExterior.ItemHeight = 16;
            this.lstBoxExterior.Location = new System.Drawing.Point(240, 56);
            this.lstBoxExterior.Name = "lstBoxExterior";
            this.lstBoxExterior.Size = new System.Drawing.Size(164, 116);
            this.lstBoxExterior.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Subtotal:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 492);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "PST:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 456);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "GST:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutSubtotal
            // 
            this.lblOutSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutSubtotal.Location = new System.Drawing.Point(320, 379);
            this.lblOutSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutSubtotal.Name = "lblOutSubtotal";
            this.lblOutSubtotal.Size = new System.Drawing.Size(125, 27);
            this.lblOutSubtotal.TabIndex = 11;
            this.lblOutSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOutPST
            // 
            this.lblOutPST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutPST.Location = new System.Drawing.Point(320, 415);
            this.lblOutPST.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutPST.Name = "lblOutPST";
            this.lblOutPST.Size = new System.Drawing.Size(125, 27);
            this.lblOutPST.TabIndex = 12;
            this.lblOutPST.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOutGST
            // 
            this.lblOutGST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutGST.Location = new System.Drawing.Point(320, 451);
            this.lblOutGST.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutGST.Name = "lblOutGST";
            this.lblOutGST.Size = new System.Drawing.Size(125, 27);
            this.lblOutGST.TabIndex = 13;
            this.lblOutGST.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOutTotal
            // 
            this.lblOutTotal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblOutTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutTotal.Location = new System.Drawing.Point(320, 487);
            this.lblOutTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutTotal.Name = "lblOutTotal";
            this.lblOutTotal.Size = new System.Drawing.Size(125, 27);
            this.lblOutTotal.TabIndex = 14;
            this.lblOutTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CarWashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 550);
            this.Controls.Add(this.lblOutTotal);
            this.Controls.Add(this.lblOutGST);
            this.Controls.Add(this.lblOutPST);
            this.Controls.Add(this.lblOutSubtotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbFragrance);
            this.Controls.Add(this.cmbPackage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnuStripCarWash);
            this.MainMenuStrip = this.mnuStripCarWash;
            this.Name = "CarWashForm";
            this.Text = "CarWashForm";
            this.mnuStripCarWash.ResumeLayout(false);
            this.mnuStripCarWash.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStripCarWash;
        private System.Windows.Forms.ToolStripMenuItem mnuCarWashFile;
        private System.Windows.Forms.ToolStripMenuItem mnuCarWashFileInvoice;
        private System.Windows.Forms.ToolStripMenuItem mnuCarWashFileExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPackage;
        private System.Windows.Forms.ComboBox cmbFragrance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstBoxExterior;
        private System.Windows.Forms.ListBox lstBoxInterior;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblOutSubtotal;
        private System.Windows.Forms.Label lblOutPST;
        private System.Windows.Forms.Label lblOutGST;
        private System.Windows.Forms.Label lblOutTotal;
    }
}