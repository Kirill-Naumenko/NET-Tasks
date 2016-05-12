using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Mushrooms : PizzaWithSupplements
    {
        public Mushrooms(Pizza pizza) : base(pizza)
        {
            this.Name = pizza.Name + " + mushrooms";
            CountOfSupplements += 1;
            Cost = Pizza.Cost += 3;
            
        }
    
    }
}
