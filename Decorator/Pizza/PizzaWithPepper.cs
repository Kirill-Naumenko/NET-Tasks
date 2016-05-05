using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class PizzaWithPepper : PizzaWithSupplements
    {
        public PizzaWithPepper(Pizza pizza) : base(pizza)
        {
            this.name = pizza.name + " + pepper";
        }

        public override double GetCost()
        {
            cost = pizza.cost += 4;
            return this.cost;
        }
    
    }
}
