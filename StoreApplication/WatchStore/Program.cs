using System;

//UI
//Where I shall run the watch store from
namespace WatchStore
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while(running == true)
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

                        break;
                    case 2:
                        Console.WriteLine("Most recent order history: ");
                        //Run foreach loop to loop through order history

                        break;
                    case 3:
                        Console.WriteLine("The recent customers: ");
                        //Run foreach loop to loop through customer list

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
