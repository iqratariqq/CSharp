using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task4.BL;

namespace task4.UI
{
    class SquareUI
    {
        public Square squareInfor()
        {
            Console.WriteLine("enter side");
            double r = double.Parse(Console.ReadLine());

            Square c1 = new Square(r);
            return c1;
        }
        public void squareArea(Square c)
        {
            double areac = c.area();
            Console.WriteLine("the area of square is {0}", areac);
        }

    }
}
