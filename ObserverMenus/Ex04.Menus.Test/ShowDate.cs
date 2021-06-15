using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class ShowDate : IExecute.IExecutableItem
    {
        public void Execute()
        {
           Console.WriteLine(DateTime.Today.ToShortDateString());
        }
    }
}
