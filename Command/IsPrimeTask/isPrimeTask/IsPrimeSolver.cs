using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrimeTask
{
    public class IsPrimeSolver
    {

        public bool IsPrime(int number )
        {
            bool result = true;
            if (number == 1)
            {
                return false;
            }
            else if (number == 2)
            {
                return true;
            }
            else
            {
                for (int i = 3; i * i <= number; i += 2)
                {
                    if (number % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            return result;
        }

    }
}
