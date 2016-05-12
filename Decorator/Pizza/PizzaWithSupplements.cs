using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    abstract class PizzaWithSupplements : Pizza
    {
        public Pizza Pizza;

        public PizzaWithSupplements(Pizza pizza) : base(pizza.Name)
        {
            this.Pizza = pizza;
            
        }

        public override double GetCost()
        {
            if (CountOfSupplements > 2)
            {

                return Math.Round( (this.Cost -= Cost * 0.05),2);
            }
            return this.Cost;
        }
    }
}
