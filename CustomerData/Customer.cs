using System;

namespace CustomerData
{
    /// <summary>
    /// Represents a customer. Blueprint for creating customer objects.
    /// </summary>
    public class Customer
    {
        //declaring constant charges.
        private const decimal ADMIN_CHARGE = 12m; //adminstration fee
        private const decimal ADDITIONAL_CHARGE = 0.07m; // per kwh charge rate

        //declaring private customer attributes
        private static int counter = 1000; // variable own by class and shared by all class objects.
        private int accountNo;  
        private decimal billAmount;


        // declaring automatic properties as no additional logic is required.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal UsageKwh { get; set; }

        //declaring read-only public properties
        public decimal BillAmount
        {
            get
            {
                return billAmount;
            }
        }

        public int AccountNo
        {
            get
            {
                return accountNo;
            }
        }

        // constructor with 3 params for creating customer objects
        public Customer(string fname = "John", string lname = "Doe", decimal usage = 0) // params default values.
        {

            accountNo = counter; // assign counter variable as initial accoun number.
            counter++; // counter increment by 1 for every new object created.

            //assigning values to the class attributes
            FirstName = fname;
            LastName = lname;
            UsageKwh = usage;

            billAmount = CalculateCharge(); // call method to calculate total bill amount and assign to variable.

        }

    
        /// <summary>
        /// Calculates the bill amount attributes of the customer object
        /// </summary>
        /// <returns>the total charges of this customer object</returns>
        public decimal CalculateCharge()
        {
            decimal charge = (UsageKwh * ADDITIONAL_CHARGE) + ADMIN_CHARGE;

            return charge;
        }




        //override ToString() method and return string representation of this customer object
        public override string ToString()
        {
            return $"{AccountNo} | {FirstName} {LastName} | {UsageKwh} | {BillAmount:C}";
        }









    }
}
