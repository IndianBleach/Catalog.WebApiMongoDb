using CatalogWebApi.Core.DTOs;
using CatalogWebApi.Core.Entities;
using CatalogWebApi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogWebApi.Infrastructure.Repositories
{
    /*
    public class CatalogRepository : ICatalogRepository
    {
        CatalogItem[] _items = new CatalogItem[]
        {
            new("Iphone XR 64GB", "Released product!", 89_990, new ItemCategory("Phones")),
            new("Iphone XR 128GB", "Released product for 128gb!", 139_990, new ItemCategory("Phones 128gb")),
            new("Iphone 12 64GB Plus", "Released product! Plus version", 122_990, new ItemCategory("Phones plus")),
            new("Iphone 12 128GB Plus", "Released product! Plus version 128gb", 148_990, new ItemCategory("Phones 128gb plus")),
            new("Iphone 13 264GB", "Released product! 264gb ram", 239_990, new ItemCategory("Phones 264gb")),
        };

        public void CreateItem(string name, string desc, decimal price, string category)
        {
            _items.Append(new CatalogItem(name, desc, price, new ItemCategory(category)));
        }

        public CatalogItemDto GetItemById(string id)
        {
            CatalogItem item = _items
                .FirstOrDefault(x => x.Id.ToString() == id);

            return new CatalogItemDto(item.Name, item.Description, item.Category.Name, item.Price);
        }

        public ICollection<CatalogItemDto> GetItemsPerPage(int? page)
        {
            page = page ?? 1;

            ICollection<CatalogItemDto> dtos = _items
                .Skip(10 * ((int)page - 1))
                .Take(10)
                .Select(x => new CatalogItemDto(x.Name, x.Description, x.Category.Name, x.Price))
                .ToList();

            return dtos;
        }
    }
    */
}
