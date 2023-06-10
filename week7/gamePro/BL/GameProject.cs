using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZInput;
namespace gamePro.BL
{
    class GameProject
    {
        public char[,] Shape = new char[,] { };
        public Point StartingPoint;
        public Boundary Premises;
        public string direction;

        public GameProject()
        {
            this.Shape = new char[1, 3] { { '-','-','-' }};
            this.StartingPoint.setXY(0, 0);
            this.Premises.BottomRight.setXY(90, 90);
            this.Premises.BottomLeft.setXY(90, 0);
            this.Premises.TopLeft.setXY(0, 0);
            this.Premises.TopRight.setXY(0, 90);
            direction = "LeftToRight";
        }
        public GameProject(char[,] Shape, Point StartingPoint, string direction, Boundary Premises)
        {
            this.Shape = Shape;
            this.StartingPoint = StartingPoint;
            this.Premises = Premises;
            this.direction = direction;
        }

        public void patrol()
        {
            if (this.direction == "RightToLeft")
            {
                if (this.StartingPoint.getX() > this.Premises.TopLeft.x|| this.StartingPoint.getX()> this.Premises.TopLeft.y)
                {
                    this.StartingPoint.setX(StartingPoint.getX()-1);

                }
                else
                {
                    this.direction = "LefttoRight";
                }
            }
           else if (this.direction == "LefttoRight")
            {
                if (this.StartingPoint.getX() < this.Premises.TopRight.x||this.StartingPoint.getX() < this.Premises.TopRight.y)
                {
                    this.StartingPoint.setX(StartingPoint.getX() + 1);
                }
                else if (this.StartingPoint.getX() == this.Premises.TopRight.y)
                {
                    this.direction = "RightToLeft";
                }
            }

        }



        public void moveLeft1()
        {
            if (this.direction == "RightToLeft")
            {
                if (this.StartingPoint.getX() > this.Premises.TopLeft.x || this.StartingPoint.getX() > this.Premises.TopLeft.y)
                {
                    this.StartingPoint.setX(StartingPoint.getX() - 1);

                }

            }
        }
        public void moveRight()
        {
             if (this.direction == "LefttoRight")
             {
                if (this.StartingPoint.getX() < this.Premises.TopRight.x || this.StartingPoint.getX() < this.Premises.TopRight.y)
                {
                    this.StartingPoint.setX(StartingPoint.getX() + 1);
                }
             }
        }


        public void moveDiagonal()
        {
            if(this.direction=="diagonal")
            {

                if (this.StartingPoint.getX() < this.Premises.TopRight.x || this.StartingPoint.getX() < this.Premises.TopRight.y)
                {
                    this.StartingPoint.setX(StartingPoint.getX() + 1);
                    this.StartingPoint.setY(StartingPoint.getY() + 1);
                }

            }
        }

        public void projectileMotion()
        {
            if(direction=="topRight")
            {
                if (this.StartingPoint.getX() > this.Premises.TopRight.x || this.StartingPoint.getY() > this.Premises.TopRight.y)
                {
                    this.StartingPoint.setX(StartingPoint.getX() + 1);
                    this.StartingPoint.setY(StartingPoint.getY() - 1);
                }
                else if(StartingPoint.getY()== Premises.TopRight.y)
                {
                    direction = "right";
                }
            }
            else if(direction=="right")
            {
                if (this.StartingPoint.getX() < this.Premises.TopRight.x || this.StartingPoint.getX() < this.Premises.TopRight.y)
                {
                    this.StartingPoint.setX(StartingPoint.getX() + 1);
                    
                }
                 if(StartingPoint.getX()== Premises.TopRight.x)
                {
                    direction = "down";
                }   
            }
             else if (direction == "down")
              {
                if (this.StartingPoint.getX() > this.Premises.TopRight.x || StartingPoint.getX() + 5> this.Premises.TopRight.y)
                {
                    this.StartingPoint.setX(StartingPoint.getX() + 1);
                    this.StartingPoint.setY(StartingPoint.getY() + 1);
                }
              }

        }
            public void draw()
            {
                for(int i=0;i<5;i++)
                {
                  for(int j=0;j<3;j++)
                  {
                    Console.SetCursorPosition(this.StartingPoint.x + j, this.StartingPoint.y + i);
                    Console.Write(Shape[i, j]);
                  }
                }
            }

        public void erase()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition(this.StartingPoint.x + j, this.StartingPoint.y + i);
                    Console.Write(" ");
                }
            }
        }

    }
}
