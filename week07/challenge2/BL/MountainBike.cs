using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge2.BL
{
    class MountainBike: Bicycle
    {
        private int seatHeight;
        public MountainBike(int seatHeight,int cadence,int speed,int gear):base(cadence, speed, gear)

        {
            this.seatHeight = seatHeight;
        }
        public void setSeatHeight(int seatHeight)
        {

        }
    }
}
