using System;
using System.Collections.Generic;

namespace DataAccess.Entities
{
    public partial class CustomerOrder
    {
        public int Oid { get; set; }
        public int Pid { get; set; }
        public int Amount { get; set; }

        public virtual Orders O { get; set; }
        public virtual Product P { get; set; }
    }
}
