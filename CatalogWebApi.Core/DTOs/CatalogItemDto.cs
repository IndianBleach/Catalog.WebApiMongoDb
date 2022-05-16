using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogWebApi.Core.DTOs
{
    public class CatalogItemDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }

        public CatalogItemDto(
            string name,
            string description,
            string category,
            decimal price)
        {
            Name = name;
            Price = price;
            Category = category;
            Description = description;
        }
    }
}
