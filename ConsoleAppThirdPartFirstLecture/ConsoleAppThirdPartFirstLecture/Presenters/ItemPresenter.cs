using ConsoleAppThirdPartFirstLecture.Attributes;
using ConsoleAppThirdPartFirstLecture.Common.Models;
using ConsoleAppThirdPartFirstLecture.Helpers;
using ConsoleAppThirdPartFirstLecture.Models;
using ConsoleAppThirdPartFirstLecture.Providers;
using ConsoleAppThirdPartFirstLecture.Resources;

namespace ConsoleAppThirdPartFirstLecture.Presenters
{
    public class ItemPresenter : IItemPresenter
    {
        private readonly IUIProvider provider;

        public ItemPresenter(IUIProvider provider)
        {
            this.provider = provider;
        }

        [RouteMap(0, 1)]
        public void ShowItemMenu()
        {
            provider.ShowPage(new PageViewModel
            {
                Header = UIResources.ItemHeader,
                Menu = Menu.ItemOperationsMenu,
            });
        }

        [RouteMap(0, 1, 1)]
        public void CreateItem()
        {
            var model = new Item
            {
                Name = provider.GetText(UIResources.EnterItemName),
                Description = provider.GetText(UIResources.EnterDescriptionName),
                Length = provider.GetIntData(UIResources.EnterItemLength),
            };

            provider.ShowPage(new PageViewModel
            {
                Header = UIResources.ItemHeader,
                Menu = Menu.ItemOperationsMenu,
            });
        }
    }
}
