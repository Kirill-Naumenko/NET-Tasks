using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrimeTask.SummOfDigitsTask
{
    public class SummOfDigitsCommand : AbstractExecutor
    {

        SummOfDigitsSolver solver = new SummOfDigitsSolver();

        public SummOfDigitsCommand(SummOfDigitsSolver solver)
        {
            this.solver = solver;
        }


        public override object execute(int number)
        {
            return solver.GetSummOfDigits(number);
        }
    }
}
