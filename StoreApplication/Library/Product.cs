using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Product
    {
        //Might be placehold, will figure out later
        //Products and their IDs
        
        //Made static
        static List<Product> ActualProduct = new List<Product>();
         
        public string Omega = "Omega";
        public string Rolex = "Rolex";
        public string GrandSeiko = "Grand Seiko";
        public string IWC = "IWC";

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
            Console.WriteLine("Your model: " + Model + ", ID: " + ID );
        }

    }
}
