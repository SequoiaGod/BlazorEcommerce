using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorEcommerce.Shared
{
    public class Product
    {
        public int ID { get; set; }
        public String Title { get; set; }=String.Empty;
        public String Description { get; set; } = String.Empty;
        public String ImageUrl { get; set; } = String.Empty;
        [Column(TypeName ="decimal(18,2)")]
        public Decimal Price { get; set; }  

        public Product(int iD, string title, string description, string imageUrl, decimal price)
        {
            ID = iD;
            Title = title;
            Description = description;
            ImageUrl = imageUrl;
            Price = price;
        }

        public Product() { }

    }
}
