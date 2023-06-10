using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.BL
{
    class MyPoint
    {
        public int x;
        public int y;

       public MyPoint()
        {
           
        }
        public MyPoint(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public void setX(int x)
        {
            this.x = x;
        }
        public void setY(int y)
        {
            this.y = y;
        }
        public double distanceWithCords(int x,int y)
        {
            double x1 = Math.Pow(2, (this.x - x));

            double y1 = Math.Pow(2, (this.y - y));
            double distance = Math.Sqrt(x1 + y1);
            return distance;
        }
        public double distanceWithObject(MyPoint obj)
        {
            return distanceWithCords(obj.x, obj.y);
        }
        public double distanceFromZero()
        {
          
            return distanceWithCords(0, 0);
        }
    }
}
