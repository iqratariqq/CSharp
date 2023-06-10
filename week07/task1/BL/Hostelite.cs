using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.BL
{
     class Hostelite : Student
    {
        public int roomNumber;
        public bool isFridgeAvailable;
        public bool isInternetAvailable;

        public int getBusFee()
        {
            int fee = 0;
            if (isFridgeAvailable == true && isInternetAvailable == true)
            {
                fee = 55000 + 700 + 1000;
            }
            else
            {
                fee = 55000;
            }
            return fee;
        }
    }
}
