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

        public int inventoryDecrease { get; set; }

        public int fullfillInventory(int order)
        {
            if (order < inventoryCount)
            {
                return 1; //return one to indicate we have enough stock
            }
            return -1; //return negative one to say we don't have enough
        }

        
         //* select customer
         //* do this
         //* from customer address
         //* where address within the delivery 
         //* 
         //* 
         //* 
         //* 

            //Test the list way plus the other way too
        public void otherInventory(List<Product> stock)
        {

        }
    }
}