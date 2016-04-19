using System;
using ClassLibrary;
using System.Configuration;
using System.Resources;
using System.Reflection;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Объявление и инициализация переменных переменных
            int a = 0;
            int b = 0;


            //Считывание параметра из конфигурационного файла
            String dataProvider = ConfigurationManager.AppSettings["DataProvider"];
            String parametr = ConfigurationManager.AppSettings["Data"];

            switch (dataProvider) {

                case "resource":

                    String firstNumber = Resource.ResourceManager.GetString("FirstNumber");
                    String secondNumber = Resource.ResourceManager.GetString("SecondNumber");

                    try
                    {
                        a = Int32.Parse(firstNumber);
                        b = Int32.Parse(secondNumber);
                    }
                    catch (System.FormatException)
                    {
                        //Выпадение ошибки при вводе символа или неправильного формата числа
                        Console.WriteLine("Nope! Input number pls");
                    }
                    catch (System.OverflowException)
                    {
                        //Выпадение ошибки при вооде чисоа выходящего за пределы int
                        Console.WriteLine("Nope! Too huge number, sorry");
                    }
                    break;

                case "console":
                    //Цикл для повторного ввода при ошибке ввода
                    while (true)
                    {

                        try
                        {
                            //Ввод числа
                            Console.WriteLine("Input first number");
                            a = Int32.Parse(Console.ReadLine());
                            break;
                        }
                        catch (System.FormatException)
                        {
                            //Выпадение ошибки при вводе символа или неправильного формата числа
                            Console.WriteLine("Nope! Input number pls");
                        }
                        catch (System.OverflowException)
                        {
                            //Выпадение ошибки при вооде чисоа выходящего за пределы int
                            Console.WriteLine("Nope! Too huge number, sorry");
                        }
                    }


                    while (true)
                    {

                        try
                        {
                            Console.WriteLine("Input second number");
                            b = Int32.Parse(Console.ReadLine());
                            break;
                        }
                        catch (System.FormatException)
                        {
                            Console.WriteLine("Nope! Input number pls");
                        }
                        catch (System.OverflowException)
                        {
                            Console.WriteLine("Nope! Too huge number, sorry");
                        }
                    }
                    break;
        }
    




            switch (parametr)
            {
                case "main":
                    Console.WriteLine("Summary ");
                    Console.WriteLine(a + b);
                    break;

                case "class":

                    Console.WriteLine("Addition: " + Calculator.addition(a, b));
                    Console.WriteLine("Division: " + Calculator.division(a, b));
                    Console.WriteLine("Multiplication: " + Calculator.multiplication(a, b));
                    Console.WriteLine("Substraction: " + Calculator.substraction(a, b));
                    break;

            }

            Console.ReadLine();
                
            
               

                

            }

            

        }
    }

