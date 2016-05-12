using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IsPrimeTask.SummOfDigitsTask;
using IsPrimeTask.LengthBetweenPointsTask;

namespace IsPrimeTask
{
    class Program
    {
        static void Main(string[] args)
        {


            int choose;
            int temp1 = 0;
            int temp2 = 0;
            
            while (true)
            {

                Console.WriteLine("Choose your action");
                Console.WriteLine("0. Check number for prime");
                Console.WriteLine("1. Get length between points ");
                Console.WriteLine("2. Get summ of digits");
                Console.WriteLine("3. Exit");


                while (true)
                {
                    if (Int32.TryParse(Console.ReadLine(), out choose))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Input correct number");
                    }

                }


                switch (choose)
                {
                    case 0:
                       
                        Console.WriteLine("Input number that you want to check");

                        while (true)
                        {
                           

                            if (Int32.TryParse(Console.ReadLine(), out temp1))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Input correct number");
                            }

                        }


                        IsPrimeSolver SolverTask1 = new IsPrimeSolver();
                        isPrimeCommand CommandTask1 = new isPrimeCommand(temp1);
                        CommandTask1.execute();
                        Console.ReadKey();           
                        break;

                    case 1:

                        Console.WriteLine("Input coordinates of points ");
                       

                        while (true)
                        {
                            Console.WriteLine("Input first coordinate of Point 1");

                            if (Int32.TryParse(Console.ReadLine(), out temp1))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Input correct number");
                            }

                        }

                        while (true)
                        {
                            Console.WriteLine("Input second coordinate of Point 1");

                            if (Int32.TryParse(Console.ReadLine(), out temp2))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Input correct number");
                            }

                        }

                        Point point1 = new Point(temp1, temp2);

                        while (true)
                        {
                            Console.WriteLine("Input first coordinate of Point 2");

                            if (Int32.TryParse(Console.ReadLine(), out temp1))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Input correct number");
                            }

                        }

                        while (true)
                        {
                            Console.WriteLine("Input second coordinate of Point 2");

                            if (Int32.TryParse(Console.ReadLine(), out temp2))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Input correct number");
                            }

                        }
                        Point point2 = new Point(temp1, temp2);
   
                        LengthBetweenPointsSolver SolverTask2 = new LengthBetweenPointsSolver(point1, point2);
                        LengthBetweenPointsCommand CommandTask2 = new LengthBetweenPointsCommand(SolverTask2);
                        CommandTask2.execute();
                        Console.ReadKey();
                        break;



                    case 2:

                        Console.WriteLine("Input number to know its summ of digits ");

                        while (true)
                        {

                            if (Int32.TryParse(Console.ReadLine(), out temp1))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Input correct number");
                            }

                        }

                        SummOfDigitsSolver SolverTask3 = new SummOfDigitsSolver();
                        SummOfDigitsCommand CommandTask3 = new SummOfDigitsCommand(temp1);
                        CommandTask3.execute();
                        Console.ReadKey();
                        break;


                    case 3:
                        
                        Environment.Exit(0);
                        break;
                }
            }

        }
    }
}
