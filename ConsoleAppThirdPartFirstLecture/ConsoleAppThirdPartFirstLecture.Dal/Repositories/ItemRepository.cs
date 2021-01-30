using ConsoleAppThirdPartFirstLecture.Common.Extensions;
using ConsoleAppThirdPartFirstLecture.Common.Interfaces;
using ConsoleAppThirdPartFirstLecture.Common.Models;
using ConsoleAppThirdPartFirstLecture.Dal.Storages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppThirdPartFirstLecture.Dal.Repositories
{
    public class ItemRepository : IItemRepository
    {
        public Item Create(Item item)
        {
            item.Id = ApplicationStorage.Items.GetNextId();

            ApplicationStorage.Items.Add(item);

            return item;
        }

        public bool Delete(Item item)
        {
            return ApplicationStorage.Items.Remove(item);
        }

        public IEnumerable<Item> GetAll()
        {
            return ApplicationStorage.Items;
        }

        public Item GetItemById(int id)
        {
            return ApplicationStorage.Items.FirstOrDefault(x => x.Id == id);
        }

        public void Update(int id, Item item)
        {
            if (id != item.Id)
            {
                throw new Exception();
            }

            var updatedItem = GetItemById(id);

            if (updatedItem is null)
            {
                throw new Exception();
            }

            updatedItem = item;
        }

        public IEnumerable<Item> GetItemsByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
