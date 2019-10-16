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

        public Library.Customer SearchCustomerName(Library.Customer customer)
        {
            return Map.MapEFWithCustomer(MyDBContext.Customer.Find(customer));
        }

        public Library.Customer FindCustomerName(string name)
        {
            return MyDBContext.Customer.Select(Map.MapEFWithCustomer).Where(cust => cust.Names == name).FirstOrDefault();
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
