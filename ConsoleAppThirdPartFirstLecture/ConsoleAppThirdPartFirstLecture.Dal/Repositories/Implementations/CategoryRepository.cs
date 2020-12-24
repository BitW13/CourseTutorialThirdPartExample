using ConsoleAppThirdPartFirstLecture.Common.Extensions;
using ConsoleAppThirdPartFirstLecture.Common.Models;
using ConsoleAppThirdPartFirstLecture.Dal.Repositories.Interfaces;
using ConsoleAppThirdPartFirstLecture.Dal.Storages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppThirdPartFirstLecture.Dal.Repositories.Implementations
{
    public class CategoryRepository : ICategoryRepository
    {
        public Category Create(Category item)
        {
            item.Id = ApplicationStorage.Categories.GetNextId();

            ApplicationStorage.Categories.Add(item);

            return item;
        }

        public bool Delete(Category item)
        {
            return ApplicationStorage.Categories.Remove(item);
        }

        public IEnumerable<Category> GetAll()
        {
            return ApplicationStorage.Categories;
        }

        public Category GetItemById(int id)
        {
            return ApplicationStorage.Categories.FirstOrDefault(x => x.Id == id);
        }

        public void Update(int id, Category item)
        {
            if(id != item.Id)
            {
                throw new Exception();
            }

            var updatedItem = GetItemById(id);

            if(updatedItem is null)
            {
                throw new Exception();
            }

            updatedItem = item;
        }
    }
}
