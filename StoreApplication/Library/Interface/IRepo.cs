using System;
using System.Collections.Generic;
using System.Text;

using Library;

namespace Library.Interface
{
    public interface IRepo: IDisposable
    {

        void PlaceOrder(Order ord);
        void AddCustomer(Customer cus);
        IEnumerable<Customer> SearchCustomer(string searching = null);

        void DisplayCustomerOrder();

        //void DisplayStoreHistory();

        void DisplayCustomerHistory();



        //
    }
}
