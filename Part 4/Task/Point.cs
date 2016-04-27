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
            get;
            set;
        }

        public int y
        {
            get;
            set;
        }


        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                
                return false;
            }

            Point p = obj as Point;
            if ((Object)p == null)
            {
                return false;
            }

            
            return (x == p.x) && (y == p.y);
        }

        public bool Equals(Point point)
        {
            
            if (point == null)
            {
                return false;
            }



            if (Object.ReferenceEquals(this, point))
            {
                return true;
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
