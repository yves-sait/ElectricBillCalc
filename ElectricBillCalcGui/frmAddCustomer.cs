using CustomerData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricBillCalcGui
{
    public partial class frmAddCustomer : Form
    {
        // public variable of type customer
        public Customer newCustomer = null;  //declare new customer to add.

        
        public frmAddCustomer()
        {
            InitializeComponent();
            
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // validate user inputs using validator methods.
            if (Validator.IsPresent(txtFirstName) &&
                Validator.IsPresent(txtLastName) &&
                Validator.IsPresent(txtUsage) &&
                Validator.isNonNegativeDecimal(txtUsage)
                
                )
            {
                // new customer object creation via constructor and assign object to variable
                newCustomer = new Customer(txtFirstName.Text, 
                                           txtLastName.Text, 
                                           Convert.ToDecimal(txtUsage.Text));
                this.DialogResult = DialogResult.OK; 
            }

        }

        // button to remove inputs on textboxes and user can restart to provide new inputs.
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtUsage.Clear();
            txtFirstName.Focus();

        }
    }
}
