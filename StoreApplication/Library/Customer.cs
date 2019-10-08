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

        
          public Customer() 
          { 
          }
        
          public Customer(string firstName, string lastName, string address ){          
                fname = firstName;
                lname = lastName;
                CustAddress = address;
            }

        public string FirstName
        {
            get{return fname;}

            set{fname = value;}
        }

        public string LastName
        {
            get{return lname;}
            
            set{lname = value;}
        }

        public string Address
        {
            get { return CustAddress;}
            set { CustAddress = value; }
        }

    }
}
