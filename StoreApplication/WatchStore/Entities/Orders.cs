using System;
using System.Collections.Generic;

namespace WatchStore.Entities
{
    public partial class Orders
    {
        public Orders()
        {
            CustomerOrder = new HashSet<CustomerOrder>();
        }

        public int Oid { get; set; }
        public string OrderType { get; set; }
        public DateTime OrderTime { get; set; }
        public int Cid { get; set; }

        public virtual Customer C { get; set; }
        public virtual ICollection<CustomerOrder> CustomerOrder { get; set; }
    }
}
