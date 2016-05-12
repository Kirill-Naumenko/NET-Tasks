using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public class Chooser
    {
        private int choose;
        public  Pizza Pizza;


        public Pizza ChoosePizza()
        {
            while (true)
            {
                Console.WriteLine("IF YOU ADD MORE THAN 2 INGRIDIENTS YOU WILL GET 5% DISCOUNT!!!"); 
                Console.WriteLine("Choose your pizza");            
                Console.WriteLine("\r\n");
                Console.WriteLine("1. Meat pizza - 5$");
                Console.WriteLine("2. Chesee pizza - 7$");
                Console.WriteLine("3. Vegeterian pizza - 10$");
                Console.WriteLine("4. Exit");


                while (true)
                {
                    if (Int32.TryParse(Console.ReadLine(), out choose))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Pls input correct variant");
                    }

                }

                switch (choose)
                {
                    case 1:
                        Pizza = new MeatPizza();
                        Console.WriteLine($"Name: {Pizza.Name}");
                        Console.WriteLine($"Cost: {Pizza.GetCost()}");
                        return Pizza;

                    case 2:
                        Pizza = new CheseePizza();
                        Console.WriteLine($"Name: {Pizza.Name}");
                        Console.WriteLine($"Cost: {Pizza.GetCost()}");
                        return Pizza;

                    case 3:
                        Pizza = new VegeterianPizza();
                        Console.WriteLine($"Name: {Pizza.Name}");
                        Console.WriteLine($"Cost: {Pizza.GetCost()}");
                        return Pizza;

                    case 4:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Pls input correct variant");
                        break;


                }

            }
            
        }


        public Pizza ChooseSupplements(Pizza pizza)
        {
            while (true)
            {

                Console.WriteLine("Choose your supplements");
                Console.WriteLine("\r\n");
                Console.WriteLine("1. Mushrooms - 3$");
                Console.WriteLine("2. Pepper - 4$");
                Console.WriteLine("3. Pepperoni - 2$");
                Console.WriteLine("4. No just give me my pizza");


                while (true)
                {
                    if (Int32.TryParse(Console.ReadLine(), out choose))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Pls input correct variant");
                    }

                }

                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Your pizza");
                        pizza = new Mushrooms(pizza);
                        Console.WriteLine($"Name: {pizza.Name}");
                        Console.WriteLine($"Cost: {pizza.GetCost()}");
                        return pizza;

                    case 2:
                        Console.WriteLine("Your pizza");
                        pizza = new Pepper(pizza);
                        Console.WriteLine($"Name: {pizza.Name}");
                        Console.WriteLine($"Cost: {pizza.GetCost()}");
                        return pizza;

                    case 3:
                        Console.WriteLine("Your pizza");
                        pizza = new Pepperoni(pizza);
                        Console.WriteLine($"Name: {pizza.Name}");
                        Console.WriteLine($"Cost: {pizza.GetCost()}");
                        return pizza;

                    case 4:
                        Console.WriteLine("Your pizza");
                        Console.WriteLine($"Name: {pizza.Name}");
                        Console.WriteLine($"Cost: {pizza.GetCost()}");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Pls input correct variant");
                        break;

                }

            }

        }


        public bool AskAboutMoreSupplements()
        {
            while (true)
            {
                Console.WriteLine("Would you like add some more supplements?");
                Console.WriteLine("1.Yes");
                Console.WriteLine("2.No");
                if (Int32.TryParse(Console.ReadLine(), out choose))
                {
                    switch (choose)
                    {
                        case 1:
                            return true;
    
                        case 2:
                            return false;

                        default:
                            Console.WriteLine("Pls input correct variant");
                            break;

                    }

                }
                else
                {
                    Console.WriteLine("Pls input correct variant");
                }
            }
            
        }

    }
}
