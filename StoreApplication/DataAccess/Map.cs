using System;
using System.Collections.Generic;
using System.Text;

using System.Linq;

namespace DataAccess
{
    public static class Map
    {

        //Map Entity Framework EF to business model
        //Because VS can only read objects or code so
        //convert EF to objects data
        //Entity-->object data

        public static Library.Customer MapEFCustomerWithCustomer(Entities.Customer Ecustomer)
        {
            return new Library.Customer
            {
                ID = Ecustomer.Cid,
                Address = Ecustomer.Addresses,
                Phone = Ecustomer.Phone,
                //FirstName = Ecustomer.Names

            };
        }
    }
}
