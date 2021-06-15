using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class Menu
    {
        private List<MenuItem> m_itemsList = new List<MenuItem>();


        public List<MenuItem> MenuList
        {
            get
            {
                return m_itemsList;
            }
        }

        public void AddItemToMenu(MenuItem i_ItemToAdd)
        {
            this.m_itemsList.Add(i_ItemToAdd);
        }


    }
}
