using System;
using System.Collections.Generic;

namespace DataAccess.Entities
{
    public partial class Inventory
    {
        public int Quantity { get; set; }
        public int Lid { get; set; }
        public int Pid { get; set; }

        public virtual Locations L { get; set; }
        public virtual Product P { get; set; }
    }
}
