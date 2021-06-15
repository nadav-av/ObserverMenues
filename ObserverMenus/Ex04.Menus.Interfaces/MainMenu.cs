using System;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu : MenuWindow
    {
        public MainMenu(string i_Text) : base(i_Text, 0) 
        {
            OperationalItem exitMenuItem = new OperationalItem(new ExitMainMenu(), "Exit", 0);
            this.Menu.Add(exitMenuItem);
        }

        internal class ExitMainMenu : IExecute.IExecutableItem
        {
            public void Execute()
            {
                Console.Clear();
            }
        }
    }
}
