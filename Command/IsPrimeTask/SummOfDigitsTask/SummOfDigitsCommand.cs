using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrimeTask.SummOfDigitsTask
{
    public class SummOfDigitsCommand : IExecutable
    {

        SummOfDigitsSolver solver = new SummOfDigitsSolver();
        int number;

        public SummOfDigitsCommand(int number)
        {
            this.number = number;
            solver = new SummOfDigitsSolver();
        }

        public void execute()
        {
            Console.WriteLine($"Summ of digits  {solver.GetSummOfDigits(number)}");
        }


       
    }
}
