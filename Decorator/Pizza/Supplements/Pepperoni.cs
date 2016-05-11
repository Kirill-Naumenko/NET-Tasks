using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Pepperoni : PizzaWithSupplements
    {
        public Pepperoni(Pizza pizza) : base(pizza)
        {
            this.Name = pizza.Name + " + pepperoni";
            CountOfSupplements += 1;
            Cost = Pizza.Cost += 2;
            if (CountOfSupplements > 2)
            {
                this.Cost -= Cost * 0.05;
            }
        }


    }
}
