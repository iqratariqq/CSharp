using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using gamePro.BL;

namespace gamePro
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] triangle = new char[5, 3] { { '@', ' ', ' ' }, { '@', '@', ' ' }, { '@', '@', '@' }, { '@', '@', ' ' }, { '@', ' ', ' ' } };
            char[,] opTriangle = new char[5, 3] { { ' ', ' ', '@' }, { ' ', '@', '@' }, { '@', '@', '@' }, { ' ', '@', '@' }, { ' ', ' ', '@' } };

            Boundary b = new Boundary(new Point(0, 0), new Point(0, 90), new Point(90, 0), new Point(90, 90));
            GameProject g1 = new GameProject(triangle, new Point(30, 60), "RightToLeft", b);
            GameProject g2 = new GameProject(opTriangle, new Point(5, 5), "LefttoRight", b);
            Boundary b2 = new Boundary(new Point(0, 0), new Point(0, 20), new Point(90, 0), new Point(90, 90));
            GameProject g3 = new GameProject(opTriangle, new Point(5, 5), "diagonal", b2);
            Boundary b3 = new Boundary(new Point(0, 0), new Point(7, 10), new Point(90, 0), new Point(90, 90));
            GameProject g4 = new GameProject(opTriangle, new Point(0, 15), "topRight", b3);

            List<GameProject> list = new List<GameProject>(); // WHICH ONE YOU WANT TO RUN YOU HAVE TO UNCOMMENT IT COMEENT WHICH ALL EXCPT THAT
            /*list.Add(g1);*/ // for left move
            list.Add(g2); //foe right move and also left
            /*list.Add(g3);*///for diagonal move
            /*list.Add(g4);*///for projectile motion
            while (true)
            {
                Thread.Sleep(200);
                foreach(GameProject g in list)
                {
                    g.erase();
                    g.moveRight();
                   /* g.patrol();*/
                    /* g.moveLeft1();*/
                    /*g.moveDiagonal();*/
                    /*g.projectileMotion();*/
                    g.draw();

                

                }
            }
        }
    }
}
