using ConsoleAppThirdPartFirstLecture.Bll.Services.Interfaces;
using ConsoleAppThirdPartFirstLecture.Common.Models;
using ConsoleAppThirdPartFirstLecture.Dal.Repositories.Interfaces;
using System.Collections.Generic;

namespace ConsoleAppThirdPartFirstLecture.Bll.Services.Implementations
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository itemRepository;

        public ItemService(IItemRepository itemRepository)
        {
            this.itemRepository = itemRepository;
        }

        public Item Create(Item item)
        {
            return itemRepository.Create(item);
        }

        public bool Delete(Item item)
        {
            return itemRepository.Delete(item);
        }

        public IEnumerable<Item> GetAll()
        {
            return itemRepository.GetAll();
        }

        public Item GetItemById(int id)
        {
            return itemRepository.GetItemById(id);
        }

        public IEnumerable<Item> GetItemsByCategoryId(int categoryId)
        {
            return itemRepository.GetItemsByCategoryId(categoryId);
        }

        public void Update(int id, Item item)
        {
            itemRepository.Update(id, item);
        }
    }
}
