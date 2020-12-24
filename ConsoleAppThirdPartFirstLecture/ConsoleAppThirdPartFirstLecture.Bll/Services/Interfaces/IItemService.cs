using ConsoleAppThirdPartFirstLecture.Common.Models;
using System.Collections.Generic;

namespace ConsoleAppThirdPartFirstLecture.Bll.Services.Interfaces
{
    public interface IItemService : IService<Item>
    {
        IEnumerable<Item> GetItemsByCategoryId(int categoryId);
    }
}
