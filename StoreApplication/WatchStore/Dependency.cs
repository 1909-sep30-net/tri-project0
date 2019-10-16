using System;
using System.Collections.Generic;
using System.Text;

using Library.Interface;
using Microsoft.EntityFrameworkCore;
using DataAccess.Entities;
using DataAccess.Repositories;


namespace WatchStore
{
    public static class Dependency
    {
        //Creates a method of type interface that utilizes the 
        //methods from the interface and the class that uses
        //that interface.  
        //So we can use those methods in the UI
        public static IRepo CreateWatchStoreRepo()
        {
            var optionsBuilder = new DbContextOptionsBuilder<WatchStoreContext>();
            optionsBuilder.UseSqlServer(SecretConfiguration.ConnectionString);

            var MydbContext = new WatchStoreContext(optionsBuilder.Options);
            return new WatchStoreRepository(MydbContext);
        }
        
    }
}
