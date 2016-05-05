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
            this.Name = pizza.Name + " + pepperoni";
            this.CountOfSupplements += 1;
            Cost = Pizza.Cost += 2;
        }


    }
}
