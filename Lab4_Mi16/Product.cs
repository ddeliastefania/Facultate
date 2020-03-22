using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClassLibraryNetCore
{
    public partial class Product
    {
        public int productId { get; set; }
        [MaxLength(20)]
        public ICollection<Order> Orders { get; set; }
        public OrderDetails[] OrderDetails { get; internal set; }

        protected Product() { }
    }
}