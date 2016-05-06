using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrimeTask.SummOfDigitsTask
{
    public class SummOfDigitsSolver
    {

        public int GetSummOfDigits(int number)
        {
            return number.ToString().ToList().Sum(num => int.Parse(num.ToString()));
        }

    }
}
