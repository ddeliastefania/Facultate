using ClassLibraryNetCore.Model;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClassLibraryNetCore
{
    public partial class Order
    {
        public int OrderId { get; set; }
        [MaxLength(20)]
        public ICollection<Client> Clients { get; set; }
        public Client Client { get; internal set; }
        public OrderDetails[] OrderDetails { get; internal set; }

        protected Order() { }
    }
}