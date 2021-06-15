using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem : ISubject.INotifier
    {
        private readonly List<IObserver.IListener> r_ListenersList = new List<IObserver.IListener>();
        private string m_Text;
        private int m_Index;

        public MenuItem(string i_Text, int i_Index)
        {
            Text = i_Text;
            Index = i_Index;
        }

        public string Text
        {
            get { return m_Text; }
            set { m_Text = value; }
        }

        public int Index
        {
            get { return m_Index; }
            set { m_Index = value; }
        }

        public List<IObserver.IListener> ListenersList
        {
            get { return r_ListenersList; }
        }

        public void Notify()
        {
            foreach (IObserver.IListener listener in r_ListenersList)
            {
                listener.Update(this);
            }
        }

        public abstract void MenuItem_Clicked();

        public abstract void Show();

        public void PrintItem()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            string itemPrint = string.Format(
 @"{0}. {1}",
              this.Index,
              this.Text);

            return itemPrint;
        }
    }
}
