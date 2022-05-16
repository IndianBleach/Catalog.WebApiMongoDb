using CatalogWebApi.Core.DTOs;
using CatalogWebApi.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogWebApi.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        private readonly ICatalogRepository _catalogRepository;
        public CatalogController(ICatalogRepository catalogRepository)
        {
            _catalogRepository = catalogRepository;
        }

        [HttpPost]
        [Route("/item")]
        public ActionResult<CatalogItemDto> Item(CreateCatalogItemDto model)
        {
            return _catalogRepository.CreateCatalogItem(model);
        }

        [HttpGet]
        [Route("/item")]
        public ActionResult<CatalogItemDto> ItemById([FromBody]string id)
        {
            return _catalogRepository.GetItemById(Guid.Parse(id));
        }

        [HttpGet]
        [Route("/page")]
        public IEnumerable<CatalogItemDto> ItemsPerPage(int? page)
        {
            return _catalogRepository.GetItemsPerPage(page);
        }

    }
}
