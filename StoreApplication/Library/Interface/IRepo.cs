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

        void Save();
    }
}
