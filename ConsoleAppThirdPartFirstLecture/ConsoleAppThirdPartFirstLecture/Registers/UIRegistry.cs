using ConsoleAppThirdPartFirstLecture.Presenters;
using ConsoleAppThirdPartFirstLecture.Providers;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleAppThirdPartFirstLecture.Registers
{
    public static class UIRegistry
    {
        public static void Build(this IServiceCollection services)
        {
            services.AddSingleton<IUIProvider, ConsoleProvider>();
            services.AddSingleton<IMenuPresenter, MenuPresenter>();
        }
    }
}
