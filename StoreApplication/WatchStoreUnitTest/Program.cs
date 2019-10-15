using System;
using Xunit;
using System.Collections.Generic;
using Library;
using System.Text; 

namespace WatchStoreUnitTest
{
    public class Program
    {
        //[Fact] over every method I want to test
        static void Main(string [] args)
        {
            Console.WriteLine("Testing happening now!");

            //blah blah
        }
        
        [Fact]
        public void RemoveShouldRemove()
        {
            // arrange (any setup necessary to prepare for the behavior to test)
            var cust = new Customer();
            
            //Added a customer here

            // act (do the thing you want to test)

            // assert (verify that the behavior was as expected)

            
        }
    }
}
