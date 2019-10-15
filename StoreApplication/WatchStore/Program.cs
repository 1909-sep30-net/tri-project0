using System;
using Library;
using System.Collections.Generic;

//Added these usings
using System.Linq;
//using WatchStore.Entities; //Comment this out to get rid of ambiguity with classes
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging; //For use of logging


//UI
//Where I shall run the watch store from
//Will clean up with method calls so it can be easy to look at
namespace WatchStore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Added this to start to connect the database with visual
            //string connectionString = SecretConfiguration.ConnectionString;
            //DbContextOptions<WatchStoreContext> options = new DbContextOptionsBuilder<WatchStoreContext>()
            //    .UseSqlServer(connectionString)
            //    //.UseLoggerFactory(Logger)
            //    .Options;


            bool Running = true;
            
            //Generates random number for ID
            //Have to add more implementation for a unique ID
            Random Rand = new Random();
            int RandID = Rand.Next(1, 1000);

            //List<WatchStore.Entities.Customer> OurCust = new List<WatchStore.Entities.Customer>();
            List<Customer> OurCust = new List<Customer>();
            List<Product> OurProd = new List<Product>();
            List<Order> OurOrd = new List<Order>();

            //WatchStore.Repository

            while (Running == true)
            {
                Console.WriteLine("Welcome! What would you like to do?");
                Console.WriteLine("[1] Place an order");
                Console.WriteLine("[2] Order history");
                Console.WriteLine("[3] Recent customers");
                Console.WriteLine("[4] Check products");
                Console.WriteLine("[5] Quit");
                Console.WriteLine("");


                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("");

                        Console.WriteLine("What is your first name?");

                        var first = Console.ReadLine();
                        
                        Console.WriteLine("What is your last name?");

                        var second = Console.ReadLine();

                        Console.WriteLine("What is your address?");

                        var address = Console.ReadLine();

                        Console.WriteLine("What is your phone number?");
                        
                        var phone = Console.ReadLine();

                        var yourID = RandID;

                        Customer cust = new Customer(yourID, first, second, address, phone);

                        Console.WriteLine("This is you: ");
                        cust.DisplayCust();
                        OurCust.Add(cust);

                        Console.WriteLine("Would you like to quit back to main menu? y or n");

                        var quit = Console.ReadLine();
                        if(quit == "y")
                        { 
                            break;
                            
                        }
                        else
                        {
                            Console.WriteLine("Closing up");
                            Running = false;
                        }

                        break;
                        
                    case "2":
                        Console.WriteLine("Most recent order history: ");
                        //Run foreach loop to loop through order history
                        foreach( Product prod in OurProd)
                        {
                            Console.WriteLine(prod.PID + " " + prod.Brand + " " + prod.Model);
                        }

                        break;
                    case "3":
                        Console.WriteLine("The recent customers: ");
                        foreach (Customer cus in OurCust)
                        {
                            Console.WriteLine(cus.FirstName + " " + cus.LastName + " " + cus.Address + " " + cus.Phone);
                        }

                        break;
                    case "4":
                        Console.WriteLine("Checking available products: ");
                        Console.WriteLine("Brand: Omega - Model: Seamaster");
                        Console.WriteLine("Brand: Rolex - Model: Datejust");
                        Console.WriteLine("Brand: Grand Seiko - Model: Snowflake");
                        Console.WriteLine("Brand: IWC - Model: Flieger");
                        break;
                    case "5":
                        Console.WriteLine("Quitting!");
                            Running = false;
                        break;
                }//Switch statement

            }//while loop

        }
    }
}
