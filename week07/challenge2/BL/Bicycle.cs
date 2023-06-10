using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge2.BL
{
    class Bicycle
    {
        protected int cadence;
        protected int gear;
        protected int speed;
        public Bicycle(int cadence, int gear, int speed)
        {
            this.cadence = cadence;
            this.gear = gear;
            this.speed = speed;

        }
        public void setCadence(int cadence)
        {
            this.cadence = cadence;
        }
        public void setGear(int gear)
        {
            this.gear = gear;
        }
        public void applyBrake(int decrement)
        {

        }
        public void speedUP(int decrement)
        {

        }
    }
}
