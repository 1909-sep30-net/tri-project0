using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {

            //fast testing customer get set
            Console.WriteLine("Hello World!");
            Customer customer = new Customer("Rotty", "Tops");
            Console.WriteLine(customer.FirstName);
            customer.FirstName = "Shantae";
            Console.WriteLine(customer.FirstName);

            Console.WriteLine(customer.LastName);
            customer.LastName = "Genie";
            Console.WriteLine(customer.LastName);
        }
    }
}
