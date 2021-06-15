using System;

namespace Ex04.Menus.Interfaces
{
    public class OperationalItem : MenuItem
    {
        private readonly IExecute.IExecutableItem r_Operation;

        public OperationalItem(IExecute.IExecutableItem i_Operation, string i_Text, int i_Index) : base(i_Text, i_Index)
        {
            r_Operation = i_Operation;
        }

        public override void MenuItem_Clicked()
        {
            onClick();
        }

        public override void Show()
        {
            r_Operation.Execute();
            Console.WriteLine("Press Enter to go back");
            Console.ReadLine();
        }

        private void onClick()
        {
            this.Notify();
        }
    }
}
