using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automotive
{
    public partial class frm_Automotive : Form
    {

        // 9.24.2018 - Justin Freres
        // CIS266 - Automotive Form
        /* Additional Requirements
         
            1. Add Back Color to group boxes and buttons
            2. No Field Variables - use local variables and pass the data
            3. Use Boolian Validation Method to test to make sure values are
               entered for the parts and labor ( pass by ref or by out)
            4. Add Display Method and pass data to it for display in 
               the Summary Group Box.
            5. User must provide a value for parts and labor even if value is zero.
            6. Use Named Arguments for the OtherCharges Method (passing parts and labor).
            7. Make taxes a constant and pass it to teh Tax Charges Method.
            8. Use Named Argumemts for the Total Charges Method.

            *Parts and Labor validation must not be blank or a negative entry.
            *Validation are in seperate methods from the click methods.
        */

        #region constant variables

        // constant tax rate
        private const decimal TAX_RATE = 0.06m;
        // constant service rates
        private const decimal OIL_CHARGE = 26m;
        private const decimal LUBE_CHARGE = 18m;
        private const decimal RADIATORFLUSH_CHARGE = 30m;
        private const decimal TRANSMISSIONFLUSH_CHARGE = 80m;
        private const decimal INSPECTION_CHARGE = 15m;
        private const decimal REPLACEMUFFLER_CHARGE = 100m;
        private const decimal TIREROTATION_CHARGE = 20m;

        #endregion  

        #region Form Init and Load Event
        /// <summary>
        /// Init Form
        /// </summary>
        public frm_Automotive()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form Load Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_Automotive_Load(object sender, EventArgs e)
        {
            // declare variables
            string inputError, parts, labor;

            // assign field variables to local variables
            parts = this.txtBox_partsInput.Text;
            labor = this.txtBox_laborInput.Text;

            // on form load force validation of parts and labor
            if(!ValidPartsAndLabor(parts, labor, out inputError)) { }
        }
      
        #endregion

        #region return Methods
        /// <summary>
        /// Calculate Total Oil and Lube Charges
        /// </summary>
        /// <returns>Total Oil and Lube Charges</returns>
        private decimal OilLubeCharges()
        {
            decimal total = 0;

            if (this.chkBox_oilChange.Checked)
                total += OIL_CHARGE;

            if (this.chkBox_lubeJob.Checked)
                total += LUBE_CHARGE;
            
            return total;
        }

        /// <summary>
        /// Calculate Total Flush Charges
        /// </summary>
        /// <returns>Total Flush Charges</returns>
        private decimal FlushCharges()
        {
            decimal total = 0;

            if (this.chkBox_radiatorFlush.Checked)
                total += RADIATORFLUSH_CHARGE;

            if (this.chkBox_transmissionFlush.Checked)
                total += TRANSMISSIONFLUSH_CHARGE;

            return total;
        }

        /// <summary>
        /// Calculate Total Misc Charges
        /// </summary>
        /// <returns>Total Misc Charges</returns>
        private decimal MiscCharges()
        {
            decimal total = 0;

            if (this.chkBox_inspection.Checked)
                total += INSPECTION_CHARGE;

            if (this.chkBox_replaceMuffler.Checked)
                total += REPLACEMUFFLER_CHARGE;

            if (this.chkBox_tireRotation.Checked)
                total += TIREROTATION_CHARGE;

            return total;
        }

        /// <summary>
        /// Calculates Total Other Charges
        /// </summary>
        /// <param name="parts">Parts Total</param>
        /// <param name="labor">Labor Total</param>
        private void OtherCharges(string parts, string labor)
        {
            decimal partsTotal = 0;
            decimal.TryParse(parts, out partsTotal);

            decimal laborTotal = 0;
            decimal.TryParse(labor, out laborTotal); 
         
        }
        

        /// <summary>
        /// Calucates Total Tax Charges
        /// </summary>
        /// <param name="parts">Parts Total</param>
        /// <returns>Total Taxes</returns>
        private decimal TaxCharges(string parts)
        {
            // variables parts
            decimal  partsTotal = decimal.Parse(this.txtBox_partsInput.Text), partsTotalTax = 0m;

            decimal.TryParse(parts, out partsTotal);
            if (partsTotal > 0)
                partsTotalTax += partsTotal * TAX_RATE;

            return partsTotalTax;
        }
   
        /// <summary>
        /// Display Calculation Summary
        /// </summary>
        /// <param name="serviceLabor">Services and Labor Totals</param>
        /// <param name="parts">Parts Total</param>
        /// <param name="tax">Tax Total</param>
        /// <param name="totalFees">Total Fees</param>
        private void DisplaySummary(decimal serviceLabor, decimal parts, decimal tax, decimal totalFees)
        {
            // assign summary output
            this.lbl_serviceLaborSummaryOut.Text = serviceLabor.ToString();
            this.lbl_partsSummaryOut.Text = parts.ToString();
            this.lbl_taxSummaryOut.Text = tax.ToString();
            this.lbl_totalFeesSummaryOut.Text = totalFees.ToString();
        }

        #endregion

        #region void Methods

        /// <summary>
        /// Clear Oil and Lube Checkboxes
        /// </summary>
        private void ClearOilLube()
        {
            this.chkBox_oilChange.Checked = false;
            this.chkBox_lubeJob.Checked = false;
        }

        /// <summary>
        /// Clears Flush Checkboxes
        /// </summary>
        private void ClearFlushes()
        {
            this.chkBox_radiatorFlush.Checked = false;
            this.chkBox_transmissionFlush.Checked = false;
        }

        /// <summary>
        /// Clears Misc Checkboxes
        /// </summary>
        private void ClearMisc()
        {
            this.chkBox_inspection.Checked = false;
            this.chkBox_replaceMuffler.Checked = false;
            this.chkBox_tireRotation.Checked = false;
        }

        /// <summary>
        /// Clears Parts and Labor Input
        /// </summary>
        private void ClearOther()
        {
            this.txtBox_partsInput.Text = "";
            this.txtBox_laborInput.Text = "";
        }

        /// <summary>
        /// Clears Summary Labels
        /// </summary>
        private void ClearFees()
        {
            this.lbl_serviceLaborSummaryOut.Text = "";
            this.lbl_partsSummaryOut.Text = "";
            this.lbl_taxSummaryOut.Text = "";
            this.lbl_totalFeesSummaryOut.Text = "";
        }

        #endregion

        #region button Click Events

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();

            // enable parts and labor validation
            string inputError, parts = this.txtBox_partsInput.Text, labor = this.txtBox_laborInput.Text;
            if (!ValidPartsAndLabor(parts, labor, out inputError))
            {

            }
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            // variables for totalfee, parts and labor, and selected services
            decimal totalFee = 0m, oilLubTotal = 0m, flushTotal = 0m, miscTotal = 0m, otherTotal = 0m, partsTotal = 0m, totalLabor = 0m, taxTotal = 0m;

            TotalCharges(ref oilLubTotal, ref flushTotal, ref miscTotal, ref otherTotal, ref partsTotal, ref totalLabor, ref taxTotal, ref totalFee);

            DisplaySummary(otherTotal, partsTotal, taxTotal, totalFee);
        }

        private void TotalCharges(ref decimal oilLubTotal, ref decimal flushTotal, ref decimal miscTotal, ref decimal otherTotal, ref decimal partsTotal, ref decimal laborTotal, ref decimal taxTotal, ref decimal totalFee)
        {
            oilLubTotal = OilLubeCharges();
            flushTotal = FlushCharges();
            miscTotal = MiscCharges();
            OtherCharges(parts: this.txtBox_partsInput.Text, labor: this.txtBox_laborInput.Text);
            partsTotal = decimal.Parse(txtBox_partsInput.Text);
            taxTotal = TaxCharges(parts: this.txtBox_partsInput.Text);
            laborTotal = decimal.Parse(txtBox_laborInput.Text);
            otherTotal += oilLubTotal + flushTotal + miscTotal + laborTotal;
            totalFee += otherTotal + partsTotal + taxTotal;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            // close form
            this.Close();            
        }


        #endregion

        #region Validation Method and Events

        /// <summary>
        /// Validation parts and labor.
        /// </summary>
        /// <param name="parts">parts requires a positive number or zero.</param>
        /// <param name="labor">labor requires a positive number or zero.</param>
        /// <param name="errorInput">output error message</param>
        /// <returns></returns>
        public bool ValidPartsAndLabor(string parts, string labor, out string errorInput)
        {
            decimal partResult;
            bool validParts, validLabor;
            validParts = decimal.TryParse(parts, out partResult);
            if (!validParts || partResult < 0)
            {
                errorInput = "Invalid Parts Entry!";
                this.partsValidationProvider.SetError(this.txtBox_partsInput, errorInput);
                this.lbl_isPartsLaborValidTip.Show("Parts must be 0 or greater!", this.txtBox_partsInput, 5000);
                this.btn_Calculate.Enabled = false;            
                return false;
            }


            decimal laborResult;
            validLabor = decimal.TryParse(labor, out laborResult);
            if (!validLabor || laborResult < 0)
            {
                errorInput = "Invalid Labor Entry!";
                this.partsValidationProvider.SetError(this.txtBox_laborInput, errorInput);
                this.lbl_isPartsLaborValidTip.Show("Labor must be 0 or greater!", this.txtBox_laborInput, 5000);
                this.btn_Calculate.Enabled = false;            
                return false;
            }


            // if here validation success.
            errorInput = "";
            this.btn_Calculate.Enabled = true;          
            return true;
        }    

        private void txtBox_partsInput_Validating(object sender, CancelEventArgs e)
        {
            // enable parts and labor validation
            string inputError, parts = this.txtBox_partsInput.Text, labor = this.txtBox_laborInput.Text;
            if (!ValidPartsAndLabor(parts, labor, out inputError))
            {

            }
        } 
     
        private void txtBox_laborInput_Validating(object sender, CancelEventArgs e)
        {
            // enable parts and labor validation
            string inputError, parts = this.txtBox_partsInput.Text, labor = this.txtBox_laborInput.Text;
            if (!ValidPartsAndLabor(parts, labor, out inputError))
            {

            }
        }      
     
        private void txtBox_laborInput_Validated(object sender, EventArgs e)
        {
            this.laborValidationProvider.Clear();
        }

        private void txtBox_partsInput_Validated(object sender, EventArgs e)
        {
            this.partsValidationProvider.Clear();
        }               

        private void txtBox_partsInput_TextChanged(object sender, EventArgs e)
        {
            // enable parts and labor validation
            string inputError, parts = this.txtBox_partsInput.Text, labor = this.txtBox_laborInput.Text;
            if (!ValidPartsAndLabor(parts, labor, out inputError))
            {

            }
        }

        private void txtBox_laborInput_TextChanged(object sender, EventArgs e)
        {
            // enable parts and labor validation
            string inputError, parts = this.txtBox_partsInput.Text, labor = this.txtBox_laborInput.Text;
            if (!ValidPartsAndLabor(parts, labor, out inputError))
            {

            }
        }
        #endregion

    }
}
