using ConsoleAppThirdPartFirstLecture.Bll.Services.Interfaces;
using ConsoleAppThirdPartFirstLecture.Common.Models;
using ConsoleAppThirdPartFirstLecture.Di;
using ConsoleAppThirdPartFirstLecture.Enums;
using ConsoleAppThirdPartFirstLecture.Presenters;
using ConsoleAppThirdPartFirstLecture.Providers;
using ConsoleAppThirdPartFirstLecture.Registers;
using ConsoleAppThirdPartFirstLecture.Resources;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ConsoleAppThirdPartFirstLecture
{
    class Program
    {
        private static readonly IServiceProvider container;

        private static readonly ICategoryService categoryService;
        private static readonly IItemService itemService;

        private static readonly IUIProvider provider;
        private static readonly IMenuPresenter presenter;

        static Program()
        {
            var services =  IoC.Build();
            services.Build();

            container = services.BuildServiceProvider();

            categoryService = (ICategoryService)container.GetService(typeof(ICategoryService));
            itemService = (IItemService)container.GetService(typeof(IItemService));
            provider = (IUIProvider)container.GetService(typeof(IUIProvider));
            presenter = (IMenuPresenter)container.GetService(typeof(IMenuPresenter));
        }

        static void Main(string[] args)
        {
            provider.SendMessage(UIResources.Greeting);
        }
    }
}
