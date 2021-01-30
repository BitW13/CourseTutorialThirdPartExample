using ConsoleAppThirdPartFirstLecture.Attributes;
using ConsoleAppThirdPartFirstLecture.Bll.Services.Interfaces;
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
        private readonly IItemService service;

        public ItemPresenter(IUIProvider provider, IItemService service)
        {
            this.provider = provider;
            this.service = service;
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

            service.Create(model);

            ShowItemMenu();
        }

        [RouteMap(0, 1, 3)]
        public void GetAll()
        {
            var models = service.GetAll();

            provider.ShowItems(models);
        }
    }
}
