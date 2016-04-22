using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    static class Fibonacci
    {

        public static int getNumber(int n)
        {
            
                if (n == 1 || n == 2)
                {
                    return 1;
                }
                else
                {
                    return getNumber(n - 1) + getNumber(n - 2);
                }
            
        }

       
    }

    static class Factorial
    {
        public static int getNumber(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * getNumber(n - 1);
            }

        }
    }
}
