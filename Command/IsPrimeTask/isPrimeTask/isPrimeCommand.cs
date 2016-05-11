using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IsPrimeTask
{
    class isPrimeCommand : IExecutable
    {
        int number;
        IsPrimeSolver solver;

        public isPrimeCommand(int number)
        {
            this.number = number;
            solver = new IsPrimeSolver();    
        }

        public void execute()
        {

            if (solver.IsPrime(number))
            {
                Console.WriteLine($"{number} is prime");
            }
            else
            {
                Console.WriteLine($"{number} is not prime");
            }
            

        }
    }
}
