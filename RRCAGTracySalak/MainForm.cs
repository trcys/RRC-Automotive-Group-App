/*
 * Name: Tracy Salak
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2021-03-22
 * Updated: 2021-04-12
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

namespace RRCAGTracySalak
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initializes an instance of the MainForm class with the design and events.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            this.mnuFileExit.Click += MnuFileExit_Click;
            this.mnuHelpAbout.Click += MnuHelpAbout_Click;
            this.mnuOpenSalesQuote.Click += MnuOpenSalesQuote_Click;
            this.mnuDataVehicle.Click += MnuDataVehicle_Click;
            this.mnuOpenCarWash.Click += MnuOpenCarWash_Click;
        }

        /// <summary>
        /// Handles the click event of car wash menu item.
        /// </summary>
        private void MnuOpenCarWash_Click(object sender, EventArgs e)
        {
            CarWashForm carWashForm = new CarWashForm();
            carWashForm.Show();
        }

        /// <summary>
        /// Handles the click event of the data vehicle menu item.
        /// </summary>
        private void MnuDataVehicle_Click(object sender, EventArgs e)
        {
            VehicleDataForm vehicleDataForm = new VehicleDataForm();
            vehicleDataForm.Show();
        }

        /// <summary>
        /// Handles the click event of the sales quote menu item.
        /// </summary>
        private void MnuOpenSalesQuote_Click(object sender, EventArgs e)
        {
            SalesQuoteForm salesQuoteForm = new SalesQuoteForm();
            salesQuoteForm.ShowDialog();
        }

        /// <summary>
        /// Handles the click event of the about menu item.
        /// </summary>
        private void MnuHelpAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Handles the click event of the exit menu item.
        /// </summary>
        private void MnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
