using ConsoleAppThirdPartFirstLecture.Bll.Services.Implementations;
using ConsoleAppThirdPartFirstLecture.Bll.Services.Interfaces;
using ConsoleAppThirdPartFirstLecture.Common.Interfaces;
using ConsoleAppThirdPartFirstLecture.JsonDal.Repositories;
//using ConsoleAppThirdPartFirstLecture.Dal.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleAppThirdPartFirstLecture.Di
{
    public static class IoC
    {
        public static void BuildIoC(this IServiceCollection services)
        {
            // Repositories
            services.AddSingleton<ICategoryRepository, CategoryRepository>();
            services.AddSingleton<IItemRepository, ItemRepository>();

            // Services
            services.AddSingleton<ICategoryService, CategoryService>();
            services.AddSingleton<IItemService, ItemService>();
        }
    }
}
