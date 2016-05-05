using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    abstract class PizzaWithSupplements : Pizza
    {
        public Pizza pizza;

        public PizzaWithSupplements(Pizza pizza) : base(pizza.name)
        {
            this.pizza = pizza;
        }
    }
}
