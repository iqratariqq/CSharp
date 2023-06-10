using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task4.BL;
using task4.UI;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            SquareUI s = new SquareUI();
            RectangleUI r = new RectangleUI();
            CircleUI c = new CircleUI();
            Rectangle R = null;
            Square S = null;
            Circle C = null;
          R =  r.rectangelInfor();
            S = s.squareInfor();
            C = c.circleInfor();
            r.rectangleArea(R);
            s.squareArea(S);
            c.circleArea(C);
            Console.ReadKey();
            

        }
    }
}
