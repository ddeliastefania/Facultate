namespace Laboratorul6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SKU { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public decimal? Price { get; set; }

        [StringLength(50)]
        public string ImageURL { get; set; }
        public Product()
        {

        }
        public Product(string description, decimal price, string url)
        {
            SKU = new Random().Next(1, 20000);
            Description = description;
            Price = price;
            ImageURL = url;
        }
    }
}
