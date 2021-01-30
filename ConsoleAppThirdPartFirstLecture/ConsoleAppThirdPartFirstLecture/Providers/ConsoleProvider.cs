using ConsoleAppThirdPartFirstLecture.Common.Models;
using ConsoleAppThirdPartFirstLecture.Enums;
using ConsoleAppThirdPartFirstLecture.Models;
using ConsoleAppThirdPartFirstLecture.Resources;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppThirdPartFirstLecture.Providers
{
    public class ConsoleProvider : IUIProvider
    {
        public List<int> State { get; private set; }

        public PageViewModel CurrentPage { get; private set; }

        private const int MainMenuState = 0;
        private const int ExitState = -1;

        private int selectedMenuKey;

        public ConsoleProvider()
        {
            State = new List<int> { MainMenuState };
            CurrentPage = new PageViewModel();
        }

        public void GetCommand()
        {
            var key = Console.ReadKey().Key;

            while (key != ConsoleKey.Enter)
            {
                UIClear();
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        SetUpState();
                        break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        SetDownState();
                        break;
                }
                ShowCurrentPage();
                key = Console.ReadKey().Key;
            }

            if (selectedMenuKey == (int)BackMenuOption.Back)
            {
                if(State.Count > 1)
                {
                    State.Remove(State.Last());
                }
                else
                {
                    State = new List<int> { ExitState };
                }
            }
            else
            {
                State.Add(selectedMenuKey);
            }
        }

        public void ShowPage(PageViewModel model)
        {
            CurrentPage = model;
            selectedMenuKey = CurrentPage.Menu.Keys.First();
            ShowCurrentPage();
        }

        public void ShowItems(IEnumerable<Item> items)
        {
            foreach(var item in items)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Description);
                Console.WriteLine(item.Length);
            }
        }

        public void ShowMenu(Dictionary<int, string> menu)
        {
            CurrentPage.Menu = menu;
            selectedMenuKey = CurrentPage.Menu.Keys.First();

            ShowMenuWithSelectedState(menu, selectedMenuKey);
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        public string GetText(string message)
        {
            Console.Write(message);
            SetSelectedItemConsoleColor();
            var result = Console.ReadLine();
            SetUnselectedItemConsoleColor();

            return result;
        }

        public int GetIntData(string message)
        {
            Console.Write(message);
            SetSelectedItemConsoleColor();
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                SetUnselectedItemConsoleColor();
                Console.WriteLine(UIResources.ErrorFormat);
                Console.Write(message);
                SetSelectedItemConsoleColor();
            }
            SetUnselectedItemConsoleColor();

            return result;
        }

        public void UIClear()
        {
            Console.Clear();
        }

        private void ShowCurrentPage()
        {
            UIClear();
            if (!string.IsNullOrEmpty(CurrentPage.Header))
            {
                ShowMessage(CurrentPage.Header);
            }

            ShowMenuWithSelectedState(CurrentPage.Menu, selectedMenuKey);

            if (!string.IsNullOrEmpty(CurrentPage.Footer))
            {
                ShowMessage(CurrentPage.Footer);
            }
        }

        private static void ShowMenuWithSelectedState(Dictionary<int, string> menu, int state)
        {
            foreach (var key in menu.Keys)
            {
                if(key == state)
                {
                    SetSelectedItemConsoleColor();
                    Console.WriteLine($"{key}. {menu[key]}");
                    SetUnselectedItemConsoleColor();
                }
                else
                {
                    Console.WriteLine($"{key}. {menu[key]}");
                }
            }
        }

        private void SetUpState()
        {
            var keys = CurrentPage.Menu.Keys.ToList();
            var index = keys.IndexOf(selectedMenuKey);

            if(index != 0)
            {
                selectedMenuKey = keys[index - 1];
            }
        }

        private void SetDownState()
        {
            var keys = CurrentPage.Menu.Keys.ToList();
            var index = keys.IndexOf(selectedMenuKey);

            if(index != keys.Count - 1)
            {
                selectedMenuKey = keys[index + 1];
            }
        }

        private static void SetSelectedItemConsoleColor()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        private static void SetUnselectedItemConsoleColor()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
    }
}
