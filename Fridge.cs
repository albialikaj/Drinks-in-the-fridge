using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softdrinks
{
    class Fridge
    {
        public List<IFridge> AllDrinks = new List<IFridge>();
    }




    interface IFridge {
        void OutputFridge();

    }
}
