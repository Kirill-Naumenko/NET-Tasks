using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Pepper : PizzaWithSupplements
    {
        public Pepper(Pizza pizza) : base(pizza)
        {
            this.Name = pizza.Name + " + pepper";
            CountOfSupplements += 1;
            Cost = Pizza.Cost += 4;
            if (CountOfSupplements > 2)
            {
                this.Cost -= Cost * 0.05;
            }
        }

    }
}
