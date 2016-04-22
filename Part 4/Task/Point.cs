using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Point
    {

        public Point(int x, int y)  
        {
            this.x = x;
            this.y = y;
        }

        public int x
        {
            get { return x; }
            set { x = value; }
        }

        public int y
        {
            get { return y; }
            set { y = value; }
        }


        public bool Equals(Point point)
        {
            
            if (point == null)
            {
                return false;
            }

            if ((this.x == point.x) && (this.y == point.y)){
                return true;
            }

            return false;
            
        }

        public override string ToString()
        {
            string infoX = x.ToString();
            string infoY = y.ToString();
            return $"Coordiante X :{infoX} Coordinate Y : {infoY}";
        }


    }
}
