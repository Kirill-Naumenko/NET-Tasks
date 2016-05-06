using IsPrimeTask.LengthBetweenPointsTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrimeTask
{
    public abstract class AbstractExecutor : IExecutable
    {

        public  void execute()
        {

        }     

        public abstract object execute(int number);

        public abstract object execute(Point point1, Point point2);

        

    }
}
