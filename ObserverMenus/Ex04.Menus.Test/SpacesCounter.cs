using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class SpacesCounter : IExecute.IExecutableItem
    {
        public void Execute()
        {
            Console.WriteLine("Please enter your sentence below:");
            string userInput = Console.ReadLine();
            int spaceCount = 0;
            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] == 32)
                {
                    spaceCount++;
                }
            }

            Console.WriteLine(string.Format("The number of spaces in the sentence is: {0}", spaceCount));
        }
    }
}
