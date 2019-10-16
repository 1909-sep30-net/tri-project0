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

        public Library.Customer SearchCustomerName(string name)
        {
            return Map.MapEFWithCustomer(MyDBContext.Customer.Find(name));
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
