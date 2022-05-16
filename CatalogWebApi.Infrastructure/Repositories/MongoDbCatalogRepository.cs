using CatalogWebApi.Core.DTOs;
using CatalogWebApi.Core.Entities;
using CatalogWebApi.Core.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogWebApi.Infrastructure.Repositories
{
    public class MongoDbCatalogRepository : ICatalogRepository
    {
        private const string _collectionName = "Items";
        private const string _databaseName = "Catalog";

        private readonly FilterDefinitionBuilder<CatalogItem> _filterBuilder;

        private readonly IMongoCollection<CatalogItem> Items;

        public MongoDbCatalogRepository(IMongoClient client)
        {
            IMongoDatabase database = client.GetDatabase(_databaseName);
            Items = database.GetCollection<CatalogItem>(_collectionName);
            _filterBuilder = new FilterDefinitionBuilder<CatalogItem>();
            
        }

        public CatalogItemDto CreateCatalogItem(CreateCatalogItemDto model)
        {
            CatalogItem create = new(model.Name, model.Description, model.Price, new ItemCategory(model.Name));

            Items.InsertOne(create);

            return new CatalogItemDto(create.Name, create.Description, create.Category.Name, create.Price);
        }

        public CatalogItemDto GetItemById(Guid id)
        {
            var filter = _filterBuilder.Eq(x => x.Id, id);

            CatalogItem getItem = Items.Find(filter)
                .SingleOrDefault();

            return new CatalogItemDto(
                getItem.Category.Name,
                getItem.Description,
                getItem.Category.Name,
                getItem.Price);
        }

        public IEnumerable<CatalogItemDto> GetItemsPerPage(int? page)
        {
            return Items.Find(new BsonDocument())
                .ToList()
                .Select(x => new CatalogItemDto(x.Name, x.Description, x.Category.Name, x.Price));
        }
    }
}
