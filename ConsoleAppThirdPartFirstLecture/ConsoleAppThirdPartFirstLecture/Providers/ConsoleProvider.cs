using ConsoleAppThirdPartFirstLecture.Resources;
using System;
using System.Collections.Generic;

namespace ConsoleAppThirdPartFirstLecture.Providers
{
    public class ConsoleProvider : IUIProvider
    {
        public int GetCommand()
        {
            if(!int.TryParse(Console.ReadLine(), out int result))
            {
                Console.WriteLine(UIResources.ErrorFormat);
            }

            return result;
        }

        public void SendMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowMenu(Dictionary<int, string> menu)
        {
            foreach(var key in menu.Keys)
            {
                Console.WriteLine($"{key}. {menu[key]}");
            }
        }
    }
}
