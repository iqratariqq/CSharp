using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task4.BL;

namespace task4.UI
{
    class RectangleUI
    {
        public Rectangle rectangelInfor()
        {
            Console.WriteLine("enter width");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("enter height");
            double r1 = double.Parse(Console.ReadLine());
            Rectangle c1 = new Rectangle (r,r1);
            return c1;
        }
        public void rectangleArea(Rectangle c)
        {
            double areac = c.area();
            Console.WriteLine("the area of rectagle is {0}", areac);
        }
    }
}
