using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamePro.BL
{
    class Boundary
    {
        public Point TopLeft;
        public Point TopRight;
        public Point BottomLeft;
        public Point BottomRight;
        public Boundary()
        {
            this.TopLeft.setXY(0, 0);
            this.TopRight.setXY(0, 90);
            this.BottomLeft.setXY(90, 0);
            this.BottomRight.setXY(90, 90);            
        }
        public Boundary(Point TopLeft, Point TopRight, Point BottomLeft, Point BottomRight)
        {
            this.TopLeft = TopLeft;
            this.TopRight = TopRight;
            this.BottomLeft = BottomLeft;
            this.BottomRight = BottomRight;
        }

    }
}
