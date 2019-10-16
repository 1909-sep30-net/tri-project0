using System;
using System.Collections.Generic;
using System.Text;

using Library;

namespace Library.Interface
{
    public interface IRepo: IDisposable
    {
        void AddCustomer(Customer customer);

        Customer SearchCustomerName(Customer customers);

        public Customer FindCustomerName(string name);

        public List<Customer> GetAllCustomer();

        public List<Product> GetAllProduct();

        void Save();
    }
}
