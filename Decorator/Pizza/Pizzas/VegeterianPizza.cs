using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class VegeterianPizza : Pizza
    {

        public VegeterianPizza() : base("Vageterian Pizza")
        {
            this.Cost = 10;
  
        }
        public override double GetCost()
        {
            return this.Cost;
        }

    }
}
