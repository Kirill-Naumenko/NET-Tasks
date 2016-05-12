using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrimeTask.LengthBetweenPointsTask
{
    public class LengthBetweenPointsCommand : IExecutable
    {

        LengthBetweenPointsSolver solver;

        public LengthBetweenPointsCommand(LengthBetweenPointsSolver solver)
        {
            this.solver = solver;
        }



        public void execute()
        {
            Console.WriteLine($" Length between points is {solver.GetLength()}");
        }
    }
}
