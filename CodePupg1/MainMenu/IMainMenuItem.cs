using System;

namespace CodePupg1.MainMenu
{
    public interface IMainMenuItem
    {
        string Name { get; set; }
        Action RunThis { get; set; }
        int Selector { get; set; }
    }
}