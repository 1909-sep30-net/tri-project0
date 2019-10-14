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

        public string Brand { get; set; }
        
        public int NumOmega { get; set; }
        public int NumRolex { get; set; }

        public int NumGrandSeiko { get; set; }

        public int NumIWC { get; set; }


        public string Model { get; set; }

        public int ID { get; set; }

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
            Console.WriteLine("Your ID: " + ID + ", brand: " + Brand + ", model: " + Model);
        }

    }
}
