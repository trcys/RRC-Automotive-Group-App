/*
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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RRCAG.Data;

namespace RRCAGTracySalak
{
    public partial class VehicleInformationForm : Form
    {
        BindingSource bindingSourceInvoice;
        public VehicleInformationForm()
        {
            InitializeComponent();
            this.Load += VehicleInformationForm_Load;
            btnClose.Click += BtnClose_Click;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VehicleInformationForm_Load(object sender, EventArgs e)
        {
            Vehicle vehicleInformation = SalesQuoteForm.vehicleInfo;
            bindingSourceInvoice = new BindingSource();
            bindingSourceInvoice.DataSource = vehicleInformation;
            lblOutStockID.DataBindings.Add(new Binding("Text", vehicleInformation, "StockID"));
            lblOutYear.DataBindings.Add(new Binding("Text", vehicleInformation, "ManufacturedYear"));
            lblOutManufacturer.DataBindings.Add(new Binding("Text", vehicleInformation, "Manufacturer"));
            lblOutModel.DataBindings.Add(new Binding("Text", vehicleInformation, "Model"));
            lblOutMileage.DataBindings.Add(new Binding("Text", vehicleInformation, "Mileage", true, DataSourceUpdateMode.Never, null, "N0"));
            lblOutTransmission.DataBindings.Add(new Binding("Text", vehicleInformation, "IsAutomatic"));
            lblOutColour.DataBindings.Add(new Binding("Text", vehicleInformation, "Colour"));
            lblOutBasePrice.DataBindings.Add(new Binding("Text", vehicleInformation, "BasePrice", true, DataSourceUpdateMode.Never, null, "C"));

            if (vehicleInformation.IsAutomatic)
            {
                lblOutTransmission.Text = "Automatic";
            }
            else
            {
                lblOutTransmission.Text = "Manual";
            }

            this.Text = (vehicleInformation.StockID + " - " + vehicleInformation.ManufacturedYear + " - " + vehicleInformation.ManufacturedYear + " - " + vehicleInformation.Model);
        }

    }
}
