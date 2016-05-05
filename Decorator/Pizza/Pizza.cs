using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public abstract class Pizza 
    {

        public string Name;// { get; set; }
        public double Cost; //{ get; set; }
        public int CountOfSupplements;
        //public abstract double GetCost();

        public Pizza(string name)
        {
            this.Name = name;
        }


       
    }
}
