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
    public partial class frmElectricBillCalc : Form
    {
        //emtpy list creation
        List<Customer> customers = new List<Customer>();
   
         //declaring variable for statistics
        decimal totalUsage = 0; // total Usage
        decimal totalAmt = 0; // total Amount
        decimal avgBillAmt = 0; // average Electricity Bill of customers
        public frmElectricBillCalc()
        {
            InitializeComponent();
        }




        private void btnAddCust_Click(object sender, EventArgs e)
        {
            frmAddCustomer addForm = new frmAddCustomer(); // object creation of the second form(Add form)
            DialogResult result = addForm.ShowDialog(); // displa add form modal 
          
            if (result == DialogResult.OK)
            {
                Customer cust = addForm.newCustomer; // assign customer object from the add form
                customers.Add(cust); // add the new customer object to the list
                lblAllCustomers.Items.Add(cust); // add the customer object to the listbox to display the objects.

             
                totalUsage += cust.UsageKwh; // aggregrate the total usage of the all the customer objects

                totalAmt += cust.BillAmount; // aggregrate the charges on each customer objects
                avgBillAmt = totalAmt / customers.Count; // calculate the avg bill charges of the customers

                //display the statistics
                lblNumCustomer.Text = customers.Count.ToString(); // assign to display the total number of customer objects created
                lblKwhUsed.Text = totalUsage.ToString(); // display the total usage
                lblAvgBillAmt.Text = avgBillAmt.ToString("C"); // display the avg bill


            }

        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
