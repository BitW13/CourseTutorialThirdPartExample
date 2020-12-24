using ConsoleAppThirdPartFirstLecture.Bll.Services.Interfaces;
using ConsoleAppThirdPartFirstLecture.Common.Models;
using ConsoleAppThirdPartFirstLecture.Dal.Repositories.Interfaces;
using System.Collections.Generic;

namespace ConsoleAppThirdPartFirstLecture.Bll.Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public Category Create(Category item)
        {
            return categoryRepository.Create(item);
        }

        public bool Delete(Category item)
        {
            return categoryRepository.Delete(item);
        }

        public IEnumerable<Category> GetAll()
        {
            return categoryRepository.GetAll();
        }

        public Category GetItemById(int id)
        {
            return categoryRepository.GetItemById(id);
        }

        public void Update(int id, Category item)
        {
            categoryRepository.Update(id, item);
        }
    }
}
