using System;
using System.Collections.Generic;

//Added these usings
using Library;
using Library.Interface;
using System.Linq;


//UI
//Where I shall run the watch store from
//Will clean up with method calls so it can be easy to look at
namespace WatchStore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates and establishes a connection between
            //the database and VS
            using IRepo WatchStoreRepo = Dependency.CreateWatchStoreRepo();
            


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
                //Might make 1 into add new customer and such
                Console.WriteLine("Welcome to my watch store! What would you like to do?");
                Console.WriteLine("[1] Add a customer");
                Console.WriteLine("[2] Recent customers");
                Console.WriteLine("[3] Place an order");
                Console.WriteLine("[4] Order history");
                Console.WriteLine("[5] Check products");
                Console.WriteLine("[6] Quit");
                Console.WriteLine("");


                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("");

                        Console.WriteLine("What is your first and last name?");

                        var name = Console.ReadLine();

                        //if (name.Length < 1)
                        //{
                        //    Console.WriteLine("Name too short, type again.");
                        //    name = Console.ReadLine();
                        //}

                        Console.WriteLine("What is your address?");

                        var address = Console.ReadLine();

                        Console.WriteLine("What is your phone number?");

                        var phone = Console.ReadLine();

                        var yourID = RandID;

                        var cust = new Customer();
                        cust.Names = name;
                        cust.Address = address;
                        cust.Phone = phone;

                        WatchStoreRepo.AddCustomer(cust);
                        WatchStoreRepo.Save();


                        Console.WriteLine("This is you: ");
                        //Might have to + 1 the ID to match the Database
                        cust.DisplayCust();
                        

                        Console.WriteLine("Would you like to quit back to main menu? y or n");

                        var quit = Console.ReadLine();
                        if(quit == "y")
                        {
                            Console.WriteLine("");
                            break;
                            
                        }
                        else
                        {
                            Console.WriteLine("Closing up");
                            Running = false;
                        }

                        break;
                        
                    case "2":
                        

                        Console.WriteLine("The recent customers: Type name to find");
                        var cust1 = WatchStoreRepo.GetAllCustomer();
                        foreach (Customer cu in cust1)
                        {
                            Console.WriteLine("ID: " + cu.ID + " Name: " + cu.Names + " Address: " + cu.Address + " Phone: " + cu.Phone);
                        }
                        Console.WriteLine();
                        
                        string UserName = Console.ReadLine();
                        WatchStoreRepo.FindCustomerName(UserName);

                        break;

                    case "3":
                        Console.WriteLine("Placing your order, please choose a customer: ");

                        break;

                    case "4":
                        Console.WriteLine("Most recent order history: ");
                        //Run foreach loop to loop through order history
                        foreach (Product prod in OurProd)
                        {
                            Console.WriteLine(prod.PID + " " + prod.Names + " " + prod.Model);
                        }
                        break;

                    case "5":
                        Console.WriteLine("Checking available products: ");
                        Console.WriteLine();
                        var prod1 = WatchStoreRepo.GetAllProduct();
                        foreach (Product pro in prod1)
                        {
                            Console.WriteLine("Brand: " + pro.Names + " Model: " + pro.Model + " Price: " + pro.Price);
                        }
                        Console.WriteLine();

                        break;

                    case "6":
                        Console.WriteLine("Quitting!");
                        Running = false;
                        break;
                }//Switch statement

            }//while loop

        }
    }
}
