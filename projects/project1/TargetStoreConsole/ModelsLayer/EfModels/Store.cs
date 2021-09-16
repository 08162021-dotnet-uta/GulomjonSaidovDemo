using System;
using System.Collections.Generic;

#nullable disable

namespace TargetStoreDbContext.Models
{
    public partial class Store
    {
        public Store()
        {
            ItemizedOrders = new HashSet<ItemizedOrder>();
        }

        public int StoreId { get; set; }
        public string StoreName { get; set; }

        public virtual ICollection<ItemizedOrder> ItemizedOrders { get; set; }
    }
}
