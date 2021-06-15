using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public class MenuWindow : MenuItem
    {
        private static int s_LevelCounter = 0;
        private readonly List<MenuItem> r_Menu = new List<MenuItem>();

        public MenuWindow(string i_Text, int i_Index) : base(i_Text, i_Index)
        {
            if (i_Index != 0)
            {
                MenuItem backMenuItem = new MenuItem("Back", 0);
                this.Menu.Add(backMenuItem);
            }
        }

        public List<MenuItem> Menu
        {
            get { return r_Menu; }
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            r_Menu.Add(i_MenuItem);
        }

        public MenuWindow AddSubMenu(string i_Text, int i_Index)
        {
            MenuWindow newMenu = new MenuWindow(i_Text, i_Index);
            newMenu.Clicked += new Action(newMenu.Show);
            AddMenuItem(newMenu);
            return newMenu;
        }

        public void AddOperation(Action i_FunctionToInvoke, string i_Text, int i_Index)
        {
            MenuItem newOperation = new MenuItem(i_Text, i_Index);
            newOperation.Clicked += i_FunctionToInvoke;
            AddMenuItem(newOperation);
        }
        // $G$ NTT-999 (-5) You should have user StringBuilder here
        public void Show()
        {
            s_LevelCounter++;
            bool menuRunning = true;

            while (menuRunning)
            {
                Console.Clear();
                Console.WriteLine("Level number: {0}", s_LevelCounter);
                foreach (MenuItem item in Menu)
                {
                    Console.WriteLine(item);
                }

                int userInput = this.getItemChoice();
                if (userInput != 0)
                {
                    r_Menu[userInput].MenuItem_Clicked();
                }
                else
                {
                    menuRunning = false;
                }
            }

            s_LevelCounter--;
        }

        private int getItemChoice()
        {
            bool validChoice = false;
            Console.WriteLine("Please choose one of the options");
            int chosenItem = -1;
            while (!validChoice)
            {
                string userInput = Console.ReadLine();
                bool isNumber = int.TryParse(userInput, out chosenItem);

                if (isNumber && chosenItem >= 0 && chosenItem < this.r_Menu.Count)
                {
                    validChoice = true;
                }
                else
                {
                    Console.WriteLine("Invalid input, please choose again.");
                }
            }

            return chosenItem;
        }
    }
}
