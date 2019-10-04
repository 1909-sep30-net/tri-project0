using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApplication
{
    class Location
    {
        public int inventoryCount = 200;

        public int inventoryDecrease { get; set; }

        public int fullfillInventory(int order)
        {
            if(order < inventoryCount)
            {
                return 1; //return one to indicate we have enough stock
            }
            return -1; //return negative one to say we don't have enough
        }
    }
}
