using System.Collections.Generic;

namespace ConsoleAppThirdPartFirstLecture.Presenters
{
    internal interface IMenuPresenter
    {
        Dictionary<int, string> GetMainMenu();

        Dictionary<int, string> GetEntityMenu(string entityName);
    }
}
