using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.BL
{
    class Cylender:Circle
    {
        private double hieght = 1.0;
        public Cylender()
        {

        }
        public Cylender(double radius) :base( radius)
        {

        }
        public Cylender(double radius,double hieght):base(radius)
        {
            this.hieght = hieght;
        }
        public Cylender(double radius,double hieght,string color):base(radius,color)
        {
            this.hieght = hieght;
        }
       public double getHeight()
        {
            return this.hieght;
        }
        public void setHeight(double hieght)
        {
            this.hieght = hieght;
        }
        public double getVolume()
        {
            double volume = 3.14 * Math.Pow(2, radius) * hieght;
            return volume;
        }

    }
}
