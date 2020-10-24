using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softdrinks
{
    abstract class Product
    {
        //only properties & methods can be abstract (not fields)
        public abstract string Name { get; set; }
        public abstract string Type { get; set; }
   
        public abstract decimal Price { get; set; }
        public abstract void ShowDetails();
        public abstract void PriceGreaterThan_08m(bool a);

    }



    
}
