using ConsoleAppThirdPartFirstLecture.Common.Models;
using ConsoleAppThirdPartFirstLecture.Models;
using System.Collections.Generic;

namespace ConsoleAppThirdPartFirstLecture.Providers
{
    public interface IUIProvider
    {
        List<int> State { get; }

        void GetCommand();

        void ShowPage(PageViewModel model);

        void ShowMenu(Dictionary<int, string> menu);

        void ShowMessage(string message);

        string GetText(string message);

        int GetIntData(string message);

        void UIClear();

        void ShowItems(IEnumerable<Item> items);
    }
}
