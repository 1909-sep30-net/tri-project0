using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    /// <summary>
    /// This is the customer class.
    /// It has their name and address
    /// </summary>
    public  class Customer
    {
        //changed PhoneNum and it methods that access it from type int to type string

        public string defaultStore = "Arlington";
        private string fname;
        private string lname;
        private string StoreAddress;
        private string CustAddress;
        private string PhoneNum;
        private int CID;

        List<Customer> AmountCust = new List<Customer>();

        public Customer()
        {

        }

        public Customer(string firstName, string lastName, string address, string phone)
        {
            fname = firstName;
            lname = lastName;
            CustAddress = address;
            PhoneNum = phone;

        }

        //Might not use this
        public void CustomerAdd(string firstName, string lastName, string address, string phone)
        {
            Customer cust = new Customer();

            cust.FirstName = firstName;
            cust.LastName = lastName;
            cust.CustAddress = address;
            cust.Phone = phone;

            AmountCust.Add(cust);
        }

        //made this static
        public string FirstName
        {
            get{ return fname; }

            set{ fname = value; }
        }

        public string LastName
        {
            get{ return lname; }
            
            set{ lname = value; }
        }

        public string Address
        {
            get { return CustAddress; }
            set { CustAddress = value; }
        }

        public string Phone
        {
            get { return PhoneNum; }
            set { PhoneNum = value; }
        }
        
        public void ValidationName()
        {
            if(fname.Length < 1)
            {
                throw new Exception("First name is not long enough!");
            }
            else if (lname.Length < 1)
            {
                throw new Exception("Last name is not long enough!");
            }
        }
        public void DisplayCust()
        {
            Console.WriteLine("Name: " + fname + " " + lname + ", Address: " + CustAddress + ", Phone: " + PhoneNum);
        }

        //MIGHT DELETE, MIGHT NOT USE, UNSURE
        public void AddCust(Customer cu)
        {
            AmountCust.Add(cu);
        }

        //Added this in, will think about it
        public void RemoveCust(Customer cu)
        {
            AmountCust.Remove(cu);
        }

        public void SearchCust()
        {
            foreach(var custom in AmountCust)
            {
                //Will fill this in later, maybe in UI
            }
        }

    }
}
