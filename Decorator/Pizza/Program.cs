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
            Chooser chooser = new Chooser();
            Pizza pizza;
            int countOfSupplemments;



            pizza = chooser.ChoosePizza();
           

        label1: pizza = chooser.ChooseSupplements(pizza);
            if (chooser.AskAboutMoreSupplements())
            {
                goto label1;
            }
            else
            {
                Console.WriteLine("Your pizza");
                Console.WriteLine($"Name: {pizza.Name}");
                Console.WriteLine($"Cost: {pizza.Cost}");
            }
           

            Console.ReadLine();

        }
    }
}
