using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.BL
{
    class Circle
    {
        protected double radius = 1.0;
        protected string color = "red";
        public Circle()
        {

        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius,string color)
        {
            this.radius = radius;
            this.color = color;
        }
        public double getRadius()
        {
            return this.radius;
        }
        public void setRadius(double radius)
        {
            this.radius = radius;
        }
        public string getColor()
        {
            return this.color;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public double getAria()
        {
            double area = 3.14 * Math.Pow(2, radius);
            return area;
        }
        public string toString()
        {
            string myCircle = "Circle " +" radius " + radius.ToString() +" color "+ color;
            return myCircle;
        }
    }
}
