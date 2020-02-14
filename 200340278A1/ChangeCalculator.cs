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
            //if (this.totalInput.Text.Length < this.totalInput.SelectionStart + 1)
               // MessageBox.Show("Please enter a positive number for your total amount");

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
            OperationType myEnum = (decimal)OperationType.Minus;

            this.changeOutput.Text = ParseOperation();
        }

        /// <summary>
        /// Parses user equation and calculates the result
        /// </summary>
        /// <returns></returns>
        private string ParseOperation()
        {
            try
            {
                // Get the users inputs
                var userTotalInput = this.totalInput.Text;
                var userPaidInput = this.paidInput.Text;

                // Remove all spaces
                userTotalInput = userTotalInput.Replace(" ", "");
                userPaidInput = userPaidInput.Replace(" ", "");

                // create a new operation
                var operation = new Operation();
                var leftSide = true;

                for(int i = 0; i < userTotalInput.Length; i++)
                {
                    if("0123456789.".Any(characters => userTotalInput[i] == characters))
                    {
                        if(leftSide)
                        {
                            operation.LeftSide += userTotalInput[i];
                        }
                    }
                }

                return string.Empty;
            }
            catch(Exception ex)
            {
                return $"Invalid equation. {ex.Message}";
            }
        }

        /// <summary>
        /// Checking for valid characters
        /// </summary>
        /// <param name="currentNumber"></param>
        /// <param name="newCharacter"></param>
        /// <returns></returns>
        private string AddNumberPart(string currentNumber, char newCharacter)
        {
            // check if there is already a radix in the input
            if(newCharacter == '.' && currentNumber.Contains('.'))
            {
                throw new InvalidOperationException($"Number {currentNumber} already contains a . and another cannot be added");
            } return currentNumber + newCharacter;
        }



        public enum OperationType
        {
            /// <summary>
            /// Find the differance between paid amount and total amount
            /// </summary>
            Minus
        }
        #endregion

        private void ChangeCalculator_Load(object sender, EventArgs e)
        {

        }
    }

    public class Operation
    {

        // left side of operation
        public string LeftSide { get; set; }

        // right side of operation
        public string RightSide { get; set; }
       
        // type of operation to perform
        public OperationType OperationType { get; set; }

        public Operation InnerOperation { get; set; }

        // create empty strings instead of nulls
        public Operation()
        {
            this.LeftSide = string.Empty;
            this.RightSide = string.Empty;
        }
    }
}
