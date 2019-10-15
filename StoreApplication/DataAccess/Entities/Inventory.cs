using System;
using System.Collections.Generic;

namespace DataAccess.Entities
{
    public partial class Inventory
    {
        public int Quantity { get; set; }
        public string Located { get; set; }
        public int Pid { get; set; }

        public virtual Locations LocatedNavigation { get; set; }
        public virtual Product P { get; set; }
    }
}
