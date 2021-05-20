
namespace RRCAGTracySalak
{
    partial class SalesQuoteForm
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
            this.components = new System.ComponentModel.Container();
            this.grpAccessories = new System.Windows.Forms.GroupBox();
            this.chkBoxLeatherInterior = new System.Windows.Forms.CheckBox();
            this.chkBoxStereoSystem = new System.Windows.Forms.CheckBox();
            this.lblVehicleSalePrice = new System.Windows.Forms.Label();
            this.lblTradeinValue = new System.Windows.Forms.Label();
            this.txtBoxTradeInValue = new System.Windows.Forms.TextBox();
            this.chkBoxCompNav = new System.Windows.Forms.CheckBox();
            this.grpExteriorFinish = new System.Windows.Forms.GroupBox();
            this.radBtnCustomized = new System.Windows.Forms.RadioButton();
            this.radBtnPearlized = new System.Windows.Forms.RadioButton();
            this.radBtnStandard = new System.Windows.Forms.RadioButton();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.lblTradeInSum = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSalesTaxRate = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtBoxAmountDue = new System.Windows.Forms.TextBox();
            this.txtBoxSumTradein = new System.Windows.Forms.TextBox();
            this.txtBoxSalesTax = new System.Windows.Forms.TextBox();
            this.txtBoxTotal = new System.Windows.Forms.TextBox();
            this.txtBoxSubtotal = new System.Windows.Forms.TextBox();
            this.txtBoxOptions = new System.Windows.Forms.TextBox();
            this.lblOptions = new System.Windows.Forms.Label();
            this.txtBoxSumSalePrice = new System.Windows.Forms.TextBox();
            this.lblSumSalePrice = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpFinance = new System.Windows.Forms.GroupBox();
            this.lblMonPayment = new System.Windows.Forms.Label();
            this.lblAnnualInterestRate = new System.Windows.Forms.Label();
            this.lblNumYears = new System.Windows.Forms.Label();
            this.numInterestRate = new System.Windows.Forms.NumericUpDown();
            this.numNumYears = new System.Windows.Forms.NumericUpDown();
            this.txtBoxMonPayment = new System.Windows.Forms.TextBox();
            this.btnCalcQuote = new System.Windows.Forms.Button();
            this.tradeInError = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbVehicle = new System.Windows.Forms.ComboBox();
            this.vehicleCmbError = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpAccessories.SuspendLayout();
            this.grpExteriorFinish.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.grpFinance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterestRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeInError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleCmbError)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAccessories
            // 
            this.grpAccessories.Controls.Add(this.chkBoxLeatherInterior);
            this.grpAccessories.Controls.Add(this.chkBoxStereoSystem);
            this.grpAccessories.Location = new System.Drawing.Point(34, 141);
            this.grpAccessories.Margin = new System.Windows.Forms.Padding(4);
            this.grpAccessories.Name = "grpAccessories";
            this.grpAccessories.Padding = new System.Windows.Forms.Padding(4);
            this.grpAccessories.Size = new System.Drawing.Size(293, 165);
            this.grpAccessories.TabIndex = 2;
            this.grpAccessories.TabStop = false;
            this.grpAccessories.Text = "Accessories";
            // 
            // chkBoxLeatherInterior
            // 
            this.chkBoxLeatherInterior.AutoSize = true;
            this.chkBoxLeatherInterior.Location = new System.Drawing.Point(27, 75);
            this.chkBoxLeatherInterior.Margin = new System.Windows.Forms.Padding(4);
            this.chkBoxLeatherInterior.Name = "chkBoxLeatherInterior";
            this.chkBoxLeatherInterior.Size = new System.Drawing.Size(127, 21);
            this.chkBoxLeatherInterior.TabIndex = 1;
            this.chkBoxLeatherInterior.Text = "Leather Interior";
            this.chkBoxLeatherInterior.UseVisualStyleBackColor = true;
            this.chkBoxLeatherInterior.CheckedChanged += new System.EventHandler(this.chkBoxLeatherInterior_CheckedChanged);
            // 
            // chkBoxStereoSystem
            // 
            this.chkBoxStereoSystem.AutoSize = true;
            this.chkBoxStereoSystem.Location = new System.Drawing.Point(27, 34);
            this.chkBoxStereoSystem.Margin = new System.Windows.Forms.Padding(4);
            this.chkBoxStereoSystem.Name = "chkBoxStereoSystem";
            this.chkBoxStereoSystem.Size = new System.Drawing.Size(122, 21);
            this.chkBoxStereoSystem.TabIndex = 0;
            this.chkBoxStereoSystem.Text = "Stereo System";
            this.chkBoxStereoSystem.UseVisualStyleBackColor = true;
            this.chkBoxStereoSystem.CheckedChanged += new System.EventHandler(this.chkBoxStereoSystem_CheckedChanged);
            // 
            // lblVehicleSalePrice
            // 
            this.lblVehicleSalePrice.AutoSize = true;
            this.lblVehicleSalePrice.Location = new System.Drawing.Point(30, 57);
            this.lblVehicleSalePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehicleSalePrice.Name = "lblVehicleSalePrice";
            this.lblVehicleSalePrice.Size = new System.Drawing.Size(136, 17);
            this.lblVehicleSalePrice.TabIndex = 1;
            this.lblVehicleSalePrice.Text = "Vehicle\'s Sale Price:";
            // 
            // lblTradeinValue
            // 
            this.lblTradeinValue.AutoSize = true;
            this.lblTradeinValue.Location = new System.Drawing.Point(62, 97);
            this.lblTradeinValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTradeinValue.Name = "lblTradeinValue";
            this.lblTradeinValue.Size = new System.Drawing.Size(106, 17);
            this.lblTradeinValue.TabIndex = 7;
            this.lblTradeinValue.Text = "Trade-in Value:";
            // 
            // txtBoxTradeInValue
            // 
            this.txtBoxTradeInValue.Location = new System.Drawing.Point(176, 93);
            this.txtBoxTradeInValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxTradeInValue.Name = "txtBoxTradeInValue";
            this.txtBoxTradeInValue.Size = new System.Drawing.Size(151, 22);
            this.txtBoxTradeInValue.TabIndex = 1;
            this.txtBoxTradeInValue.Text = "0";
            this.txtBoxTradeInValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBoxTradeInValue.TextChanged += new System.EventHandler(this.txtBoxTradeInValue_TextChanged);
            // 
            // chkBoxCompNav
            // 
            this.chkBoxCompNav.AutoSize = true;
            this.chkBoxCompNav.Location = new System.Drawing.Point(61, 259);
            this.chkBoxCompNav.Margin = new System.Windows.Forms.Padding(4);
            this.chkBoxCompNav.Name = "chkBoxCompNav";
            this.chkBoxCompNav.Size = new System.Drawing.Size(162, 21);
            this.chkBoxCompNav.TabIndex = 3;
            this.chkBoxCompNav.Text = "Computer Navigation";
            this.chkBoxCompNav.UseVisualStyleBackColor = true;
            this.chkBoxCompNav.CheckedChanged += new System.EventHandler(this.chkBoxCompNav_CheckedChanged);
            // 
            // grpExteriorFinish
            // 
            this.grpExteriorFinish.Controls.Add(this.radBtnCustomized);
            this.grpExteriorFinish.Controls.Add(this.radBtnPearlized);
            this.grpExteriorFinish.Controls.Add(this.radBtnStandard);
            this.grpExteriorFinish.Location = new System.Drawing.Point(34, 337);
            this.grpExteriorFinish.Margin = new System.Windows.Forms.Padding(4);
            this.grpExteriorFinish.Name = "grpExteriorFinish";
            this.grpExteriorFinish.Padding = new System.Windows.Forms.Padding(4);
            this.grpExteriorFinish.Size = new System.Drawing.Size(293, 172);
            this.grpExteriorFinish.TabIndex = 4;
            this.grpExteriorFinish.TabStop = false;
            this.grpExteriorFinish.Text = "Exterior Finish";
            // 
            // radBtnCustomized
            // 
            this.radBtnCustomized.AutoSize = true;
            this.radBtnCustomized.Location = new System.Drawing.Point(27, 117);
            this.radBtnCustomized.Margin = new System.Windows.Forms.Padding(4);
            this.radBtnCustomized.Name = "radBtnCustomized";
            this.radBtnCustomized.Size = new System.Drawing.Size(161, 21);
            this.radBtnCustomized.TabIndex = 2;
            this.radBtnCustomized.Text = "Customized Detailing";
            this.radBtnCustomized.UseVisualStyleBackColor = true;
            this.radBtnCustomized.CheckedChanged += new System.EventHandler(this.radBtnCustomized_CheckedChanged);
            // 
            // radBtnPearlized
            // 
            this.radBtnPearlized.AutoSize = true;
            this.radBtnPearlized.Location = new System.Drawing.Point(27, 76);
            this.radBtnPearlized.Margin = new System.Windows.Forms.Padding(4);
            this.radBtnPearlized.Name = "radBtnPearlized";
            this.radBtnPearlized.Size = new System.Drawing.Size(88, 21);
            this.radBtnPearlized.TabIndex = 1;
            this.radBtnPearlized.Text = "Pearlized";
            this.radBtnPearlized.UseVisualStyleBackColor = true;
            this.radBtnPearlized.CheckedChanged += new System.EventHandler(this.radBtnPearlized_CheckedChanged);
            // 
            // radBtnStandard
            // 
            this.radBtnStandard.AutoSize = true;
            this.radBtnStandard.Checked = true;
            this.radBtnStandard.Location = new System.Drawing.Point(27, 34);
            this.radBtnStandard.Margin = new System.Windows.Forms.Padding(4);
            this.radBtnStandard.Name = "radBtnStandard";
            this.radBtnStandard.Size = new System.Drawing.Size(87, 21);
            this.radBtnStandard.TabIndex = 0;
            this.radBtnStandard.TabStop = true;
            this.radBtnStandard.Text = "Standard";
            this.radBtnStandard.UseVisualStyleBackColor = true;
            this.radBtnStandard.CheckedChanged += new System.EventHandler(this.radBtnStandard_CheckedChanged);
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.lblAmountDue);
            this.grpSummary.Controls.Add(this.lblTradeInSum);
            this.grpSummary.Controls.Add(this.lblTotal);
            this.grpSummary.Controls.Add(this.lblSalesTaxRate);
            this.grpSummary.Controls.Add(this.lblSubtotal);
            this.grpSummary.Controls.Add(this.txtBoxAmountDue);
            this.grpSummary.Controls.Add(this.txtBoxSumTradein);
            this.grpSummary.Controls.Add(this.txtBoxSalesTax);
            this.grpSummary.Controls.Add(this.txtBoxTotal);
            this.grpSummary.Controls.Add(this.txtBoxSubtotal);
            this.grpSummary.Controls.Add(this.txtBoxOptions);
            this.grpSummary.Controls.Add(this.lblOptions);
            this.grpSummary.Controls.Add(this.txtBoxSumSalePrice);
            this.grpSummary.Controls.Add(this.lblSumSalePrice);
            this.grpSummary.Location = new System.Drawing.Point(382, 44);
            this.grpSummary.Margin = new System.Windows.Forms.Padding(4);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Padding = new System.Windows.Forms.Padding(4);
            this.grpSummary.Size = new System.Drawing.Size(391, 334);
            this.grpSummary.TabIndex = 9;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary";
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Location = new System.Drawing.Point(93, 279);
            this.lblAmountDue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(90, 17);
            this.lblAmountDue.TabIndex = 23;
            this.lblAmountDue.Text = "Amount Due:";
            this.lblAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTradeInSum
            // 
            this.lblTradeInSum.AutoSize = true;
            this.lblTradeInSum.Location = new System.Drawing.Point(120, 240);
            this.lblTradeInSum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTradeInSum.Name = "lblTradeInSum";
            this.lblTradeInSum.Size = new System.Drawing.Size(66, 17);
            this.lblTradeInSum.TabIndex = 22;
            this.lblTradeInSum.Text = "Trade-in:";
            this.lblTradeInSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(140, 199);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 17);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Total:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSalesTaxRate
            // 
            this.lblSalesTaxRate.AutoSize = true;
            this.lblSalesTaxRate.Location = new System.Drawing.Point(71, 159);
            this.lblSalesTaxRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalesTaxRate.Name = "lblSalesTaxRate";
            this.lblSalesTaxRate.Size = new System.Drawing.Size(116, 17);
            this.lblSalesTaxRate.TabIndex = 20;
            this.lblSalesTaxRate.Text = "Sales Tax (12%):";
            this.lblSalesTaxRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(120, 116);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(64, 17);
            this.lblSubtotal.TabIndex = 19;
            this.lblSubtotal.Text = "Subtotal:";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBoxAmountDue
            // 
            this.txtBoxAmountDue.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtBoxAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxAmountDue.Location = new System.Drawing.Point(193, 276);
            this.txtBoxAmountDue.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxAmountDue.Name = "txtBoxAmountDue";
            this.txtBoxAmountDue.ReadOnly = true;
            this.txtBoxAmountDue.Size = new System.Drawing.Size(151, 22);
            this.txtBoxAmountDue.TabIndex = 18;
            this.txtBoxAmountDue.TabStop = false;
            // 
            // txtBoxSumTradein
            // 
            this.txtBoxSumTradein.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSumTradein.Location = new System.Drawing.Point(193, 236);
            this.txtBoxSumTradein.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSumTradein.Name = "txtBoxSumTradein";
            this.txtBoxSumTradein.ReadOnly = true;
            this.txtBoxSumTradein.Size = new System.Drawing.Size(151, 22);
            this.txtBoxSumTradein.TabIndex = 17;
            this.txtBoxSumTradein.TabStop = false;
            // 
            // txtBoxSalesTax
            // 
            this.txtBoxSalesTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSalesTax.Location = new System.Drawing.Point(193, 155);
            this.txtBoxSalesTax.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSalesTax.Name = "txtBoxSalesTax";
            this.txtBoxSalesTax.ReadOnly = true;
            this.txtBoxSalesTax.Size = new System.Drawing.Size(151, 22);
            this.txtBoxSalesTax.TabIndex = 16;
            this.txtBoxSalesTax.TabStop = false;
            // 
            // txtBoxTotal
            // 
            this.txtBoxTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxTotal.Location = new System.Drawing.Point(193, 196);
            this.txtBoxTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxTotal.Name = "txtBoxTotal";
            this.txtBoxTotal.ReadOnly = true;
            this.txtBoxTotal.Size = new System.Drawing.Size(151, 22);
            this.txtBoxTotal.TabIndex = 15;
            this.txtBoxTotal.TabStop = false;
            // 
            // txtBoxSubtotal
            // 
            this.txtBoxSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSubtotal.Location = new System.Drawing.Point(193, 112);
            this.txtBoxSubtotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSubtotal.Name = "txtBoxSubtotal";
            this.txtBoxSubtotal.ReadOnly = true;
            this.txtBoxSubtotal.Size = new System.Drawing.Size(151, 22);
            this.txtBoxSubtotal.TabIndex = 14;
            this.txtBoxSubtotal.TabStop = false;
            // 
            // txtBoxOptions
            // 
            this.txtBoxOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxOptions.Location = new System.Drawing.Point(193, 70);
            this.txtBoxOptions.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxOptions.Name = "txtBoxOptions";
            this.txtBoxOptions.ReadOnly = true;
            this.txtBoxOptions.Size = new System.Drawing.Size(151, 22);
            this.txtBoxOptions.TabIndex = 13;
            this.txtBoxOptions.TabStop = false;
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Location = new System.Drawing.Point(124, 74);
            this.lblOptions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(61, 17);
            this.lblOptions.TabIndex = 12;
            this.lblOptions.Text = "Options:";
            this.lblOptions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBoxSumSalePrice
            // 
            this.txtBoxSumSalePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSumSalePrice.Location = new System.Drawing.Point(193, 28);
            this.txtBoxSumSalePrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSumSalePrice.Name = "txtBoxSumSalePrice";
            this.txtBoxSumSalePrice.ReadOnly = true;
            this.txtBoxSumSalePrice.Size = new System.Drawing.Size(151, 22);
            this.txtBoxSumSalePrice.TabIndex = 11;
            this.txtBoxSumSalePrice.TabStop = false;
            // 
            // lblSumSalePrice
            // 
            this.lblSumSalePrice.AutoSize = true;
            this.lblSumSalePrice.Location = new System.Drawing.Point(48, 32);
            this.lblSumSalePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSumSalePrice.Name = "lblSumSalePrice";
            this.lblSumSalePrice.Size = new System.Drawing.Size(136, 17);
            this.lblSumSalePrice.TabIndex = 11;
            this.lblSumSalePrice.Text = "Vehicle\'s Sale Price:";
            this.lblSumSalePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(34, 532);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(117, 42);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grpFinance
            // 
            this.grpFinance.Controls.Add(this.lblMonPayment);
            this.grpFinance.Controls.Add(this.lblAnnualInterestRate);
            this.grpFinance.Controls.Add(this.lblNumYears);
            this.grpFinance.Controls.Add(this.numInterestRate);
            this.grpFinance.Controls.Add(this.numNumYears);
            this.grpFinance.Controls.Add(this.txtBoxMonPayment);
            this.grpFinance.Location = new System.Drawing.Point(382, 385);
            this.grpFinance.Margin = new System.Windows.Forms.Padding(4);
            this.grpFinance.Name = "grpFinance";
            this.grpFinance.Padding = new System.Windows.Forms.Padding(4);
            this.grpFinance.Size = new System.Drawing.Size(391, 124);
            this.grpFinance.TabIndex = 5;
            this.grpFinance.TabStop = false;
            this.grpFinance.Text = "Finance";
            // 
            // lblMonPayment
            // 
            this.lblMonPayment.AutoSize = true;
            this.lblMonPayment.Location = new System.Drawing.Point(244, 38);
            this.lblMonPayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonPayment.Name = "lblMonPayment";
            this.lblMonPayment.Size = new System.Drawing.Size(116, 17);
            this.lblMonPayment.TabIndex = 29;
            this.lblMonPayment.Text = "Monthly Payment";
            this.lblMonPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAnnualInterestRate
            // 
            this.lblAnnualInterestRate.Location = new System.Drawing.Point(140, 23);
            this.lblAnnualInterestRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnnualInterestRate.Name = "lblAnnualInterestRate";
            this.lblAnnualInterestRate.Size = new System.Drawing.Size(96, 38);
            this.lblAnnualInterestRate.TabIndex = 28;
            this.lblAnnualInterestRate.Text = "Annual Interest Rate";
            // 
            // lblNumYears
            // 
            this.lblNumYears.AutoSize = true;
            this.lblNumYears.Location = new System.Drawing.Point(21, 38);
            this.lblNumYears.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumYears.Name = "lblNumYears";
            this.lblNumYears.Size = new System.Drawing.Size(87, 17);
            this.lblNumYears.TabIndex = 27;
            this.lblNumYears.Text = "No. of Years";
            // 
            // numInterestRate
            // 
            this.numInterestRate.DecimalPlaces = 2;
            this.numInterestRate.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numInterestRate.Location = new System.Drawing.Point(144, 70);
            this.numInterestRate.Margin = new System.Windows.Forms.Padding(4);
            this.numInterestRate.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numInterestRate.Name = "numInterestRate";
            this.numInterestRate.Size = new System.Drawing.Size(81, 22);
            this.numInterestRate.TabIndex = 1;
            this.numInterestRate.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numInterestRate.ValueChanged += new System.EventHandler(this.numInterestRate_ValueChanged);
            // 
            // numNumYears
            // 
            this.numNumYears.Location = new System.Drawing.Point(25, 70);
            this.numNumYears.Margin = new System.Windows.Forms.Padding(4);
            this.numNumYears.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numNumYears.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNumYears.Name = "numNumYears";
            this.numNumYears.Size = new System.Drawing.Size(84, 22);
            this.numNumYears.TabIndex = 0;
            this.numNumYears.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNumYears.ValueChanged += new System.EventHandler(this.numNumYears_ValueChanged);
            // 
            // txtBoxMonPayment
            // 
            this.txtBoxMonPayment.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtBoxMonPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxMonPayment.Location = new System.Drawing.Point(247, 70);
            this.txtBoxMonPayment.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxMonPayment.Name = "txtBoxMonPayment";
            this.txtBoxMonPayment.ReadOnly = true;
            this.txtBoxMonPayment.Size = new System.Drawing.Size(117, 22);
            this.txtBoxMonPayment.TabIndex = 24;
            this.txtBoxMonPayment.TabStop = false;
            // 
            // btnCalcQuote
            // 
            this.btnCalcQuote.Location = new System.Drawing.Point(649, 532);
            this.btnCalcQuote.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcQuote.Name = "btnCalcQuote";
            this.btnCalcQuote.Size = new System.Drawing.Size(124, 42);
            this.btnCalcQuote.TabIndex = 6;
            this.btnCalcQuote.Text = "Calculate Quote";
            this.btnCalcQuote.UseVisualStyleBackColor = true;
            this.btnCalcQuote.Click += new System.EventHandler(this.btnCalcQuote_Click);
            // 
            // tradeInError
            // 
            this.tradeInError.ContainerControl = this;
            // 
            // cmbVehicle
            // 
            this.cmbVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehicle.FormattingEnabled = true;
            this.cmbVehicle.Location = new System.Drawing.Point(176, 54);
            this.cmbVehicle.Name = "cmbVehicle";
            this.cmbVehicle.Size = new System.Drawing.Size(151, 24);
            this.cmbVehicle.TabIndex = 10;
            // 
            // vehicleCmbError
            // 
            this.vehicleCmbError.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(819, 30);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.closeToolStripMenuItem.Text = "&Close";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehicleInformationToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // vehicleInformationToolStripMenuItem
            // 
            this.vehicleInformationToolStripMenuItem.Enabled = false;
            this.vehicleInformationToolStripMenuItem.Name = "vehicleInformationToolStripMenuItem";
            this.vehicleInformationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.vehicleInformationToolStripMenuItem.Size = new System.Drawing.Size(307, 26);
            this.vehicleInformationToolStripMenuItem.Text = "Vehicle &Information";
            // 
            // SalesQuoteForm
            // 
            this.AcceptButton = this.btnCalcQuote;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 608);
            this.Controls.Add(this.cmbVehicle);
            this.Controls.Add(this.btnCalcQuote);
            this.Controls.Add(this.grpFinance);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.grpExteriorFinish);
            this.Controls.Add(this.chkBoxCompNav);
            this.Controls.Add(this.txtBoxTradeInValue);
            this.Controls.Add(this.lblTradeinValue);
            this.Controls.Add(this.lblVehicleSalePrice);
            this.Controls.Add(this.grpAccessories);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SalesQuoteForm";
            this.Text = "Vehicle Sales Quote";
            this.grpAccessories.ResumeLayout(false);
            this.grpAccessories.PerformLayout();
            this.grpExteriorFinish.ResumeLayout(false);
            this.grpExteriorFinish.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.grpFinance.ResumeLayout(false);
            this.grpFinance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterestRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeInError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleCmbError)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAccessories;
        private System.Windows.Forms.Label lblVehicleSalePrice;
        private System.Windows.Forms.Label lblTradeinValue;
        private System.Windows.Forms.TextBox txtBoxTradeInValue;
        private System.Windows.Forms.CheckBox chkBoxLeatherInterior;
        private System.Windows.Forms.CheckBox chkBoxStereoSystem;
        private System.Windows.Forms.CheckBox chkBoxCompNav;
        private System.Windows.Forms.GroupBox grpExteriorFinish;
        private System.Windows.Forms.RadioButton radBtnCustomized;
        private System.Windows.Forms.RadioButton radBtnPearlized;
        private System.Windows.Forms.RadioButton radBtnStandard;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Label lblTradeInSum;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSalesTaxRate;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtBoxAmountDue;
        private System.Windows.Forms.TextBox txtBoxSumTradein;
        private System.Windows.Forms.TextBox txtBoxSalesTax;
        private System.Windows.Forms.TextBox txtBoxTotal;
        private System.Windows.Forms.TextBox txtBoxSubtotal;
        private System.Windows.Forms.TextBox txtBoxOptions;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.TextBox txtBoxSumSalePrice;
        private System.Windows.Forms.Label lblSumSalePrice;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grpFinance;
        private System.Windows.Forms.Label lblMonPayment;
        private System.Windows.Forms.Label lblAnnualInterestRate;
        private System.Windows.Forms.Label lblNumYears;
        private System.Windows.Forms.NumericUpDown numInterestRate;
        private System.Windows.Forms.NumericUpDown numNumYears;
        private System.Windows.Forms.TextBox txtBoxMonPayment;
        private System.Windows.Forms.Button btnCalcQuote;
        private System.Windows.Forms.ErrorProvider tradeInError;
        private System.Windows.Forms.ComboBox cmbVehicle;
        private System.Windows.Forms.ErrorProvider vehicleCmbError;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleInformationToolStripMenuItem;
    }
}