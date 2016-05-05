using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class CheseePizza : Pizza
    {
        public CheseePizza() : base("Chesee Pizza"){ }

        public override double GetCost()
        {
            this.cost = 7;
            return cost;
        }

    }
}
