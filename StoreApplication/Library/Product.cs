using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Product
    {
        //Products and their IDs
        
        //Made static
        static List<Product> ActualProduct = new List<Product>();
         
        //public string Omega = "Omega";
        //public string Rolex = "Rolex";
        //public string GrandSeiko = "Grand Seiko";
        //public string IWC = "IWC"; //schaffhausen

        public string Names { get; set; } //Will be Names in Database
        
        public int NumOmega { get; set; }
        public int NumRolex { get; set; }

        public int NumGrandSeiko { get; set; }

        public int NumIWC { get; set; }


        public string Model { get; set; }

        public int PID { get; set; }

        public int Price { get; set; }

        //made static
        public static void AddProd(Product MyP)
        {
            //MyP.Model = "l";
            ActualProduct.Add(MyP);
        }

        public void RemoveProd(Product MyP)
        {
            ActualProduct.Remove(MyP);
        }

        public void DisplayProd()
        {
            //foreach (var prod in ActualProduct)
            //{
            //    Console.WriteLine("Your product: " + prod.Model);
            //}
            Console.WriteLine("Your ID: " + PID + ", brand: " + Names + ", model: " + Model);
        }

    }
}
