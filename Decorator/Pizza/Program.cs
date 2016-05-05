using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {


            Pizza pizza1 = new MeatPizza();
            Console.WriteLine($"Name: {pizza1.name}");
            Console.WriteLine($"Cost: {pizza1.GetCost()}");
            pizza1 = new PizzaWithPepper(pizza1);
            Console.WriteLine($"Name: {pizza1.name}");
            Console.WriteLine($"Cost: {pizza1.GetCost()}");

            Console.WriteLine("\r\n");

            Pizza pizza2 = new CheseePizza();
            Console.WriteLine($"Name: {pizza2.name}");
            Console.WriteLine($"Cost: {pizza2.GetCost()}");
            pizza2 = new PizzaWithPepperoni(pizza2);
            Console.WriteLine($"Name: {pizza2.name}");
            Console.WriteLine($"Cost: {pizza2.GetCost()}");

            Console.ReadLine();

        }
    }
}
