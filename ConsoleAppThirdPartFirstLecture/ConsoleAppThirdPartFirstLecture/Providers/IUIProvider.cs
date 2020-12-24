using System.Collections.Generic;

namespace ConsoleAppThirdPartFirstLecture.Providers
{
    public interface IUIProvider
    {
        void SendMessage(string message);

        int GetCommand();

        void ShowMenu(Dictionary<int, string> menu);
    }
}
