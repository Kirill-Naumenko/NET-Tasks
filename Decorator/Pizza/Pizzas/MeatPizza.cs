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
            
        }
        public override double GetCost()
        {
            return this.Cost;
        }

    }
}
