using ConsoleAppThirdPartFirstLecture.Enums;
using ConsoleAppThirdPartFirstLecture.Resources;
using System.Collections.Generic;

namespace ConsoleAppThirdPartFirstLecture.Helpers
{
    public static class Menu
    {
        public static Dictionary<int, string> MainMenu { get; } = new Dictionary<int, string>
        {
            { (int)MainMenuOption.Item, UIResources.ItemsWork },
            { (int)MainMenuOption.Category, UIResources.CategoriesWork },
            { (int)MainMenuOption.About, UIResources.AboutUs },
            { (int)MainMenuOption.Exit, UIResources.Exit },
        };

        public static Dictionary<int, string> BackMenu { get; } = new Dictionary<int, string>
        {
            { (int)BackMenuOption.Back, UIResources.Back },
        };

        public static Dictionary<int, string> ItemOperationsMenu { get; } = new Dictionary<int, string>
        {
            { (int)EntityOperationsMenuOption.Create, string.Format(UIResources.Create, UIResources.Item) },
            { (int)EntityOperationsMenuOption.Delete, string.Format(UIResources.Delete, UIResources.Item) },
            { (int)EntityOperationsMenuOption.Update, string.Format(UIResources.Update, UIResources.Item) },
            { (int)EntityOperationsMenuOption.GetAll, string.Format(UIResources.GetAll, UIResources.Items) },
            { (int)EntityOperationsMenuOption.Back, UIResources.Back },
        };
    }
}
