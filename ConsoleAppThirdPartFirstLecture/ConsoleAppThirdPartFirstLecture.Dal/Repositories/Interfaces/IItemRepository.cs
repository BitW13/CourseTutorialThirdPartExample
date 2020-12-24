using ConsoleAppThirdPartFirstLecture.Common.Models;
using System.Collections.Generic;

namespace ConsoleAppThirdPartFirstLecture.Dal.Repositories.Interfaces
{
    public interface IItemRepository : IRepository<Item>
    {
        IEnumerable<Item> GetItemsByCategoryId(int categoryId);
    }
}
