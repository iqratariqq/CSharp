using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.UI
{
    class Menu

    {
        public  int menu()
        {
            int option;
            Console.WriteLine("1.make line");
            Console.WriteLine("2.update begin point");
            Console.WriteLine("3.update end point");
            Console.WriteLine("4.show begin point");
            Console.WriteLine("5.show end point");
            Console.WriteLine("6.get the Gradient of line");
            Console.WriteLine("7.find the distance of begin point from zero cordinate");
            Console.WriteLine("8.find the distance of end point from zero cordinate");
            Console.WriteLine("9.get length");
            Console.WriteLine("10.exit");
            Console.WriteLine("enter one option");
            int.TryParse(Console.ReadLine(), out option);
            return option;
        }
    }
}
