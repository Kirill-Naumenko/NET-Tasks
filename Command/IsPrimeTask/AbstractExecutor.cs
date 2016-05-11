using IsPrimeTask.LengthBetweenPointsTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace IsPrimeTask
{
    public abstract class AbstractExecutor : IExecutable
    {

        public  void execute()
        {

        }     

        public virtual bool execute(int number)
        {
            return false;
        }

        public virtual BigInteger execute(BigInteger number)
        {
            return number;
        }


       // public virtual o execute(Point point1, Point point2);

        

    }
}
