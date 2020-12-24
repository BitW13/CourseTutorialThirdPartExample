using ConsoleAppThirdPartFirstLecture.Bll.Services.Implementations;
using ConsoleAppThirdPartFirstLecture.Bll.Services.Interfaces;
using ConsoleAppThirdPartFirstLecture.Dal.Repositories.Implementations;
using ConsoleAppThirdPartFirstLecture.Dal.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleAppThirdPartFirstLecture.Di
{
    public static class IoC
    {
        public static IServiceCollection Build()
        {
            var services = new ServiceCollection();

            // Repositories
            services.AddSingleton<ICategoryRepository, CategoryRepository>();
            services.AddSingleton<IItemRepository, ItemRepository>();

            // Services
            services.AddSingleton<ICategoryService, CategoryService>();
            services.AddSingleton<IItemService, ItemService>();

            return services;
        }
    }
}
