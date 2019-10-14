using System;
using Library;
using System.Collections.Generic;

//UI
//Where I shall run the watch store from
namespace WatchStore
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            List<Customer> OurCust = new List<Customer>();
            List<Product> OurProd = new List<Product>();
            List<Order> OurOrd = new List<Order>();

            while (running == true)
            {
                Console.WriteLine("Please enter your destination.");
                Console.WriteLine("[1] Place an order.");
                Console.WriteLine("[2] Order history.");
                Console.WriteLine("[3] Recent customers.");
                Console.WriteLine("[4] Check products.");
                Console.WriteLine("[5] Quit.");

                var answer = Console.Read();

                //Will add more functionality to the UI in the future
                //Will use class methods to display stuff later, place holder
                switch (answer)
                {
                    case 1:
                        Console.WriteLine("Placing Order: ");
                        //Method to place order according to location and inventory
                        Console.WriteLine("What is your first name?");
                        Console.WriteLine("What is your last name?");
                        Console.WriteLine("What is your address?");
                        Console.WriteLine("What is your phone number?");
                        
                        var first = Console.ReadLine();
                        var last = Console.ReadLine();
                        var address = Console.ReadLine();
                        var phone = Console.ReadLine();

                        Customer cust = new Customer(first, last, address, phone);
                        OurCust.Add(cust);



                        break;
                    case 2:
                        Console.WriteLine("Most recent order history: ");
                        //Run foreach loop to loop through order history
                        foreach (Product prod in OurProd)
                        {
                            Console.WriteLine(prod.ID + " " + prod.Brand + " " + prod.Model);
                        }


                        break;
                    case 3:
                        Console.WriteLine("The recent customers: ");
                        //Run foreach loop to loop through customer list
                        foreach (Customer cus in OurCust)
                        {
                            Console.WriteLine(cus.FirstName + " " + cus.LastName + " " + cus.Address + " " + cus.Phone);
                        }

                        break;
                    case 4:
                        Console.WriteLine("Checking available products: ");
                        Console.WriteLine("Brand: Omega - Model: Seamaster");
                        Console.WriteLine("Brand: Rolex - Model: Datejust");
                        Console.WriteLine("Brand: Grand Seiko - Model: Snowflake");
                        Console.WriteLine("Brand: IWC - Model: Flieger");

                        break;
                    case 5:
                        Console.WriteLine("Closing, goodbye!");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Wrong input, try again!");
                            break;
                }




            }
        }
    }
}
