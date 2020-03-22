using ClassLibraryNetCore.Model;
using System.Collections.Generic;

namespace ClassLibraryNetCore
{
    public partial class OrderDetails
    {
        public int OrderDetailsId { get; set; }
        public ICollection<Client> Clients { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Product> Products { get; set; }
        public Product Product { get; internal set; }
        public Order Order { get; internal set; }

        protected OrderDetails() { }
    }
}