using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MenuWindow : MenuItem, IObserver.IListener
    {
        private static int s_LevelCounter = 0;
        private readonly List<MenuItem> r_Menu = new List<MenuItem>();

        public MenuWindow(string i_Text, int i_Index) : base(i_Text, i_Index)
        { 
            if (i_Index != 0)
            {
                OperationalItem backMenuItem = new OperationalItem(new BackToLastMenu(), "Back", 0);
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
            i_MenuItem.ListenersList.Add(this);
        }

        public MenuWindow AddSubMenu(string i_Text, int i_Index)
        {
            MenuWindow newMenu = new MenuWindow(i_Text, i_Index);
            AddMenuItem(newMenu);

            return newMenu;
        }

        public void AddOperation(IExecute.IExecutableItem i_Operation, string i_Text, int i_Index)
        {
            OperationalItem newOperation = new OperationalItem(i_Operation, i_Text, i_Index);
            AddMenuItem(newOperation);
        }

        public override void MenuItem_Clicked()
        {
            onClick();
        }
     
        void IObserver.IListener.Update(MenuItem i_MenuItem)
        {
            Console.Clear();
            i_MenuItem.Show();
        }
        // $G$ NTT-999 (-5) You should have user StringBuilder here
        public override void Show()
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

        private void onClick()
        {
            this.Notify();
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

        internal class BackToLastMenu : IExecute.IExecutableItem
        {
            public void Execute()
            {
                Console.Clear();
            }
        }
    }  
}