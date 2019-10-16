using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    /// <summary>
    /// This is the customer class.
    /// It has their name and address
    /// </summary>
    public  class Customer
    {
        //changed PhoneNum and it methods that access it from type int to type string

        //Got rid of first and last name and fused them into on name

        public string defaultStore = "Arlington";
        private string Name;
        private string StoreAddress;
        private string CustAddress;
        private string PhoneNum;
        private int CID;

        List<Customer> AmountCust = new List<Customer>();

        //Added this public list so other classes can use it instead of the in class one above
        //List of customer's orders including their info: name, address, etc
        public List<Order> CustomerOrder { get; set; } = new List<Order>();

        public Customer()
        {

        }

        public Customer(int id, string name, string address, string phone)
        {
            CID = id;
            Name = name;
            CustAddress = address;
            PhoneNum = phone;

        }

        //Might not use this
        public void CustomerAdd(string name, string address, string phone)
        {
            Customer cust = new Customer();

            cust.Name = name;
            cust.CustAddress = address;
            cust.Phone = phone;

            AmountCust.Add(cust);
        }

        //made this static

        public int ID
        {
            get { return CID; }
            set { CID = value; }
        }

        public string Names
        {
            get{ return Name; }

            set{ Name = value; }
        }

        public string Address
        {
            get { return CustAddress; }
            set { CustAddress = value; }
        }

        public string Phone
        {
            get { return PhoneNum; }
            set { PhoneNum = value; }
        }
        
        public void ValidationName()
        {
            if(Name.Length < 1)
            {
                throw new Exception("First name is not long enough!");
            }
        }
        public void DisplayCust()
        {
            Console.WriteLine("ID: "+ CID+ ", Name: " + Name + ", Address: " + CustAddress + ", Phone: " + PhoneNum);
        }

        //MIGHT DELETE, MIGHT NOT USE, UNSURE
        public void AddCust(Customer cu)
        {
            AmountCust.Add(cu);
        }

        //Added this in, will think about it
        public void RemoveCust(Customer cu)
        {
            AmountCust.Remove(cu);
        }

        public void SearchCust()
        {
            foreach(var custom in AmountCust)
            {
                //Will fill this in later, maybe in UI
            }
        }

    }
}
