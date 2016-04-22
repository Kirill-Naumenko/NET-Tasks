using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Equation
{
    public class LinearSolver
    {
        double a;
        double b;
        double root;

        public LinearSolver(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double solve()
        {
            if (a == 0)
            {
                root = -b;
                return root;
            }
            root = -b / a;
            return root;
        }

    }
}
