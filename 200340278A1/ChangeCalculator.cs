using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeCalculator
{


    public enum operation
    {
        /// <summary>
        /// Operation Types
        /// </summary>
        Subtract,
        Split
    }

    /// <summary>
    /// A Change Calculator
    /// </summary>
    public partial class ChangeCalculator : Form
    {
        public operation Operation;

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>

        public ChangeCalculator()
        {
            InitializeComponent();
        }

        #endregion

        #region Button Methods
        private void calcBtn_Click(object sender, EventArgs e)
        {
            CalculateChange();
        }

        /// <summary>
        /// Clears the input and outputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearBtn_Click(object sender, EventArgs e)
        {   
            // clears input and outputs
            this.totalInput.Text = string.Empty;
            this.paidInput.Text = string.Empty;
            this.changeOutput.Text = string.Empty;
            this.tooniesOutput.Text = string.Empty;
            this.looniesOutput.Text = string.Empty;
            this.quartersOutput.Text = string.Empty;
            this.dimesOutput.Text = string.Empty;
            this.nickelOutput.Text = string.Empty;
        }
        #endregion

        #region Inputs
        private void totalInput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void paidInput_TextChanged(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region Labels
        private void total_Click(object sender, EventArgs e)
        {

        }

        private void paid_Click(object sender, EventArgs e)
        {

        }

        private void change_Click(object sender, EventArgs e)
        {

        }

        private void toonies_Click(object sender, EventArgs e)
        {

        }

        private void loonies_Click(object sender, EventArgs e)
        {

        }

        private void quarters_Click(object sender, EventArgs e)
        {

        }

        private void dimes_Click(object sender, EventArgs e)
        {

        }

        private void nickels_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Outputs
        private void changeOutput_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void tooniesOutput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void looniesOutput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void quartersOutput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dimesOutput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void nickelOutput_TextChanged(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region Other Methods
        /// <summary>
        /// Calculates the total and paid amount to dispense change
        /// </summary>
        private void CalculateChange()
        {
            PerformOperation(operation.Subtract);
        }

        /// <summary>
        /// operation types
        /// </summary>
        /// <param name="op"></param>
        private void PerformOperation(operation op)
        {
            switch(Operation)
            {
                case operation.Subtract:
                    paidParse();
                    break;
                case operation.Split:
                    break;
            }
        }

        
        /// <summary>
        /// This will parse the two inputs of string into decimal, and then format the operationg to be in currency.
        /// </summary>
        private void paidParse()
        {
            decimal result;
            CultureInfo culture;
            string paidTextValue = paidInput.Text;
            string totalTextValue = totalInput.Text;
            culture = CultureInfo.CreateSpecificCulture("en-US");
            if(decimal.TryParse(paidTextValue, NumberStyles.Currency, null, out decimal paidAmount))
            {
                paidTextValue = paidAmount.ToString("C");
            }

            if (decimal.TryParse(totalTextValue, NumberStyles.Currency, null, out decimal totalAmount))
            {
                totalTextValue = totalAmount.ToString("C");
            }

            result = paidAmount - totalAmount; // this would output the decimal of paid - total

            changeOutput.Text = result.ToString(); 

            changeOutput.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", result);  // this is what converts the decimal of change into 
            Console.WriteLine(result);

            populateCoins(result);
        }

        private void populateCoins(decimal change)
        {
            
        }
        #endregion

        private void ChangeCalculator_Load(object sender, EventArgs e)
        {

        }
    }
}
