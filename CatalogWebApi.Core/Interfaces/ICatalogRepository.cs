using CatalogWebApi.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogWebApi.Core.Interfaces
{
    public interface ICatalogRepository
    {

        CatalogItemDto CreateCatalogItem(CreateCatalogItemDto model);
        //void CreateItem(string name, string desc, decimal price, string category);
        IEnumerable<CatalogItemDto> GetItemsPerPage(int? page);
        CatalogItemDto GetItemById(Guid id);
    }
}
