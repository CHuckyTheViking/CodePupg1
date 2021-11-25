using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePupg1.MainMenu
{
    class MainMenu : IMainMenu
    {
        public string Title { get; set; }

        public List<IMainMenuItem> mainMenuItems { get; set; }

    }
}
