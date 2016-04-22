using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_equation
{
    public class QuadraticSolver
    {

        double a = 0;
        double b = 0;
        double c = 0;

        double discriminant = 0;
        double root1 = 0;
        double root2 = 0;


        public QuadraticSolver(double a, double b, double c)
        {

            this.a = a;
            this.b = b;
            this.c = c;

        }

        public double[] solve()
        {
            double[] result = new double[3];
            discriminant = Math.Pow(b, 2) - (4 * a * c);
            if (discriminant > 0 || discriminant == 0)
            {
                root1 =Math.Round( (-b + Math.Sqrt(discriminant)) / (2 * a),2);
                root2 =Math.Round( (-b - Math.Sqrt(discriminant)) / (2 * a),2);
                result[0] = discriminant;
                result[1] = root1;
                result[2] = root2;

                Console.WriteLine("Дискриминант равен: " + discriminant);
                //Console.WriteLine($"x1= {0}\n x2= {1}", root1, root2);
                return result;

                
            }


            else
            {
                Console.WriteLine("Действительных корней нет");
                return result;
            }

        }



    }
}
