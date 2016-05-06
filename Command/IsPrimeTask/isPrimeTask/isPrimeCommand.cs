using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IsPrimeTask
{
    class isPrimeCommand : IExecutable
    {

        IsPrimeSolver solver;

        public isPrimeCommand(IsPrimeSolver solver)
        {
            this.solver = solver;
        }

        public void execute()
        {
            throw new NotImplementedException();
        }

        public void execute(int number)
        {
            Console.WriteLine(solver.IsPrime(number));
        }

        
       
    }
}
