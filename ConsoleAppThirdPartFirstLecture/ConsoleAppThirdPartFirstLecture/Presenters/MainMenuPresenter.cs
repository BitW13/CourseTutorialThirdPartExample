using ConsoleAppThirdPartFirstLecture.Attributes;
using ConsoleAppThirdPartFirstLecture.Helpers;
using ConsoleAppThirdPartFirstLecture.Models;
using ConsoleAppThirdPartFirstLecture.Providers;
using ConsoleAppThirdPartFirstLecture.Resources;
using System;

namespace ConsoleAppThirdPartFirstLecture.Presenters
{
    public class MainMenuPresenter : IMainMenuPresenter
    {
        private readonly IUIProvider provider;

        public MainMenuPresenter(IUIProvider provider)
        {
            this.provider = provider;
        }

        [RouteMap(0)]
        public void ShowMainMenuWithGreeting()
        {
            provider.ShowPage(new PageViewModel
            {
                Header = UIResources.Greeting,
                Menu = Menu.MainMenu,
            });
        }

        [RouteMap(0, 3)]
        public void ShowAboutUs()
        {
            provider.ShowPage(new PageViewModel
            {
                Header = UIResources.AboutUsMessage,
                Menu = Menu.BackMenu,
            });
        }

        // todo: to think, how to close application without Environment.Exit(0)
        [RouteMap(-1)]
        public void Close()
        {
            Environment.Exit(0);
        }
    }
}
