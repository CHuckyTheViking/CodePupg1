using System.Collections.Generic;

namespace CodePupg1.MainMenu
{
    public interface IMainMenu
    {
        List<IMainMenuItem> mainMenuItems { get; set; }
        string Title { get; set; }
    }
}