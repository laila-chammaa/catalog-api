using System;
using System.Collections.Generic;
using Catalog.Entities;
using Catalog.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers {
    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase {
        private readonly InMemItemsRepository repository;
        public ItemsController() {
            repository = new InMemItemsRepository();
        }

        //GET /items
        [HttpGet]
        public IEnumerable<Item> getItems() {
            return repository.GetItems();
        }

        //GET /items/{id}
        [HttpGet("{id}")]
        public ActionResult<Item> getItem(Guid id) {
            var item = repository.GetItem(id);
            if (item is null) {
                return NotFound();
            }
            return item;
        }
    }
}