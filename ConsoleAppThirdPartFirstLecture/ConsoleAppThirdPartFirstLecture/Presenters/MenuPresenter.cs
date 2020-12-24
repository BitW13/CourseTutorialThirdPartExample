using ConsoleAppThirdPartFirstLecture.Enums;
using ConsoleAppThirdPartFirstLecture.Resources;
using System.Collections.Generic;

namespace ConsoleAppThirdPartFirstLecture.Presenters
{
    internal class MenuPresenter : IMenuPresenter
    {
        public Dictionary<int, string> GetMainMenu()
        {
            return new Dictionary<int, string>
            {
                { (int)MainMenuOption.Item, UIResources.ItemsWork },
                { (int)MainMenuOption.Category, UIResources.CategoriesWork },
                { (int)MainMenuOption.Exit, UIResources.Exit },
            };
        }

        public Dictionary<int, string> GetEntityMenu(string entityName)
        {
            return new Dictionary<int, string>
            {
                { (int)EntityMenuOption.Create, string.Format(UIResources.Create, entityName) },
                { (int)EntityMenuOption.Edit, string.Format(UIResources.Edit, entityName) },
                { (int)EntityMenuOption.Update, string.Format(UIResources.Update, entityName) },
                { (int)EntityMenuOption.Delete, string.Format(UIResources.Delete, entityName) },
                { (int)EntityMenuOption.Edit, string.Format(UIResources.Exit, entityName) },
            }
        }
    }
}
