using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
   public class Rectangle
    {
       public  int a;
       public  int b;

        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int area()
        {
            int area = a * b;
            return area;
        }

    }
}
