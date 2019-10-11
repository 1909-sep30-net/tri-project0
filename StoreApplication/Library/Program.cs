using System;
using System.Collections.Generic;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {

            //fast testing customer class
            Console.WriteLine("Hello World!");

            List<Customer> CustList = new List<Customer>();
            
            Customer customer1 = new Customer("Rotty", "Tops", "Sequin Land", 8675309);
            Customer customer2 = new Customer("Shantae", "Genie", "Sequin Land", 5556969);
            Customer customer3 = new Customer("Risky", "Boots", "Seven Seas", 1002000);

            customer1.DisplayCust();
            customer2.DisplayCust();

            customer1.FirstName = "Sky";
            customer1.LastName = "Trainer";
            customer1.Address = "Mermaid Falls";
            customer1.Phone = 7777777;

            customer1.DisplayCust();

            CustList.Add(customer1);

            foreach (Customer cust in CustList)
            {
                Console.WriteLine(cust.FirstName + ' ' + cust.LastName);
            }
            Console.WriteLine(CustList[0].FirstName);

            CustList.ForEach(Console.WriteLine);

            List<Product> MyOrder = new List<Product>();

            Product Prod1 = new Product();
            Product Prod2 = new Product();

            Prod1.Brand = "Omega";

            Prod1.Model = "Sea Master";
            Prod2.Model = "Snowflake";

            Prod1.ID = 1;
            
            Product.AddProd(Prod1);
            Product.AddProd(Prod2);
            
            Prod1.DisplayProd();


        }
    }
}
