using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePupg1.MainMenu
{
    class MainMenuManager : IMainMenuManager
    {

        private IMainMenu MainMenu;
        private Func<int, string, Action, IMainMenuItem> MainMenuItemFactory;

        public MainMenuManager(IMainMenu mainMenu, Func<int, string, Action, IMainMenuItem> mainMenuItemFactory)
        {
            MainMenu = mainMenu;
            MainMenuItemFactory = mainMenuItemFactory;
        }

        public void CreateMainMenu(string title)
        {
            MainMenu.Title = title;
            MainMenu.mainMenuItems = new();
        }

        public void CreateMainMenuItem(int selector, string name, Action runThis)
        {
            MainMenu.mainMenuItems.Add(MainMenuItemFactory(selector, name, runThis));
        }

        public void ShowMainMenu()
        {
            Console.WriteLine(MainMenu.Title);

            foreach (var menuItem in MainMenu.mainMenuItems)
            {
                Console.WriteLine(menuItem.Selector + ": " + menuItem.Name);
            }

        }

        public IMainMenu GetMainMenu()
        {
            return MainMenu;
        }
    }
}
