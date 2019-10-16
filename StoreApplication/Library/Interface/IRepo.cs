using System;
using System.Collections.Generic;
using System.Text;

using Library;

namespace Library.Interface
{
    public interface IRepo: IDisposable
    {
        void AddCustomer(Customer customer);

        //void AddOrder(Order order);

        public void LookCustomer(string name);

        public List<Customer> GetAllCustomer();

        public List<Product> GetAllProduct();

        public List<Order> GetAllOrder();

        public List<Location> GetAllLocation();

        void Save();
    }
}
