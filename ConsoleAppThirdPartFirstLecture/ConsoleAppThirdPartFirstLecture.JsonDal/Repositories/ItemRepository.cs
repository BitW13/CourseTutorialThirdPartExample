using ConsoleAppThirdPartFirstLecture.Common.Interfaces;
using ConsoleAppThirdPartFirstLecture.Common.Models;
using System;
using System.Collections.Generic;

namespace ConsoleAppThirdPartFirstLecture.JsonDal.Repositories
{
    public class ItemRepository : IItemRepository
    {
        public Item Create(Item item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Item item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetAll()
        {
            throw new NotImplementedException();
        }

        public Item GetItemById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetItemsByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Item item)
        {
            throw new NotImplementedException();
        }
    }
}
