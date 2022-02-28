using System;
using System.Collections.Generic;
using Catalog.Entities;

public interface IItemsRepository
{
    Item GetItem(Guid id);
    IEnumerable<Item> GetItems();
}