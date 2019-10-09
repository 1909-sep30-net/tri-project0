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
            
            Customer customer1 = new Customer("Rotty", "Tops", "Sequin Land", 8675309);
            Customer customer2 = new Customer("Shantae", "Genie", "Sequin Land", 5556969);

            customer1.DisplayCust();
            customer2.DisplayCust();

            customer1.FirstName = "Sky";
            customer1.LastName = "Trainer";
            customer1.Address = "Mermaid Falls";
            customer1.Phone = 7777777;

            customer1.DisplayCust();

            List<Product> MyOrder = new List<Product>();

            Product Prod1 = new Product();
            Product Prod2 = new Product();

            Prod1.Model = "Sea Master";
            Prod2.Model = "Snowflake";

            
            Product.AddProd(Prod1);
            Product.AddProd(Prod2);
            
            Prod1.DisplayProd();
            //Prod2.DisplayProd();

        }
    }
}
