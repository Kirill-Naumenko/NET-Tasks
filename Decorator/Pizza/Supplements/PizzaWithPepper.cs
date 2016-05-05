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
            this.Name = pizza.Name + " + pepper";
            this.CountOfSupplements += 1;
            Cost = Pizza.Cost += 4;
        }

    }
}
