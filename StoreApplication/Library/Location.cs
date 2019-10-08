using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    //Don't camelCase for method, Naming convention for C#
    class Location
    {
        //Should probably use a list
        public int inventoryCount = 200;

        public int InventoryDecrease { get; set; }

        public int FullfillInventory(int order)
        {
            if (order < inventoryCount)
            {
                return 1; //return one to indicate we have enough stock
            }
            return -1; //return negative one to say we don't have enough
        }


            //Test the list way plus the other way too
        public void MyInventory(List<Product> stock)
        {

        }
    }
}