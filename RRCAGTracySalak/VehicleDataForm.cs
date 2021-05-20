﻿/*
 * Name: Tracy Salak
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2021-04-12
 * Updated: 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRCAGTracySalak
{
    public partial class VehicleDataForm : Form
    {
        private OleDbConnection connection;
        private OleDbDataAdapter adapter;
        private DataSet dataset;
        private BindingSource bindingSource;
        private int currentRow = -1, initialRows = 0;
        private bool gridViewChanges = false;

        public VehicleDataForm()
        {
            InitializeComponent();
            this.Load += VehicleDataForm_Load;
            this.mnuVehicleFileSave.Click += MnuVehicleFileSave_Click;
            this.dgvVehicleData.RowStateChanged += DgvVehicleData_RowStateChanged;
            this.mnuVehicleEditDelete.Click += MnuVehicleEditDelete_Click;
            this.dgvVehicleData.CellValueChanged += DgvVehicleData_CellValueChanged;
            this.mnuVehicleFileClose.Click += MnuVehicleFileClose_Click;
        }
        
        private void VehicleDataForm_Load(object sender, EventArgs e)
        {
            RetrieveDataFromTheDatabase();
            if (this.connection.State == ConnectionState.Open)
            {
                LoadDataGridView();
                dgvVehicleData.ClearSelection();
            }
            else
            {
                MessageBox.Show("Unable to load vehicle data.", "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        #region Events
        private void DgvVehicleData_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (currentRow != e.Row.Index)
            {
                if (e.StateChanged == DataGridViewElementStates.Selected)
                {
                    this.mnuVehicleEditDelete.Enabled = true;
                    currentRow = e.Row.Index;
                }
            }
            else
            {
                this.mnuVehicleEditDelete.Enabled = false;
            }
        }

        private void DgvVehicleData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!this.Text.Contains('*'))
            {
                this.Text = "* " + this.Text;
            }
            this.mnuVehicleFileSave.Enabled = true;
            gridViewChanges = true;
        }

        private void MnuVehicleFileClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wish to save the changes?", "Save",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button3);

            switch (result)
            {
                case DialogResult.Cancel:
                    break;
                case DialogResult.No:
                    CloseAllConnections();
                    this.Close();
                    break;
                case DialogResult.Yes:
                    if (!SaveDataToDataBase())
                    {
                        DialogResult resultConfirmation = MessageBox.Show("An error occurred while saving the changes. Do you still wish to close this window?",
                            "Save Error",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button2);
                        if (resultConfirmation == DialogResult.Yes)
                        {
                            CloseAllConnections();
                            this.Close();
                        }
                    }
                    else
                    {
                        CloseAllConnections();
                        this.Close();
                    }
                    break;
            }
        }

        private void MnuVehicleFileSave_Click(object sender, EventArgs e)
        {
            SaveDataToDataBase();
        }

        private void MnuVehicleEditDelete_Click(object sender, EventArgs e)
        {
            if (dgvVehicleData.Rows.Count > 1)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to permanently delete stock item " + dgvVehicleData.Rows[currentRow].Cells[1].Value.ToString() + "?",
                    "Delete Stock Item",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    this.dgvVehicleData.Rows.RemoveAt(currentRow);
                    this.mnuVehicleEditDelete.Enabled = false;
                    SaveDataToDataBase();
                }
            }
            else
            {
                MessageBox.Show("Please select a row");
            }
        }
        #endregion

        #region Database functions
        /// <summary>
        /// Queries the database and populates a dataset.
        /// </summary>
        private void RetrieveDataFromTheDatabase()
        {
            try
            {
                string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='AMDatabase.mdb'";

                this.connection = new OleDbConnection();
                this.connection.ConnectionString = connectionString;
                this.connection.Open();

                OleDbCommand selectCommand = new OleDbCommand();
                selectCommand.CommandText = "SELECT * FROM VehicleStock";
                selectCommand.Connection = this.connection;

                this.adapter = new OleDbDataAdapter();
                this.adapter.SelectCommand = selectCommand;

                OleDbCommandBuilder builder = new OleDbCommandBuilder();
                builder.DataAdapter = this.adapter;

                this.adapter.UpdateCommand = builder.GetUpdateCommand();
                this.adapter.DeleteCommand = builder.GetDeleteCommand();
                this.adapter.InsertCommand = builder.GetInsertCommand();

                this.dataset = new DataSet();

                this.adapter.Fill(this.dataset, "VehicleStock");

                this.initialRows = dataset.Tables[0].Rows.Count;
            }
            catch (Exception e)
            {
                this.connection.Close();
                this.connection.Dispose();
            }
        }

        private void LoadDataGridView()
        {
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataset.Tables["VehicleStock"];
            this.dgvVehicleData.DataSource = bindingSource;
            this.dgvVehicleData.Columns["ID"].Visible = false;
            this.dgvVehicleData.Columns["SoldBy"].Visible = false;
        }

        private bool SaveDataToDataBase()
        {
            bool isUpdateSuccessful = false;
            try
            {
                this.dgvVehicleData.EndEdit();
                this.bindingSource.EndEdit();
                this.adapter.Update(this.dataset, "VehicleStock");
                isUpdateSuccessful = true;
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while deleting the selected vehicle.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isUpdateSuccessful;
        }

        private void CloseAllConnections()
        {
            this.connection.Close();
            this.connection.Dispose();
        }
        #endregion
    }
}
