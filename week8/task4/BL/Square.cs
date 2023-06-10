using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4.BL
{
    class Square:Shape
    {
        private double side;
        public Square(double side)
        {
            this.side = side;
        }
        public override double area()
        {
            return side * side;
        }
    }
}
