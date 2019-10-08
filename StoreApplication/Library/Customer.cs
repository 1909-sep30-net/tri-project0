using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    /// <summary>
    /// This is the customer class
    /// XML comments required in business library 
    /// </summary>
    public class Customer
    {
        public string defaultStore = "Arlington";
        private string fname;
        private string lname;
        private string store;


        //create customer object with parameters
       
        
        
          public Customer() 
          { 
          }
        
          public Customer(string firstName, string lastName ){          
                fname = firstName;
                lname = lastName;
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


    }
}
