using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.BL;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cylender myCylender = new Cylender();
            Cylender myCylender1 = new Cylender(2.0);
            Cylender myCylender2 = new Cylender(2.0, 1.0);

           double vol1= myCylender.getVolume();
            Console.WriteLine("this is defualt "+ vol1);
            vol1 = myCylender1.getVolume();
            Console.WriteLine("this is one parameterized "+ vol1);
            vol1 = myCylender2.getVolume();
            Console.WriteLine("this is two parameterized "+ vol1);
            Console.ReadKey();
        }
    }
}
