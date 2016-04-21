using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Calculator
    {
        public static int addition(int a, int b)
        {
            int result = 0;
            result = a + b;
            return result;
        }
        public static double division (int a , int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error! Division by zero");
                return 0;
            }
            else
            {


                double result = 0;
                result = (double)a / b;
                return result;
            }
        }
        public static int multiplication(int a, int b)
        {
            int result = 0;
            result = a * b;
            return result;
        }
        public static double substraction(int a, int b)
        {
            double result = 0;
            result = a - b;
            return result;
        }
    }
}
