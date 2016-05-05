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
            this.Name = pizza.Name + " + mushrooms";
            this.CountOfSupplements += 1;
            Cost = Pizza.Cost += 3;
        }
    
    }
}
