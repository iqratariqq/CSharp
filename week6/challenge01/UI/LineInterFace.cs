using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.BL;

namespace task2.UI
{
    class LineInterFace
    {

        public  int giveXForLine()
        {
            Console.WriteLine("enter value of x for make line");
            int x = int.Parse(Console.ReadLine());
            return x;
        }
        public  int giveYForLine()
        {
            Console.WriteLine("enter value of y for make line");
            int y = int.Parse(Console.ReadLine());
            return y;
        }
        public  MyPoint updateBeginPoint()
        {
            MyPoint point = new MyPoint();
            Console.WriteLine("enter value of x for update begin");
            point.x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter value of y for update begin");
            point.y = int.Parse(Console.ReadLine());
            return point;
        }

        public  MyPoint updateEndPoint()
        {
            MyPoint point = new MyPoint();
            Console.WriteLine("enter value of x for update end");
            point.x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter value of y for update end");
            point.y = int.Parse(Console.ReadLine());
            return point;
        }
        public  void showBeginPoint(MyPoint point)
        {
            Console.WriteLine("x in begin point is " + point.x + " y in begim point is " + point.y);
        }
        public  void showEndPoint(MyPoint point)
        {
            Console.WriteLine("x in end point is " + point.x + " y in end point is " + point.y);
        }
        public  void showDistanceOfBeginFromZero(double distance)
        {
            Console.WriteLine("the distance of begin point from the ero cordinates is " + distance);
        }

        public  void showEndDistanceFromZero(double distance)
        {
            Console.WriteLine("the distance of end point from the ero cordinates is " + distance);
        }

        public  void showGradient(double gradient)
        {
            Console.WriteLine("the gradient of line is " + gradient);
        }

        public  void showLength(double length)
        {
            Console.WriteLine("the length of line is " + length);
        }
    }
}
