using System;

namespace CodePupg1.MainMenu
{
    public interface IMainMenuManager
    {
        void CreateMainMenu(string title);
        void CreateMainMenuItem(int selector, string name, Action runThis);
        public IMainMenu GetMainMenu();
        void ShowMainMenu();
    }
}