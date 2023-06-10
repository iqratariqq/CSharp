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
            List<Ship> s = new List<Ship>();
            Ship ships = null;
            int option;
            do
            {
                option = menu();
                if (option == 1)
                {
                     ships = takeinputforship();
                    storedinList(ships, s);
                }
                else if (option == 2)
                {
                    Angle longitude = takeinputforlongitude();
                    Angle latitude = takeinputforLatitute();
                  string serialNum=  ships.returnShipSerial(s, longitude, latitude);
                    viewSerialNum(serialNum);
                }
                else if (option == 3)
                {
                    string serial = viewShipLocation();
                   Angle latitude=ships.returnLocationLatitude(s, serial);
                    Angle logitude = ships.returnLocationLongitude(s, serial);
                    viewShipAngle(latitude,logitude);

                }
                else if (option == 4)
                {
                   Ship ship= takeInputForChangePosition(s,ships);
                    storedinList(ship, s);
                }
            } while (option != 5);
            Console.ReadKey();
            
        }
        public static int menu()
        {
            Console.WriteLine("1.Add ship");
            Console.WriteLine("2.view Ship position");
            Console.WriteLine("3.view ship serial number");
            Console.WriteLine("4.change ship position");
            Console.WriteLine("5.exit");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        public static Ship takeinputforship()
        {
            //ship input= new ship();
            Console.Write("enter ship number: ");
            string number = Console.ReadLine();
            Console.WriteLine("enter ship longitude:");
            Console.Write("enter longitude's degree: ");
            int degree = int.Parse(Console.ReadLine());
            Console.Write("enter longitude's Minutes: ");
            float minutes = float.Parse(Console.ReadLine());
            Console.Write("enter longitude's direction: ");
            char direction = char.Parse(Console.ReadLine());
            Angle shiplongitude = new Angle(degree, minutes, direction);
            Console.WriteLine("enter ship latitude:");
            Console.Write("enter latitude's degree: ");
            int degreeL = int.Parse(Console.ReadLine());
            Console.Write("enter latitude's Minutes: ");
            float minutesl = float.Parse(Console.ReadLine());
            Console.Write("enter latitude's direction: ");
            char directionL = char.Parse(Console.ReadLine());
            Angle shiplatitude = new Angle(degreeL, minutesl, directionL);
            Ship newShip = new Ship(number, shiplongitude, shiplatitude);
            return newShip;

        }
        public static  void  storedinList(Ship s,List<Ship> ships)
        {
            ships.Add(s);
        }
        public static string viewShipLocation()
        {
            Console.WriteLine("enter the ship serial number to find its position:");
            string num = Console.ReadLine();
            return num;
        }
        public static void viewShipAngle(Angle location,Angle longitude)
        {
            Console.WriteLine(location.degree + "'"+location.minutes+"'"+location.direction+"'");
            Console.WriteLine(longitude.degree + "'" + longitude.minutes + "'" + longitude.direction + "'");
        }
        public static Angle takeinputforlongitude()
        {
            Console.WriteLine("enter ship longitude:");
            Console.Write("enter longitude's degree: ");
            int degree = int.Parse(Console.ReadLine());
            Console.Write("enter longitude's Minutes: ");
            float minutes = float.Parse(Console.ReadLine());
            Console.Write("enter longitude's direction: ");
            char direction = char.Parse(Console.ReadLine());
            Angle shiplongitude = new Angle(degree, minutes, direction);
            return shiplongitude;
        }
        public static Angle takeinputforLatitute()
        {
            Console.WriteLine("enter ship latitude:");
            Console.Write("enter latitude's degree: ");
            int degreeL = int.Parse(Console.ReadLine());
            Console.Write("enter latitude's Minutes: ");
            float minutesl = float.Parse(Console.ReadLine());
            Console.Write("enter latitude's direction: ");
            char directionL = char.Parse(Console.ReadLine());
            Angle shiplatitude = new Angle(degreeL, minutesl, directionL);
            return shiplatitude;
        }
        public static void viewSerialNum(string serialNumber)
        {
            Console.WriteLine("the serial number is {0}",serialNumber);
           
        }
        public static Ship takeInputForChangePosition(List<Ship> s,Ship ships)
        {
            Console.Write("enter ship number: ");
            string number = Console.ReadLine();
            foreach (Ship x in s)
            {
                if (number ==x.shipNum)

                    Console.WriteLine("enter ship longitude:");
                Console.Write("enter longitude's degree: ");
                int degree = int.Parse(Console.ReadLine());
                x.longitude.degree = degree;
                Console.Write("enter longitude's Minutes: ");
                float minutes = float.Parse(Console.ReadLine());
                x.longitude.minutes = minutes;
                Console.Write("enter longitude's direction: ");
                char direction = char.Parse(Console.ReadLine());
                x.longitude.direction = direction;
                Angle shiplongitude = new Angle(degree, minutes, direction);
                Console.WriteLine("enter ship latitude:");
                
                Console.Write("enter latitude's degree: ");
                int degreeL = int.Parse(Console.ReadLine());
                x.latitude.degree = degreeL;
                Console.Write("enter latitude's Minutes: ");
                float minutesl = float.Parse(Console.ReadLine());
                x.latitude.minutes = minutesl;
                Console.Write("enter latitude's direction: ");
                char directionL = char.Parse(Console.ReadLine());
                x.latitude.direction = directionL;
                Angle shiplatitude = new Angle(degreeL, minutesl, directionL);
                Ship newShip = new Ship(number, shiplongitude, shiplatitude);
                return newShip;
            }
            return ships;
        }

    }
}               
