using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_5;
using Task_3;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec1 = new Rectangle(6, 5);//Большой прямоугольник
            Rectangle rec2 = new Rectangle(1, 3);//Маленький прямоугольник

            

            Console.WriteLine(Counter.count(rec1, rec2));
            Console.ReadKey();



        }
    }
}
