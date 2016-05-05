using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class MeatPizza : Pizza 
    {

        public MeatPizza() : base("Meat Pizza")
        {
            this.Cost = 5;
            if (CountOfSupplements > 2)
            {
                 this.Cost-= Cost * 0.05;
            }

        }
      
    }
}
