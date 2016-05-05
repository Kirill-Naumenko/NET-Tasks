using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    abstract class Pizza 
    {

        public string name;// { get; set; }
        public double cost; //{ get; set; }
        public abstract double GetCost();

        public Pizza(string name)
        {
            this.name = name;
        }


       
    }
}
