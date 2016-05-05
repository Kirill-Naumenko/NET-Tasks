using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class PizzaWithMushrooms : PizzaWithSupplements
    {
        public PizzaWithMushrooms(Pizza pizza) : base(pizza)
        {
            this.name = pizza.name + " + mushrooms";
        }

        public override double GetCost()
        {
            cost = pizza.cost += 3;
            return this.cost;
        }
    }
}
