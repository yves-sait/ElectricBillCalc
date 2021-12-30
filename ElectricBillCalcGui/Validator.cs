using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricBillCalcGui
{
    /// <summary>
    /// User input validation methods for Windows Forms projects
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Validates if the input on the textbox is not empty or null
        /// </summary>
        /// <param name="txtbox">input textbox data to validate</param>
        /// <returns>true if the textbox is not empty/null otherwise false </returns>
        public static bool IsPresent(TextBox txtbox)
        {
            bool isValid = true;
            if (String.IsNullOrEmpty(txtbox.Text))
            {
                isValid = false;
                MessageBox.Show(txtbox.Tag + " is required"); // prompt user to enter valid input
                txtbox.Focus();
            }

            return isValid;
        }

        /// <summary>
        /// Validates if the input on the textbox is non-negative double value
        /// </summary>
        /// <param name="txtbox">input textbox data to validate</param>
        /// <returns>true if the input is valid(non-negative double value) otherwise false</returns>
        public static bool isNonNegativeDecimal(TextBox txtbox)
        {
            bool isValid = true;
            decimal result;
            if(!Decimal.TryParse(txtbox.Text, out result))
            {
                isValid = false;
                MessageBox.Show(txtbox.Tag + " must be a number");// prompt user to enter valid input
                txtbox.SelectAll();
                txtbox.Focus();
            }
            else
            {
                if(result < 0)
                {
                    isValid = false;
                    MessageBox.Show(txtbox.Tag + " must be greater than or equal to zero");// prompt user to enter valid input
                    txtbox.SelectAll();
                    txtbox.Focus();
                }
            }
            return isValid;
        }



    }
}
