using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Customer
    {
        private string fname;
        private string lname;

        public Customer()
        {
            fname = "";
            lname = "";
        }


        public string defaultStore = "Arlington";
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
