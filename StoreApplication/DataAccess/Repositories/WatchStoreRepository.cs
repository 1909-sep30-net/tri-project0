using System;
using System.Collections.Generic;
using System.Text;

using System.Linq;
using Microsoft.EntityFrameworkCore;
using Library.Interface;
using DataAccess.Entities;
using Microsoft.Extensions.Logging;

namespace DataAccess.Repositories
{
    public class WatchStoreRepository : IRepo, IDisposable
    {
        public static Customer CurrentCustomer;
        public static CustomerOrder CurrentCustomerOrder;

        private readonly WatchStoreContext MyDBContext;

        //Add logger later

        public WatchStoreRepository(WatchStoreContext dbContext)
        {
            try
            {
                MyDBContext = dbContext;
            }
            catch(ArgumentNullException e)
            {
                Console.WriteLine("This is cannot be null.");
            }




        }

        public void AddCustomer(Library.Customer customer)
        {
            Customer Entity = Map.MapCustomerWithEF(customer);
            MyDBContext.Add(Entity);
        }

        public void AddCustomerOrder(Library.CustomerOrder customerOrder)
        {
            CustomerOrder Entity = Map.MapCustomerOrderWithEF(customerOrder);
            MyDBContext.Add(Entity);
        }

        //Adding order
        //Order is not initalized yet here.  May have to intialize it outside method or another method
        //public void addorder(customer c, locations l, customerorder)
        //{
        //    customer 



        //}

        public void LookCustomer(string name)
        {
            var InputName = MyDBContext.Customer.FirstOrDefault(n=>n.Names == name);
            Console.WriteLine("Found " + name + " at: ");
            Console.WriteLine("ID: " + InputName.Cid + " Name: " + InputName.Names + " Address: " + InputName.Addresses + " Phone: " + InputName.Phone);
        }

        //Gets all customer from entity convert to library data then put to list
        public List<Library.Customer> GetAllCustomer()
        {
            IQueryable<Entities.Customer> cust = MyDBContext.Customer.AsNoTracking();
            return cust.Select(Map.MapEFWithCustomer).ToList();
        }

        public List<Library.Product> GetAllProduct()
        {
            IQueryable<Entities.Product> prod = MyDBContext.Product.AsNoTracking();
            return prod.Select(Map.MapEFWithProduct).ToList();
        }

        public List<Library.Order> GetAllOrder()
        {
            IQueryable<Entities.Orders> ord = MyDBContext.Orders.AsNoTracking();
            return ord.Select(Map.MapEFWithOrder).ToList();
        }

        public List<Library.Location> GetAllLocation()
        {
            IQueryable<Entities.Locations> loc = MyDBContext.Locations.AsNoTracking();
            return loc.Select(Map.MapEFWithLocation).ToList();
        }

        public void Save()
        {
            MyDBContext.SaveChanges();
        }

        private bool DisposeVal = false;
        protected virtual void Dispose(bool dispose)
        {
            if (!DisposeVal)
            {
                if (dispose)
                {
                    MyDBContext.Dispose();
                }
                DisposeVal = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }



    }
}
