using ConsoleAppThirdPartFirstLecture.Common.Models;
using System.Collections.Generic;

namespace ConsoleAppThirdPartFirstLecture.Common.Interfaces
{
    public interface IItemRepository : IRepository<Item>
    {
        IEnumerable<Item> GetItemsByCategoryId(int categoryId);
    }
}
