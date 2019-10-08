using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    /// <summary>
    /// This is the customer class
    /// XML comments required in business library 
    /// </summary>
    class Customer
    {
        public string defaultStore = "Arlington";
        private string fname;
        private string lname;
        private string store;

        //public Customer()
        //{
        //    fname = "";
        //    lname = "";
        //    store = defaultStore;

        //}

        //create customer object with parameters
       
        
        
          public Customer() { }
        
          public Customer(string firstName, string lastName ){          

                //this firstname = fname;
                //this lastName = lname;

                fname = firstName;
                lname = lastName;


            }

        /// <summary>
        /// Address address1 = new Address(fields..)
        ///  
        /// address1.
        /// Customer cust1 = new Customer("Dave", "Hall",b address) 
        /// 
        /// 
        /// 
        /// 
        /// </summary>



        public string firstName
        {
            get
            {
                return fname;
            }

            set
            {
                fname = value;
            }
        }

        public string lastName
        {
            get
            {
                return lname;
            }
            set
            {
                lname = value;
            }
        }


    }
}
