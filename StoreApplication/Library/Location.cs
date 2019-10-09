using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    //Store location that has its own inventory and methods for adding and taking
    //away products
    public class Location
    {
        //store inventory
        List<Product> InventoryLocation = new List<Product>();

        //adds to inventory
        public void AddLocation(Product stock)
        {
            InventoryLocation.Add(stock);
        }

        //subtracts from inventory
        public void SubLocation(Product stock)
        {
            InventoryLocation.Remove(stock);
        }

        //rejects order if inventory less than 20
        public bool RejectLocation()
        {
            if(InventoryLocation.Count < 20)
            {
                return true;
            }

            return false;
        }

    }
}