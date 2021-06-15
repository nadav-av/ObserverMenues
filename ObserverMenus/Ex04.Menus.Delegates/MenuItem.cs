using System;

namespace Ex04.Menus.Delegates
{
    public class MenuItem
    {
        private string m_Text;
        private int m_Index;

        public MenuItem(string i_Text, int i_Index)
        {
            Text = i_Text;
            Index = i_Index;
        }

        public event Action Clicked = null;

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

        public void MenuItem_Clicked()
        {
            Console.Clear();
            OnClicked();

            if (!(this is MenuWindow))
            {
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
            }
        }

        public override string ToString()
        {
            string itemPrint = string.Format(
 @"{0}. {1}",
              this.Index,
              this.Text);

            return itemPrint;
        }

        protected virtual void OnClicked()
        {
            if (Clicked != null)
            {
                Clicked.Invoke();
            }
        }
    }
}
