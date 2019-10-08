using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    //Don't camelCase for method, Naming convention for C#
    class Location
    {
        //Current inventory
        List<Product> MyInventory = new List<Product>();

        /// <summary>
        /// Adds more products to the inventory
        /// </summary>
        /// <param name="stock"></param>
        public void Add(Product stock)
        {
            MyInventory.Add(stock);
        }

        /// <summary>
        /// Subtract from List when order is placed
        /// </summary>
        /// <param name="stock"></param>
        public void Sub(Product stock)
        {
            MyInventory.Remove(stock);
        }

        /// <summary>
        /// Rejects order if inventory is less than 10
        /// </summary>
        /// <returns></returns>
        public bool RejectOrderLocate()
        {
            if (MyInventory.Count < 10)
            {
                return false;
            }

            return true;
        }

    }
}