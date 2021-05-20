/*
 * Name: Tracy Salak
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2021-03-22
 * Updated: 2021-04-09
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;
using Salak.Tracy.Business;
using RRCAG.Data;

namespace RRCAGTracySalak
{
    public partial class SalesQuoteForm : Form
    {
        /// <summary>
        /// Assigns the starting variables.
        /// </summary>
        public static Vehicle vehicleInfo;
        decimal vehicleSalesPrice = 1, tradeInAmount = 1, TAXRATE = 0.12M;
        Accessories accessoriesChosen = Accessories.None;
        ExteriorFinish exteriorFinish = ExteriorFinish.None;
        private OleDbConnection connection;
        private OleDbDataAdapter adapter;
        private DataSet dataset;
        private BindingSource bindingSource;

        /// <summary>
        /// Initializes an instance of the SalesQuoteForm class with the design and events.
        /// </summary>
        public SalesQuoteForm()
        {
            InitializeComponent();
            this.Load += SalesQuoteForm_Load;
        }

        /// <summary>
        /// Loads all of the functions.
        /// </summary>
        private void SalesQuoteForm_Load(object sender, EventArgs e)
        {
            this.btnCalcQuote.Click += new EventHandler(this.btnCalcQuote_Click);
            RetrieveDataFromTheDatabase();

            if (this.connection.State == ConnectionState.Open)
            {
                CreateVehicleObjectsFromDataBase();
                LoadVehicleInformationFromDataBase();
            }
            else
            {
                MessageBox.Show("Unable to load vehicle data.", "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

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
            }
            catch(Exception e)
            {
                this.connection.Close();
                this.connection.Dispose();
            }
        }

        /// <summary>
        /// Creates the vehicle object from database.
        /// </summary>
        /// <returns>Selected vehicle</returns>
        private List<Vehicle>  CreateVehicleObjectsFromDataBase()
        {
            List<Vehicle> vehicleList = new List<Vehicle>();
            for (int i = 0; i < this.dataset.Tables[0].Rows.Count; i++)
            {
                vehicleList.Add(new Vehicle(
                    dataset.Tables["VehicleStock"].Rows[i]["StockNumber"].ToString(),
                    (int)(short)dataset.Tables["VehicleStock"].Rows[i]["ManufacturedYear"],
                    dataset.Tables["VehicleStock"].Rows[i]["Make"].ToString(),
                    dataset.Tables["VehicleStock"].Rows[i]["Model"].ToString(),
                    (int)dataset.Tables["VehicleStock"].Rows[i]["Mileage"],
                    (bool)dataset.Tables["VehicleStock"].Rows[i]["Automatic"],
                    dataset.Tables["VehicleStock"].Rows[i]["Colour"].ToString(),
                    (decimal)(double)dataset.Tables["VehicleStock"].Rows[i]["BasePrice"]
                    ));
            }
            return vehicleList;
        }

        /// <summary>
        /// Loads information from the database.
        /// </summary>
        private void LoadVehicleInformationFromDataBase()
        {
            //DataBinding from class Package
            BindingSource bindingVehicles = new BindingSource();
            bindingVehicles.DataSource = CreateVehicleObjectsFromDataBase();
            cmbVehicle.DataSource = bindingVehicles;

            cmbVehicle.DisplayMember = "stockID";
            cmbVehicle.ValueMember = "stockID";
            cmbVehicle.SelectedIndex = -1;
            cmbVehicle.Focus();
        }

        /// <summary>
        /// Loads vehicle information in the DLL.
        /// </summary>
        private void LoadVehicleInformation()
        {
            //DataBinding from class Package
            BindingSource bindingVehicles = new BindingSource();
            bindingVehicles.DataSource = GenerateVehicleObjects();
            cmbVehicle.DataSource = bindingVehicles;

            cmbVehicle.DisplayMember = "stockID";
            cmbVehicle.ValueMember = "stockID";
            cmbVehicle.SelectedIndex = -1;
            cmbVehicle.Focus();
        }

      
        /// <summary>
        /// Creates vehicle objects.
        /// </summary>
        /// <returns>A vehicle object.</returns>
        private List<Vehicle> GenerateVehicleObjects()
        { 
            List<Vehicle> vehicleList = new List<Vehicle>();
            vehicleList.Add(new Vehicle("VEH01", 2019, "KIA", "SORENTO", 24000, true, "BLACK", 10000m));
            vehicleList.Add(new Vehicle("VEH02", 2020, "TOYOTA", "RAV4", 30000, false, "RED", 20000m));
            vehicleList.Add(new Vehicle("VEH03", 2011, "HYUNDAI", "GENESIS COUPE", 11000, false, "GRAY", 30000m));
            vehicleList.Add(new Vehicle("VEH04", 2018, "FORD", "CHARGER4", 550000, true, "BLUE", 40000m));
            vehicleList.Add(new Vehicle("VEH05", 2017, "HONDA", "PILOT", 47000, true, "WHITE", 50000m));
            vehicleList.Add(new Vehicle("VEH06", 2020, "NISSAN", "CALDINA", 37000, true, "BLUE", 60000m));
            return vehicleList;
        }

        /// <summary>
        /// Returns selected vehicle.
        /// </summary>
        private Vehicle ObtainVehicleSelected()
        {
            return (Vehicle)cmbVehicle.SelectedItem;
        }

        /// <summary>
        /// Summarizes the sales quote.
        /// </summary>
        public void SalesQuoteSummary()
        {
            SalesQuote salesQuote = new SalesQuote(vehicleSalesPrice, tradeInAmount, TAXRATE, accessoriesChosen, exteriorFinish);

            txtBoxSumSalePrice.Text = string.Format("{0:C}", salesQuote.VehicleSalePrice);
            txtBoxOptions.Text = (salesQuote.AccessoriesCost + salesQuote.FinishCost).ToString();
            txtBoxSubtotal.Text = string.Format("{0:C}", salesQuote.SubTotal);
            txtBoxSalesTax.Text = salesQuote.SalesTax.ToString();
            txtBoxTotal.Text = string.Format("{0:C}", salesQuote.Total);
            txtBoxSumTradein.Text = (salesQuote.TradeInAmount * -1).ToString();
            txtBoxAmountDue.Text = string.Format("{0:C}", salesQuote.AmountDue);

            txtBoxMonPayment.Text = MonthlyPaymentCalculation(Convert.ToDecimal(txtBoxAmountDue.Text.Substring(1)));

        }

        #region Calculations and Checking
        /// <summary>
        /// Checks to see if a vehicle is selected or not.
        /// </summary>
        private void ValidateVehicleList()
        {
            if (cmbVehicle.SelectedText == "")
            {
                MessageBox.Show("A vehicle must be selected.");
            }
        }

        /// <summary>
        /// Checks the validation of vehicle sale price and trade-in value inputs.
        /// </summary>
        /// <returns>Returns the boolean result of the vehicle sale price and trade-in value inputs.</returns>
        private bool CheckValidation()
        {
            ResetInputErrors();

            bool validVehiclePrice = false, validTradeInPrice = false, valid = false;

            if (cmbVehicle.SelectedIndex < 0)
            {
                cmbVehicle.Focus();
                vehicleCmbError.SetError(cmbVehicle, "A vehicle must be selected.");
            }
            else
            {
                validVehiclePrice = true;
                vehicleSalesPrice = ObtainVehicleSelected().BasePrice;
            }

            /*
             * Trade-In Value Checking
             */
            if (string.IsNullOrEmpty(txtBoxTradeInValue.Text))
            {
                txtBoxTradeInValue.Focus();
                tradeInError.SetError(txtBoxTradeInValue, "Trade-In value is a required field.");
            }
            else if (!decimal.TryParse(txtBoxTradeInValue.Text, out _))
            {
                txtBoxTradeInValue.Focus();
                tradeInError.SetError(txtBoxTradeInValue, "Trade-In value cannot contain letters or special characters.");

            }
            else if (decimal.Parse(txtBoxTradeInValue.Text) < 0.0m)
            {
                txtBoxTradeInValue.Focus();
                tradeInError.SetError(txtBoxTradeInValue, "Trade-In value cannot be less than 0.");
            }
            else
            {
                validTradeInPrice = true;
                tradeInAmount = decimal.Parse(txtBoxTradeInValue.Text);
            }

            if (validVehiclePrice == validTradeInPrice)
            {
                valid = true;
            }

            return valid;
        }

        /// <summary>
        /// Sets the chosen accessory.
        /// </summary>
        private void AccessoryChosen()
        {
            string accChosen = "";

            if (chkBoxStereoSystem.Checked)
            {
                accChosen += "1";
            }
            if (chkBoxLeatherInterior.Checked)
            {
                accChosen += "2";
            }
            if (chkBoxCompNav.Checked)
            {
                accChosen += "3";
            }

            switch (accChosen)
            {
                case "":
                    accessoriesChosen = Accessories.None;
                    break;
                case "123":
                    accessoriesChosen = Accessories.All;
                    break;
                case "1":
                    accessoriesChosen = Accessories.StereoSystem;
                    break;
                case "2":
                    accessoriesChosen = Accessories.LeatherInterior;
                    break;
                case "3":
                    accessoriesChosen = Accessories.ComputerNavigation;
                    break;
                case "12":
                    accessoriesChosen = Accessories.StereoAndLeather;
                    break;
                case "13":
                    accessoriesChosen = Accessories.StereoAndNavigation;
                    break;
                case "23":
                    accessoriesChosen = Accessories.LeatherAndNavigation;
                    break;
            }
        }

        /// <summary>
        /// Sets the chosen exterior finish.
        /// </summary>
        private void ExteriorFinChosen()
        {
            if (radBtnStandard.Checked)
            {
                exteriorFinish = ExteriorFinish.Standard;
            }
            else if (radBtnPearlized.Checked)
            {
                exteriorFinish = ExteriorFinish.Pearlized;
            }
            else if (radBtnCustomized.Checked)
            {
                exteriorFinish = ExteriorFinish.Custom;
            }
        }

        /// <summary>
        /// Calculates the monthly payment.
        /// </summary>
        private string MonthlyPaymentCalculation(decimal amountDue)
        {
            decimal monthlyPayment = 0M;
            decimal monthlyPaymentPeriod = numNumYears.Value * 12;
            decimal interest = numInterestRate.Value / 100;

            if (txtBoxAmountDue.Text != null || txtBoxAmountDue.Text != "")
            {
                if (interest == 0)
                {
                    monthlyPayment = amountDue / monthlyPaymentPeriod;

                }
                else
                {
                    monthlyPayment = (amountDue * (1 + interest)) / monthlyPaymentPeriod;
                }
            }

            return string.Format("{0:C}", monthlyPayment);
        }

        /// <summary>
        /// Does all the checks and clears needed for the sales quote form.
        /// </summary>
        private void Calculation()
        {
            if (CheckValidation())
            {
                AccessoryChosen();
                ExteriorFinChosen();
                SalesQuoteSummary();

            }
            else
            {
                ClearControls();
                ClearInputs();
            }
        }
#endregion

        #region Events
        /// <summary>
        /// Handles the click event of the reset button.
        /// </summary>
        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to reset the form?", "Reset Form",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                ClearControls();
                ClearInputs();

                cmbVehicle.Focus();
            }
        }

        /// <summary>
        /// Handles the click event of the calculation quote button.
        /// </summary>
        private void btnCalcQuote_Click(object sender, EventArgs e)
        {
            Calculation();
        }

        /// <summary>
        /// Handles the text changed event of vehicle sales price text box by clearing the inputs.
        /// </summary>
        private void txtBoxVehicleSalePrice_TextChanged(object sender, EventArgs e)
        {
            ClearInputs();
        }

        /// <summary>
        /// Handles the text changed event of trade-in value text box by clearing the inputs.
        /// </summary>
        private void txtBoxTradeInValue_TextChanged(object sender, EventArgs e)
        {
            ClearInputs();
        }

        /// <summary>
        /// Handles the event when stereo system check box is checked.
        /// </summary>
        private void chkBoxStereoSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (txtBoxAmountDue.Text != null || txtBoxAmountDue.Text != "")
            {
                Calculation();
            }
        }

        /// <summary>
        /// Handles the event when leather interior check box is checked.
        /// </summary>
        private void chkBoxLeatherInterior_CheckedChanged(object sender, EventArgs e)
        {
            if (txtBoxAmountDue.Text != null || txtBoxAmountDue.Text != "")
            {
                Calculation();
            }
        }

        /// <summary>
        /// Handles the event when computer navigation check box is checked.
        /// </summary>
        private void chkBoxCompNav_CheckedChanged(object sender, EventArgs e)
        {
            if (txtBoxAmountDue.Text != null || txtBoxAmountDue.Text != "")
            {
                Calculation();
            }
        }

        /// <summary>
        /// Handles the event when standard radio button is checked.
        /// </summary>
        private void radBtnStandard_CheckedChanged(object sender, EventArgs e)
        {
            if (txtBoxAmountDue.Text != null || txtBoxAmountDue.Text != "")
            {
                Calculation();
            }
        }

        /// <summary>
        /// Handles the event when pearlized radio button is checked.
        /// </summary>
        private void radBtnPearlized_CheckedChanged(object sender, EventArgs e)
        {
            if (txtBoxAmountDue.Text != null || txtBoxAmountDue.Text != "")
            {
                Calculation();
            }
        }

        /// <summary>
        /// Handles the event when customized detailing radio button is checked.
        /// </summary>
        private void radBtnCustomized_CheckedChanged(object sender, EventArgs e)
        {
            if (txtBoxAmountDue.Text != null || txtBoxAmountDue.Text != "")
            {
                Calculation();
            }
        }

        /// <summary>
        /// Handles the event when the number of years value is changed.
        /// </summary>
        private void numNumYears_ValueChanged(object sender, EventArgs e)
        {
            if (txtBoxAmountDue.Text != null || txtBoxAmountDue.Text != "")
            {
                Calculation();
            }
        }

        /// <summary>
        /// Handles the text changed event of trade-in value text box by clearing the inputs.
        /// </summary>
        private void numInterestRate_ValueChanged(object sender, EventArgs e)
        {
            if (txtBoxAmountDue.Text != null || txtBoxAmountDue.Text != "")
            {
                Calculation();
            }
        }
        #endregion

        #region Reset and Clear functions
        /// <summary>
        /// Clears the inputs of text boxes.
        /// </summary>
        private void ClearInputs()
        {
            txtBoxSumSalePrice.Text = string.Empty;
            txtBoxOptions.Text = string.Empty;
            txtBoxSubtotal.Text = string.Empty;
            txtBoxSalesTax.Text = string.Empty;
            txtBoxTotal.Text = string.Empty;
            txtBoxSumTradein.Text = string.Empty;
            txtBoxAmountDue.Text = string.Empty;
            txtBoxMonPayment.Text = string.Empty;
        }
        
        /// <summary>
        /// Sets the default values of the inputs.
        /// </summary>
        private void ClearControls()
        {
            chkBoxStereoSystem.Checked = false;
            chkBoxLeatherInterior.Checked = false;
            chkBoxCompNav.Checked = false;

            radBtnStandard.Checked = true;
            radBtnPearlized.Checked = false;
            radBtnCustomized.Checked = false;

            numNumYears.Value = 1;
            numInterestRate.Value = 5;

            cmbVehicle.SelectedIndex = -1;
            txtBoxTradeInValue.ResetText();
        }
        

        /// <summary>
        /// Resets the error inputs.
        /// </summary>
        private void ResetInputErrors()
        {
            vehicleCmbError.Clear();
            tradeInError.Clear();
        }
        #endregion
    }
}