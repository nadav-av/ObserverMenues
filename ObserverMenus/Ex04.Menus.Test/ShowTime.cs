﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class ShowTime : IExecute.IExecutableItem
    {
        public void Execute()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
        }
    }
}
