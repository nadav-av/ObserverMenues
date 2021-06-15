using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class IObserver
    {
        public interface IListener
        {
            void Update(MenuItem i_PassingParameter);
        }
    }
}
