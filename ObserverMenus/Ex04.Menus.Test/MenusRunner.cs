using System;
using Ex04.Menus;

namespace Ex04.Menus.Test
{
    public class MenusRunner
    {
        private static readonly Interfaces.MainMenu sr_InterfaceMenu = new Interfaces.MainMenu("My Interface Main Menu");
        private static readonly Delegates.MainMenu sr_DelegateMenu = new Delegates.MainMenu("My Delegate Main Menu");

        public static void Run()
        {
            Interfaces.MenuWindow dateTimeInterfaceMenu = sr_InterfaceMenu.AddSubMenu("Version and Spaces", 1);
            dateTimeInterfaceMenu.AddOperation(new ShowVersionOperation(), "Show version", 1);
            dateTimeInterfaceMenu.AddOperation(new SpacesCounter(), "Count spaces in sentence", 2);

            Interfaces.MenuWindow versionAndActionsInterfaceMenu = sr_InterfaceMenu.AddSubMenu("Show Date / Time", 2);
            versionAndActionsInterfaceMenu.AddOperation(new ShowDate(), "Show current date", 1);
            versionAndActionsInterfaceMenu.AddOperation(new ShowTime(), "Show current time", 2);

            sr_InterfaceMenu.Show();

            Console.Clear();

            Delegates.MenuWindow dateTimeDelegateMenu = sr_DelegateMenu.AddSubMenu("Version and Spaces", 1);
            dateTimeDelegateMenu.AddOperation(new ShowVersionOperation().Execute, "Show version", 1);
            dateTimeDelegateMenu.AddOperation(new SpacesCounter().Execute, "Count spaces in sentence", 2);

            Delegates.MenuWindow versionAndActionsDelegateMenu = sr_DelegateMenu.AddSubMenu("Show Date / Time", 2);
            versionAndActionsDelegateMenu.AddOperation(new ShowDate().Execute, "Show current date", 1);
            versionAndActionsDelegateMenu.AddOperation(new ShowTime().Execute, "Show current time", 2);

            sr_DelegateMenu.Show();
        }
    }
}
