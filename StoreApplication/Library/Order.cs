using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Order
    {

        public int OID { get; set; }

        public int CID { get; set; }
        
        public int LID { get; set; }

        //Replaced with LID
        //public string StoreAddress { get; set; }

        //Customer customer { get; set; }

        public DateTime OrderTime { get; set; }

        public string OrderType { get; set; }

        //Current amount of product
        List<CustomerOrder> OrderProduct = new List<CustomerOrder>();



        //additional business rules

        //add more product to current order
        //public void AddOrder(Product requested)
        //{
        //    OrderProduct.Add(requested);
        //}


        ////sub product from current order
        //public void SubOrder(Product requested)
        //{
        //    OrderProduct.Remove(requested);
        //}

        //displays your current order
        public void DisplayOrder()
        {
            foreach(var order in OrderProduct)
            {
                Console.WriteLine("Your order: " + order);
            }
        }

        //Rejects order if products ordered is more than 5
        public bool RejectOrder()
        {
            if (OrderProduct.Count > 5)
            {
                return false;
            }

            return true;
        }
    }
}