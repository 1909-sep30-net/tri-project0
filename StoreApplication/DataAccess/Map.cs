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
        
        //MAPPING CUSTOMER   
        //Entity-->object data

        public static Library.Customer MapEFWithCustomer(Entities.Customer Ecustomer)
        {
            return new Library.Customer
            {
                ID = Ecustomer.Cid,
                Names = Ecustomer.Names,
                Address = Ecustomer.Addresses,
                Phone = Ecustomer.Phone
            };
        }

        //Map business model to EF
        //object data --> Entity

        public static Entities.Customer MapCustomerWithEF(Library.Customer Ocustomer)
        {
            return new Entities.Customer
            {
                Cid = Ocustomer.ID,
                Names = Ocustomer.Names,
                Addresses = Ocustomer.Address,
                Phone = Ocustomer.Phone
            };
        }

        //MAPPING ORDER
        //Maps entity to data object
        //Entity--> object data
        public static Library.Order MapEFWithOrder(Entities.Orders EOrder)
        {
            return new Library.Order
            {
                OID = EOrder.Oid,
                CID = EOrder.Cid,
                LID = EOrder.Lid,
                OrderType = EOrder.OrderType,
                OrderTime = EOrder.OrderTime
            };
        }

        //Maps data object to entity
        //object data --> entity
        public static Entities.Orders MapOrderWithEF(Library.Order OOrder)
        {
            return new Entities.Orders
            {
                Oid = OOrder.OID,
                Cid = OOrder.CID,
                Lid = OOrder.LID,
                OrderType = OOrder.OrderType,
                OrderTime = OOrder.OrderTime
            };
        }

        //MAPPING PRODUCT
        //Entity-->data object
        public static Library.Product MapEFWithProduct(Entities.Product EProduct)
        {
            return new Library.Product
            {
                PID = EProduct.Pid,
                Names = EProduct.Names,
                Model = EProduct.Model,
                Price = EProduct.Price

            };
        }

        //Data object --> Entity
        public static Entities.Product MapProductWithEF(Library.Product OProduct)
        {
            return new Entities.Product
            {
                Pid = OProduct.PID,
                Names = OProduct.Names,
                Model = OProduct.Model,
                Price = OProduct.Price
            };
        }

        //MAPPING LOCATIONS
       //Entity-->data object
       public static Library.Location MapEFWithLocation(Entities.Locations ELocation)
        {
            return new Library.Location
            {
                Locate = ELocation.Located,
                LID = ELocation.Lid,
                Inventory = ELocation.Inventory
            };
        }

        //Data object--> Entity
        public static Entities.Locations MapLocationWithEF(Library.Location OLocation)
        {
            return new Entities.Locations
            {
                Located = OLocation.Locate,
                Lid = OLocation.LID,
                Inventory = OLocation.Inventory
            };
        }

        //MAPPING CUSTOMERORDER
        //Entity-->Data object
        public static Library.CustomerOrder MapEFWithCustomerOrder(Entities.CustomerOrder ECustomerOrder)
        {
            return new Library.CustomerOrder
            {
                Amount = ECustomerOrder.Amount,
                OID = ECustomerOrder.Oid,
                PID = ECustomerOrder.Pid
            };
        }

        //Data object --> Entity
        public static Entities.CustomerOrder MapCustomerOrderWithEF(Library.CustomerOrder OCustomerOrder)
        {
            return new Entities.CustomerOrder
            {
                Amount = OCustomerOrder.Amount,
                Oid = OCustomerOrder.OID,
                Pid = OCustomerOrder.PID
            };
        }

        //MAPPING INVENTORY
        //Entity-->Data object
        public static Library.Inventory MapEFWithInventory(Entities.Inventory EInventory)
        {
            return new Library.Inventory
            {
                Quantity = EInventory.Quantity,
                LID = EInventory.Lid,
                PID = EInventory.Pid
            };
        }

        //Data object-->Entity
        public static Entities.Inventory MapInventoryWithEF(Library.Inventory OInventory)
        {
            return new Entities.Inventory
            {
                Quantity = OInventory.Quantity,
                Lid = OInventory.LID,
                Pid = OInventory.PID
            };
        }
 
    }
}
