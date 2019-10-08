using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Order
    {

        //add an address right or something

        Customer customer { get; set; }

        public int orderTime { get; set; }

        public int orderType { get; set; }

        public bool rejectOrder { get; set; }

        //additional business rules


    }
}