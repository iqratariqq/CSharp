using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace task1.BL
{
    class Ship
    {
        public string shipNum;
        public Angle longitude = new Angle();
        public Angle latitude = new Angle();
        

        public Ship(string shipNum,Angle longitude,Angle latitude)
        {

            this.shipNum = shipNum;
            this.longitude = longitude;
            this.latitude = latitude;

        }

        
        public Angle returnLocationLatitude(List<Ship> s,string num)
        {
           
             foreach(Ship x in s)
            {
                if(x.shipNum==num)
                {
                    return x.latitude;
                }

            }
            return null;
        }
        public Angle returnLocationLongitude(List<Ship> s, string num)
        {

            foreach (Ship x in s)
            {
                if (x.shipNum == num)
                {
                    return x.longitude;
                }

            }
            return null;
        }
        public string returnShipSerial(List<Ship> s,Angle longitude,Angle latitude)
        {
            string serialNum="invalid";
            foreach(Ship x in s)
            {
                if (x.latitude.degree == latitude.degree && x.latitude.minutes == latitude.minutes && x.latitude.minutes == latitude.minutes && x.longitude.degree == longitude.degree && x.longitude.minutes == longitude.minutes && x.longitude.direction == longitude.direction)
                {
                    serialNum = x.shipNum;
                    return serialNum;
                }
            }
            return serialNum;
        }

    }
}
