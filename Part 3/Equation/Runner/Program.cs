using System;

using Linear_Equation;
using Quadratic_equation;
using System.IO;
using Matrix;
using System.Configuration;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            int choose;
            double a = 0;
            double b = 0;
            double c = 0;

            string pathFile = ConfigurationManager.AppSettings["log"];

            StreamWriter writer = new StreamWriter(pathFile, true);


            while (true)
            {

                Console.WriteLine(" Выберите действие");
                Console.WriteLine("0. Линейное уравнение");
                Console.WriteLine("1. Квадратное уравнение");
                Console.WriteLine("2. Перемножить матрицу (данные из файла)");
                Console.WriteLine("3. Выход");


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
                        Console.WriteLine("Ax + B = 0");
                        Console.WriteLine("Введите коэффиценты А и В");

                        while (true)
                        {
                            Console.WriteLine("Введите A");

                            if (Double.TryParse(Console.ReadLine(), out a))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Введите пожалуйста цифру");
                                writer.WriteLine($"Линейное уравнение (ВВОД НЕКОРРЕКТНЫХ ДАННЫХ : А={a} ");

                            }

                        }

                        while (true)
                        {
                            Console.WriteLine("Введите B");

                            if (Double.TryParse(Console.ReadLine(), out b))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Введите пожалуйста цифру");
                                writer.WriteLine($"Линейное уравнение (ВВОД НЕКОРРЕКТНЫХ ДАННЫХ : B={b} ");

                            }

                        }


                        LinearSolver linearEquation = new LinearSolver(a, b);
                        Console.WriteLine("Корень уравнения: " + linearEquation.solve());


                        writer.WriteLine($"Линейное уравнение : {a}x+{b} = 0" + "\tКорень уравнения : " + linearEquation.solve());


                        Console.ReadLine();
                        break;

                    case 1:

                        Console.WriteLine("Ax^2 + Bx + C = 0");
                        Console.WriteLine("Введите коэффиценты А,B и С");

                        while (true)
                        {
                            Console.WriteLine("Введите A");

                            if (Double.TryParse(Console.ReadLine(), out a))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Введите пожалуйста цифру");
                                writer.WriteLine($"Квадратное уравнение (ВВОД НЕКОРРЕКТНЫХ ДАННЫХ : А={a} ");

                            }

                        }

                        while (true)
                        {
                            Console.WriteLine("Введите B");

                            if (Double.TryParse(Console.ReadLine(), out b))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Введите пожалуйста цифру");
                                writer.WriteLine($"Квадратное уравнение (ВВОД НЕКОРРЕКТНЫХ ДАННЫХ : B={b} ");

                            }

                        }

                        while (true)
                        {
                            Console.WriteLine("Введите C");

                            if (Double.TryParse(Console.ReadLine(), out c))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Введите пожалуйста цифру");
                                writer.WriteLine($"Квадратное уравнение (ВВОД НЕКОРРЕКТНЫХ ДАННЫХ : C={c} ");

                            }

                        }



                        QuadraticSolver quadriticEquation = new QuadraticSolver(a, b, c);
                        double[] result = quadriticEquation.solve();
                        Console.WriteLine($" Корни уравнения :  x1= {result[1]}  x2= {result[2]}");
                        writer.WriteLine($"Квадратное уравнение : {a}x^2 + {b}x + c = 0 " + $" Корни уравнения :  x1= {result[1]}  x2= {result[2]}");



                        Console.ReadLine();
                        break;



                    case 2:

                        string matrix1 = ConfigurationManager.AppSettings["matrix1"]; 
                        string matrix2 = ConfigurationManager.AppSettings["matrix2"];


                        double[,] A = MatrixSolver.readMatrix(matrix1);
                        double[,] B = MatrixSolver.readMatrix(matrix1);



                        Console.WriteLine();
                        Console.WriteLine("Матрицв А");
                        MatrixSolver.printMatrix(A);
                        Console.WriteLine();
                        Console.WriteLine("Матрицв B");
                        MatrixSolver.printMatrix(B);
                        Console.WriteLine();

                        double[,] answer = MatrixSolver.Multuply(A, B);

                        if (answer == null)
                        {
                            Console.WriteLine("Перемножение невозможно");
                        }
                        else
                        {
                            Console.WriteLine("Результат");
                            MatrixSolver.printMatrix(answer);
                        }


                        Console.ReadKey();

                    break;


                    case 3:
                        writer.Close();
                        Environment.Exit(0);
                        break;
                }
            }

            


        }
    }
}
