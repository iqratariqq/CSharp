using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task4.BL;
namespace task4.UI
{
    class CircleUI
    {
      public  Circle circleInfor()
        {
            Console.WriteLine("enter radius");
            double c = double.Parse(Console.ReadLine());
            Circle c1 = new Circle(c);
            return c1;
        }
        public void circleArea(Circle c)
        {
            double areac = c.area();
            Console.WriteLine("the area of circle is {0}",areac);
        }
    }
}
