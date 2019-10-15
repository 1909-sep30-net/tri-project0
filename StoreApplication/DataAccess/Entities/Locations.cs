using System;
using System.Collections.Generic;

namespace DataAccess.Entities
{
    public partial class Locations
    {
        public Locations()
        {
            InventoryNavigation = new HashSet<Inventory>();
        }

        public string Located { get; set; }
        public int Lid { get; set; }
        public int Inventory { get; set; }

        public virtual ICollection<Inventory> InventoryNavigation { get; set; }
    }
}
