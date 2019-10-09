using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    /// <summary>
    /// This is the customer class.
    /// It has their name and address
    /// </summary>
    public class Customer
    {
        public string defaultStore = "Arlington";
        private string fname;
        private string lname;
        private string StoreAddress;
        private string CustAddress;
        private int PhoneNum;

          public Customer() 
          { 
          }
        
          public Customer(string firstName, string lastName, string address, int phone )
          {          
                fname = firstName;
                lname = lastName;
                CustAddress = address;
                PhoneNum = phone;
          }

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

        public int Phone
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

        //public void AddCust()
        //{
        //    CustomerNew.Add(new Customer());
        //}

        //public List<Customer> SearchCust()
        //{
        //    foreach(var cust in CustomerNew)
        //    {
        //        if(cust.Equals())
        //    }
        //}
    }
}
