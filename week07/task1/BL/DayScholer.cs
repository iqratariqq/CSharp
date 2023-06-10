using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.BL
{
        class DayScholar:Student
        {
            public string pickUpPoint;
            public int busNo;
            public int pickUpDistance;
            public int getBusFee()
            {
                int fee = 0;
                fee = 5000;
                return fee;
            }
        }
}
