﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamePro.BL
{
    class Point
    {
        public int x;
        public int y;
        public Point()
        {

        }
        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public void setX(int x)
        {
            this.x = x;
        }
        public void setY(int y)
        {
            this.y = y;
        }
        public int getX()
        {
return this.x;
        }
        public int getY()
        {
return this. y;
        }
        public  void setXY(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

    }
}
