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
    }
}
