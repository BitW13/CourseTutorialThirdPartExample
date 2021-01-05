using ConsoleAppThirdPartFirstLecture.Di;
using ConsoleAppThirdPartFirstLecture.Notifiers;
using ConsoleAppThirdPartFirstLecture.Presenters;
using ConsoleAppThirdPartFirstLecture.Providers;
using ConsoleAppThirdPartFirstLecture.Routes;
using ConsoleAppThirdPartFirstLecture.Runners;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ConsoleAppThirdPartFirstLecture.Registers
{
    public static class UIRegistry
    {
        public static void Build(this IServiceCollection services)
        {
            services.AddHostedService<Startup>();
            services.Configure<ConsoleLifetimeOptions>(opts => opts.SuppressStatusMessages = true);
            IoC.Build();
            services.AddSingleton<IUIProvider, ConsoleProvider>();
            services.AddSingleton<INotifier, ConsoleNotifier>();
            services.AddSingleton<IMainMenuPresenter, MainMenuPresenter>();
            services.AddSingleton<IItemPresenter, ItemPresenter>();
            services.AddSingleton<IRouter, ConsoleRouter>();
            services.AddSingleton<IRunner, ConsoleRunner>();
        }
    }
}
