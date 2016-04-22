using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {


            int choose;
            int number;

            while (true)
            {

                Console.WriteLine(" Выберите действие");
                Console.WriteLine("0. Узнать число Фибоначчи");
                Console.WriteLine("1. Узнать факториал числа");
                Console.WriteLine("2. Выход");


                while (true)
                {
                    if (Int32.TryParse(Console.ReadLine(), out choose))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Введите пожалуйста цифру из предложенных");
                    }

                }


                switch (choose)
                {

                    case 0:
                        Console.WriteLine("Введите индекс ряда Фибоначи, число которого хотите узнать ");

                        while (true)
                        {
                            if (Int32.TryParse(Console.ReadLine(), out number))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Введите пожалуйста число");
                            }

                        }

                        Console.WriteLine("Значение числа Фибоначчи " + Fibonacci.getNumber(number));
                        break;

                    case 1:
                        Console.WriteLine("Введите индекс ряда Фибоначи, число которого хотите узнать ");

                        while (true)
                        {
                            if (Int32.TryParse(Console.ReadLine(), out number))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Введите пожалуйста число");
                            }

                        }

                        Console.WriteLine("Факториал числа равен " + Factorial.getNumber(number));
                        break;

                    case 2:
                        Environment.Exit(0);
                        break;
                }

                Console.ReadKey();
            }
        }
    }
}
