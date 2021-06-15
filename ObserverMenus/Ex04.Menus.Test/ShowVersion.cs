using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class ShowVersionOperation : IExecute.IExecutableItem
    {
        private const string k_CurrentVersion = "Version: 21.1.4.8930";

        public void Execute()
        {
            Console.WriteLine(k_CurrentVersion);
        }
    }
}
