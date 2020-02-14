using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeCalculator
{

    /// <summary>
    /// A Change Calculator
    /// </summary>
    public partial class ChangeCalculator : Form
    {
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
            // if the total input is empty, show a message box indicating to enter a total amount
            if (this.totalInput.Text.Length < this.totalInput.SelectionStart + 1)
                MessageBox.Show("Please enter a positive number for your total amount");

            CalculateChange();
        }

        /// <summary>
        /// Calculates the total and paid amount to dispense change
        /// </summary>
        private void CalculateChange()
        {
            
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

    

        private void ChangeCalculator_Load(object sender, EventArgs e)
        {

        }


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

    }
}
