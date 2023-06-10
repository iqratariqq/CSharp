using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.UI;
using task2.BL;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLine line = new MyLine();
            MyPoint point = new MyPoint();
            LineInterFace inter = new LineInterFace();
            int option;
            do
            {
                Menu menus =new Menu();
                option = menus.menu();
                if(option==1)
                {
                    int x = inter.giveXForLine();
                    int y = inter.giveYForLine();
                    point.setX(x);
                    point.setY(y);

                }
                else if(option==2)
                {
                    point = inter.updateBeginPoint();
                    line.setBegin(point);
                }
                else if (option == 3)
                {
                    point = inter. updateEndPoint();
                    line.setEnd(point);
                }
                else if (option == 4)
                {
                   point= line.getbegin();
                    inter.showBeginPoint(point);
                }
                else if (option == 5)
                {
                    point = line.getend();
                    inter. showEndPoint(point);
                }
                else if (option == 6)
                {
                 double distance=   line.begin.distanceFromZero();
                    inter.showDistanceOfBeginFromZero(distance);
                }
                else if (option == 7)
                {
                    double endDistance = line.end.distanceFromZero();
                    inter. showEndDistanceFromZero(endDistance);
                }
                else if (option == 8)
                {
                    double gradient = line.getGradient();
                    inter. showGradient(gradient);
                }
                else if (option == 9)
                {
                    double length = line.length();
                    inter. showLength(length);
                }
            }          
            while (option != 10);
            Console.ReadKey();
        }



    }
}
