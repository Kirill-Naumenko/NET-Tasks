using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrimeTask.LengthBetweenPointsTask
{
    public class LengthBetweenPointsSolver
    {
        Point point1;
        Point point2;

        public LengthBetweenPointsSolver(Point point1, Point point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }

        public double GetLength()
        {
            double length = Math.Round(Math.Sqrt((Math.Pow((point1.x - point1.y), 2) + Math.Pow((point2.x - point2.y), 2))),2);
            return length;
        }

    }
}
