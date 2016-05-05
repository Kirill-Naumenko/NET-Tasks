using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class CheseePizza : Pizza
    {
        public CheseePizza() : base("Chesee Pizza")
        {
            this.Cost = 7;
            if (CountOfSupplements > 2)
            {
                this.Cost-= Cost * 0.05;
            }
       
        }

    }
}
