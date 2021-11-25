using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePupg1.MainMenu
{
    class MainMenuItem : IMainMenuItem
    {
        public int Selector { get; set; }

        public string Name { get; set; }

        public Action RunThis { get; set; }


        public MainMenuItem(int selector, string name, Action runThis)
        {
            Selector = selector;
            Name = name;
            RunThis = runThis;
        }

    }
}
