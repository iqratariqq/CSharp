using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.BL
{
    class MyLine
    {
        public MyPoint begin;
        public MyPoint end;

       public MyLine()
        {

        }
      public  MyLine(MyPoint begin,MyPoint end)
        {
            this.begin = begin;
            this.end = end;
        }
        public void setBegin(MyPoint atBegin)
        {
            this.begin = atBegin;
        }
        public void setEnd(MyPoint end)
        {
            this.end = end;
        }
        public MyPoint getbegin()
        {
            return begin;
        }

        public MyPoint getend()
        {
            return end;
        }
        public double getGradient()
        {
            double x =  end.x- begin.x ;
            double y = end.y - begin.y;
            double gradient = y / x;
            return gradient;
        }

        public double length()
        {
            return begin.distanceWithObject(end);
        }
    }
}
