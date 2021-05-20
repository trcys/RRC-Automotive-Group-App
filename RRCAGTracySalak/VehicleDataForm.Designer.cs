
namespace RRCAGTracySalak
{
    partial class VehicleDataForm
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
            this.mnuStripVehicleData = new System.Windows.Forms.MenuStrip();
            this.mnuVehicleFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVehicleFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuVehicleFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVehicleEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVehicleEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvVehicleData = new System.Windows.Forms.DataGridView();
            this.mnuStripVehicleData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleData)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuStripVehicleData
            // 
            this.mnuStripVehicleData.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuStripVehicleData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVehicleFile,
            this.mnuVehicleEdit});
            this.mnuStripVehicleData.Location = new System.Drawing.Point(0, 0);
            this.mnuStripVehicleData.Name = "mnuStripVehicleData";
            this.mnuStripVehicleData.Size = new System.Drawing.Size(1053, 28);
            this.mnuStripVehicleData.TabIndex = 0;
            this.mnuStripVehicleData.Text = "menuStrip1";
            // 
            // mnuVehicleFile
            // 
            this.mnuVehicleFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVehicleFileSave,
            this.toolStripSeparator1,
            this.mnuVehicleFileClose});
            this.mnuVehicleFile.Name = "mnuVehicleFile";
            this.mnuVehicleFile.Size = new System.Drawing.Size(46, 24);
            this.mnuVehicleFile.Text = "&File";
            // 
            // mnuVehicleFileSave
            // 
            this.mnuVehicleFileSave.Name = "mnuVehicleFileSave";
            this.mnuVehicleFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuVehicleFileSave.Size = new System.Drawing.Size(184, 26);
            this.mnuVehicleFileSave.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // mnuVehicleFileClose
            // 
            this.mnuVehicleFileClose.Name = "mnuVehicleFileClose";
            this.mnuVehicleFileClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.mnuVehicleFileClose.Size = new System.Drawing.Size(184, 26);
            this.mnuVehicleFileClose.Text = "&Close";
            // 
            // mnuVehicleEdit
            // 
            this.mnuVehicleEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVehicleEditDelete});
            this.mnuVehicleEdit.Name = "mnuVehicleEdit";
            this.mnuVehicleEdit.Size = new System.Drawing.Size(49, 24);
            this.mnuVehicleEdit.Text = "&Edit";
            // 
            // mnuVehicleEditDelete
            // 
            this.mnuVehicleEditDelete.Name = "mnuVehicleEditDelete";
            this.mnuVehicleEditDelete.Size = new System.Drawing.Size(136, 26);
            this.mnuVehicleEditDelete.Text = "&Delete";
            // 
            // dgvVehicleData
            // 
            this.dgvVehicleData.AllowUserToDeleteRows = false;
            this.dgvVehicleData.AllowUserToResizeRows = false;
            this.dgvVehicleData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehicleData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicleData.Location = new System.Drawing.Point(0, 32);
            this.dgvVehicleData.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVehicleData.MultiSelect = false;
            this.dgvVehicleData.Name = "dgvVehicleData";
            this.dgvVehicleData.RowHeadersWidth = 51;
            this.dgvVehicleData.RowTemplate.Height = 24;
            this.dgvVehicleData.Size = new System.Drawing.Size(1053, 419);
            this.dgvVehicleData.TabIndex = 1;
            // 
            // VehicleDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 449);
            this.Controls.Add(this.dgvVehicleData);
            this.Controls.Add(this.mnuStripVehicleData);
            this.MainMenuStrip = this.mnuStripVehicleData;
            this.Name = "VehicleDataForm";
            this.Text = "VehicleDataForm";
            this.mnuStripVehicleData.ResumeLayout(false);
            this.mnuStripVehicleData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStripVehicleData;
        private System.Windows.Forms.ToolStripMenuItem mnuVehicleFile;
        private System.Windows.Forms.ToolStripMenuItem mnuVehicleFileSave;
        private System.Windows.Forms.ToolStripMenuItem mnuVehicleFileClose;
        private System.Windows.Forms.ToolStripMenuItem mnuVehicleEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuVehicleEditDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dgvVehicleData;
    }
}