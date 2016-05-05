using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class PizzaWithPepperoni : PizzaWithSupplements
    {
        public PizzaWithPepperoni(Pizza pizza) : base(pizza)
        {
            this.name = pizza.name + " + pepperoni";
        }

        public override double GetCost()
        {
            cost = pizza.cost += 2;
            return this.cost;
        }
    
    }
}
