using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string generalString = String.Empty; //Общая строка, которая считывается с консоли
            char c;                              // Временная переманная в которую записываем символы, покуда не введется ключ для выхода
            Console.WriteLine("Вводите любые строки или числа. Для выхода нажмите '*'");
            Console.WriteLine("\r\n");

            do  //Цикл для считывания с консоли
            {
               int temp = Console.Read();
               c = Convert.ToChar(temp);
                generalString = generalString + c;

            } while (c != '*');

            string main = generalString.Replace("\r\n", " "); //Из получившейся строки убираем символы перевода строки
            Console.WriteLine(main);
            Console.WriteLine("\r\n");

            List<string> strings = new List<string>(); //Коллекции для строк, целых чисел и дробных
            ArrayList integers = new ArrayList();
            ArrayList reals = new ArrayList();

            string[] array = main.Split(' ');   //Парсим строку и раскидываем по коллекциям

            for (int i = 0; i< array.Length; i++)
            {
                int temp1;
                if (Int32.TryParse(array[i], out temp1))
                {
                    integers.Add(temp1);
                }else
                {
                    double temp2;
                    if(Double.TryParse(array[i], out temp2))
                    {
                        reals.Add(temp2);
                    }
                    else
                    {
                        strings.Add(array[i]);
                    }
                }
            }


            double integerAverage = 0; //Вывод целых чисел и подсчет среднего
            Console.WriteLine("{0,50} ", "INTEGERS ");
            for (int i=0 ; i< integers.Count; i++)
            {
                integerAverage = integerAverage + Convert.ToInt32(integers[i]);
                Console.WriteLine("{0,50} ", integers[i]);
            }
            Console.WriteLine("{0,50} ", "AMOUNT OF INTEGERS " + integers.Count);
            Console.WriteLine("{0,50} ", "AVERAGE OF INTEGERS " + integerAverage/integers.Count);
            Console.WriteLine("\r\n");



            double realAverage = 0; //Вывод вещественных чисел и подсчет среднего
            Console.WriteLine("{0,50} ", "REALS ");
            for (int i = 0; i < reals.Count; i++)
            {
                realAverage = realAverage + Convert.ToDouble(reals[i]);
                Console.WriteLine("{0,50} ", Math.Round(Convert.ToDouble(reals[i]),2));
            }
            Console.WriteLine("{0,50} ", "AMOUNT OF REALS " + reals.Count);
            Console.WriteLine("{0,50} ", "AVERAGE OF REALS " + realAverage / reals.Count);
            Console.WriteLine("\r\n");


            strings.Sort(delegate (string s1, string s2) //Сортировка строк по длине в коллекции
            {
                if (s1.Length == s2.Length)
                {
                    return s1.CompareTo(s2);
                }
                else return s1.Length - s2.Length;
            });

            for (int i = 0; i < strings.Count; i++) //Вывод строк
            {
                Console.WriteLine(strings[i]);
            }




            Console.ReadLine();
            Console.ReadLine();

        }
    }
}
