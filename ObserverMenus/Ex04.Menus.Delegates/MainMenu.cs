using System;

namespace Ex04.Menus.Delegates
{
    public class MainMenu : MenuWindow
    {
        public MainMenu(string i_Text) : base(i_Text, 0)
        {
            MenuItem exitMenuItem = new MenuItem("Exit", 0);
            this.Menu.Add(exitMenuItem); 
        }
    }
}
