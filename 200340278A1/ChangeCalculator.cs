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
        /// Operation subtract
        /// </summary>
        Subtract
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

            try
            {
                if(String.IsNullOrEmpty(totalInput.Text) || (String.IsNullOrEmpty(paidInput.Text)))
                {
                    MessageBox.Show("You need to enter some value in both total and paid");
                } else
                {
                    CalculateChange();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Blergh");
            }

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

            // parse the string into decimal
            if(decimal.TryParse(paidTextValue, NumberStyles.Currency, null, out decimal paidAmount))
            {
                paidTextValue = paidAmount.ToString("C");
            }
            // parse the string into decimal
            if (decimal.TryParse(totalTextValue, NumberStyles.Currency, null, out decimal totalAmount))
            {
                totalTextValue = totalAmount.ToString("C");
            }

            // create the change result
            result = paidAmount - totalAmount; // this would output the decimal of paid - total

            changeOutput.Text = result.ToString(); 
            // format the change to be currency
            changeOutput.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", result);  // this is what converts the decimal of change into 
            Console.WriteLine(result);

            populateCoins(result); // this will spread the coin values
        }

        /// <summary>
        /// method to dispense coins into largest denominations
        /// </summary>
        /// <param name="result"></param>
        private void populateCoins(decimal result)
        {
            double newResult = decimal.ToDouble(result); // convert the change into a double
            
            double newResultDollars = newResult * 100; // multiply by 100. example: 17.38 becomes 1738 ... this allows us to do the rounding below the int conversion

            int newDollarResult = Convert.ToInt32(newResultDollars); // convert to int


            // this checks the rounding. 4.98 became 498, mod 5 is 3 (and subsequently mod 10 is 8 anyways) so we add 2 to make it 500
            if(newDollarResult % 5 == 3 || newDollarResult % 10 == 8)
            {
                newDollarResult += 2;
            } else if (newDollarResult % 5 == 4 || newDollarResult % 10 == 9)
            {
                newDollarResult++;
            } else if (newDollarResult % 5 == 2 || newDollarResult % 10 == 2)
            {
                newDollarResult -= 2;
            } else if (newDollarResult % 5 == 1 || newDollarResult % 10 == 1)
            {
                newDollarResult--;
            } else
            {
                // do nothing
            }

            // convert back to decimal
            decimal dollarParsed = Convert.ToDecimal(newDollarResult);

            // divide by 100 to get the cent values back
            dollarParsed = dollarParsed / 100;

            // convert to double so that we can perform the the operations below
            double res = Convert.ToDouble(dollarParsed);
            
            double left = System.Math.Floor(res);
            double right = (res - left) * 100;
            int dollars = Convert.ToInt32(left); // split into dollar amount
            int cents = Convert.ToInt32(right); // split into cents amount

            // below is the arithmetics i came up with so that it spreads the coins
            int toonies = dollars / 2;
            int loonies = dollars % 2;

            int quarters = cents / 25;
            cents = cents % 25;

            int dimes = cents / 10;
            cents = cents % 10;

            int nickels = cents / 5;
            

            tooniesOutput.Text = toonies.ToString();
            looniesOutput.Text = loonies.ToString();
            quartersOutput.Text = quarters.ToString();
            dimesOutput.Text = dimes.ToString();
            nickelOutput.Text = nickels.ToString();
        }
        #endregion

        private void ChangeCalculator_Load(object sender, EventArgs e)
        {

        }
    }
}
