using ConsoleAppThirdPartFirstLecture.Common.Models;
using System.Collections.Generic;

namespace ConsoleAppThirdPartFirstLecture.Dal.Storages
{
    public static class ApplicationStorage
    {
        public static List<Category> Categories { get; set; }

        public static List<Item> Items { get; set; }

        public static List<ItemCategory> ItemCategories { get; set; }

        static ApplicationStorage()
        {
            Categories = new List<Category>();
            Items = new List<Item>
            {
                new Item()
                {
                    Id = 1,
                    Name = "name",
                    Description = "description",
                }
            };
            ItemCategories = new List<ItemCategory>();
        }
    }
}
