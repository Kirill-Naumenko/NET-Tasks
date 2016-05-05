using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class MeatPizza : Pizza 
    {

        public MeatPizza() : base("Meat Pizza"){}

        public override double GetCost()
        {
            this.cost = 5;
            return cost;
        }
    }
}
