using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogWebApi.Core.Entities
{
    public record BaseEntity
    { 
        public Guid Id { get; init; }

        public BaseEntity()
            => Id = Guid.NewGuid();
    }

    public record ItemCategory : BaseEntity
    {
        public string Name { get; init; }
        public ICollection<CatalogItem> Items { get; set; }
        public ItemCategory(
            string name)
        {
            Name = name;
            Items = new List<CatalogItem>();
        }
    }

    public record CatalogItem : BaseEntity
    {
        public string Name { get; init; }
        public decimal Price { get; init; }
        public string Description { get; init; }
        public string CategoryId { get; set; }
        public ItemCategory Category { get; set; }
        public DateTimeOffset UTCDateCreated { get; init; }

        public CatalogItem(
            string name,
            string description,
            decimal price,
            string categoryId)
        {
            CategoryId = categoryId;
            Price = price;
            Name = name;
            Description = description;
            UTCDateCreated = DateTimeOffset.UtcNow;
        }

        public CatalogItem(
            string name,
            string description,
            decimal price,
            ItemCategory category)
        {
            Category = category;
            Price = price;
            Name = name;
            Description = description;
            UTCDateCreated = DateTimeOffset.UtcNow;
        }
    }
}
