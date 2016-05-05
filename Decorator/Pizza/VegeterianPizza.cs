using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class VegeterianPizza : Pizza
    {

        public VegeterianPizza() : base("Vageterian Pizza"){ }

        public override double GetCost()
        {
            this.cost = 10;
            return cost;
        }

    }
}
