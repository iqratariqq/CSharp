using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task.BL;
using System.IO;
using EZInput;
using System.Threading;

namespace task
{
    class Program
    {
        //enemy health
        static int eHealth = 10;

        //score
        static int score = 0;

        //player Health
        static int pHealth = 10;
        static void Main(string[] args)
        {
            //player object//class
            MAN berzerk = new MAN();
            berzerk.xPos = 20;
            berzerk.yPos = 20;

            //enemy object//class2
            Enemy robo = new Enemy();
            robo.enemyX_pos = 25;
            robo.enemyY_pos = 95;
            string pathM = "C:\\Users\\abdul sattar\\OneDrive\\Desktop\\Game\\maze.txt";

            // player bullet object//class3
            Bullet[] fire = new Bullet[1000];
            int bulletCount = 0;

            //enemy bullet object//class4
            EnemyBullet[] Fires = new EnemyBullet[1000];
            int EnemyBulletCount = 0;

            //maze coordinates
            char[,] maze = new char[30, 105];
            loadMaze(ref pathM, ref maze);
           

            //player character
            char char178 = (char)178; // Use an ASCII character that represents the 'box' symbol
            char char219 = (char)219; // Use an ASCII character that represents the filled rectangle symbol
            char[,] player = {
                { ' ', '_', '_', ' '},
                { '(', char178, char178, ')'},
                { '/', char219, char219, '\\'},
                { '(', ' ', ' ', ')'}
            };

            //enemy character
            string enemyDirection = "UP";
            int count1 = 0;
            char char248 = (char)248; //Use an ASCII character that represents the 'box' symbol
            char char218 = (char)218;// Use an ASCII character that represents the filled rectangle symbol
            char[,] enemy = {
                { ' ',char218, char218, ' '},
                     { '|',  char248 ,  char248 , '|'},
                     { ' ', '|', '|', ' '}
            };
            while (true)
            {
                sab_menu();
                Thread.Sleep(2000);
                Console.Clear();
                submenu();
                int option;
                Console.WriteLine(" ");
                Console.WriteLine("1.instruction:");
                Console.WriteLine("2.key:");
                Console.WriteLine("3.start:");
                Console.WriteLine("4.exit:");
                Console.WriteLine("enter one option:");
                option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Console.Clear();
                    instruction();
                }
                else if (option == 2)
                {
                    Console.Clear();
                    submenu();
                    key();
                }
                if (option == 3)
                {
                    Console.Clear();
                    gameStart(ref enemyDirection, ref enemy, ref player, ref maze, ref EnemyBulletCount, ref Fires, ref bulletCount, ref fire, ref robo, ref berzerk);
                }

                else if (option == 4)
                {
                    break;

                }
            }

        }

        static void print_maze(char[,] maze)
        {
            for (int x = 0; x < maze.GetLength(0); x++)
            {
                for (int y = 0; y < maze.GetLength(1); y++)
                {
                    Console.Write(maze[x, y]);
                }
                Console.WriteLine();
            }
        }

        static void loadMaze(ref string path, ref char[,] maze)
        {
            StreamReader file = new StreamReader(path);
            string record;
            int row = 0;

            while ((record = file.ReadLine()) != null)
            {
                for (int x = 0; x < 105; x++)
                {
                    if (record.Length > x)
                    {
                        maze[row, x] = record[x];
                    }
                }
                row++;
            }

            file.Close();
        }

        //player
        public static void print_Player(ref char[,] maze,ref char[,] player, ref MAN berzerk)
        {
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    Console.SetCursorPosition(berzerk.yPos + col, berzerk.xPos + row);
                    Console.Write(player[row, col]);
                    maze[row + berzerk.xPos, col + berzerk.yPos] = player[row, col];
                }

            }

        }
        //erase player
        public static void erase_Player(ref char[,] maze, ref char[,] player, ref MAN berzerk)
        {
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    Console.SetCursorPosition(berzerk.yPos + col, berzerk.xPos + row);
                    Console.Write(" ");
                    maze[row + berzerk.xPos, col + berzerk.yPos] =' ';
                }

            }

        }

        //enemy
        public static void print_enemy(ref char[,] maze, ref char[,] enemy, ref Enemy robo)
        {
            for (int row = 0; row < enemy.GetLength(0); row++)
            {
                for (int col = 0; col < enemy.GetLength(1); col++)
                {
                    Console.SetCursorPosition(robo.enemyY_pos + col, robo.enemyX_pos + row);
                    Console.Write(enemy[row, col]);
                    maze[row + robo.enemyX_pos, col + robo.enemyY_pos] = enemy[row, col];
                }

            }

        }
        //erase enemy
        public static void erase_enemy(ref char[,] maze, ref char[,] enemy, ref Enemy robo)
        {
            for (int row = 0; row < enemy.GetLength(0); row++)
            {
                for (int col = 0; col < enemy.GetLength(1); col++)
                {
                    Console.SetCursorPosition(robo.enemyY_pos + col, robo.enemyX_pos + row);
                    Console.Write(" ");
                    maze[row + robo.enemyX_pos, col + robo.enemyY_pos] =' ';
                }

            }
        }
        //move player left
      public static  void movetankleft(ref char[,] maze, ref char[,] player, ref MAN berzerk) // player movements start
        {
            char next = maze[berzerk.xPos, berzerk.yPos-1];
            char next2 = maze[berzerk.xPos+1 , berzerk.yPos -1];
            char next3 = maze[berzerk.xPos +2, berzerk.yPos-1 ];
            char next4 = maze[berzerk.xPos+3 , berzerk.yPos -1];
            if (next == ' ' && next2 == ' ' && next3 == ' ' && next4 == ' ')
            {
                erase_Player(ref maze, ref player, ref berzerk);
                berzerk.yPos--;
                print_Player(ref maze, ref player, ref berzerk);
            }
        }

        //move player right
        public static void movetankright(ref char[,] maze, ref char[,] player, ref MAN berzerk)
        {
            char next = maze[berzerk.xPos, berzerk.yPos + 4];
            char next2 = maze[berzerk.xPos + 1, berzerk.yPos + 4];
            char next3 = maze[berzerk.xPos + 2, berzerk.yPos + 4];
            char next4 = maze[berzerk.xPos + 3, berzerk.yPos + 4];
            if (next == ' ' && next2 == ' ' && next3 == ' ' && next4 == ' ')
            {
                erase_Player(ref maze, ref player, ref berzerk);
                berzerk.yPos++;
                print_Player(ref maze, ref player, ref berzerk);
            }
        }

        //move player up
        public static void movetankup(ref char[,] maze, ref char[,] player, ref MAN berzerk) // player movements start
        {
            char next = maze[berzerk.xPos - 1, berzerk.yPos];
            char next2 = maze[berzerk.xPos - 1, berzerk.yPos + 1];
            char next3 = maze[berzerk.xPos - 1, berzerk.yPos + 2];
            char next4 = maze[berzerk.xPos - 1, berzerk.yPos + 3];
            if (next == ' ' && next2 == ' ' && next3 == ' ' && next4 == ' ')
            {
                erase_Player(ref maze, ref player, ref berzerk);
                berzerk.xPos--;
                print_Player(ref maze, ref player, ref berzerk);
            }
        }
        //move player down
        public static void movetankdown(ref char[,] maze, ref char[,] player, ref MAN berzerk)
        {
            char next = maze[berzerk.xPos + 5, berzerk.yPos];
            char next2 = maze[berzerk.xPos + 5, berzerk.yPos + 1];
            char next3 = maze[berzerk.xPos + 5, berzerk.yPos + 2];
            char next4 = maze[berzerk.xPos + 5, berzerk.yPos + 3];
            if (next == ' ' && next2 == ' ' && next3 == ' ' && next4 == ' ')
            {
                erase_Player(ref maze, ref player, ref berzerk);
                berzerk.xPos++;
                print_Player(ref maze, ref player, ref berzerk);
            }
        }

        //enemy move up and down
        static void moveEnemyUp(ref string enemyDirection, ref char[,] maze, ref char[,] enemy, ref Enemy robo)
        {
            if (enemyDirection == "UP")
            {
                char next1 = maze[robo.enemyX_pos - 2, robo.enemyY_pos];
                char next2 = maze[robo.enemyX_pos - 2, robo.enemyY_pos + 1];
                char next3 = maze[robo.enemyX_pos - 2, robo.enemyY_pos + 2];
                char next4 = maze[robo.enemyX_pos - 2, robo.enemyY_pos + 3];
                if (next1 == ' ' || next1 == '*' && next2 == ' ' || next2 == '*' && next3 == ' ' || next3 == '*' && next4 == ' ' || next4 == '*')
                {
                    erase_enemy(ref maze, ref enemy, ref robo);

                    robo.enemyX_pos--;

                    print_enemy(ref maze, ref enemy, ref robo);
                }
                else
                {
                    enemyDirection = "Down";
                }
            }
            else if (enemyDirection == "Down")
            {

                char next1 = maze[robo.enemyX_pos + 5, robo.enemyY_pos];
                char next2 = maze[robo.enemyX_pos + 5, robo.enemyY_pos + 1];
                char next3 = maze[robo.enemyX_pos + 5, robo.enemyY_pos + 2];
                if (next1 == ' ' || next1 == '*' || next1 == '>' && next2 == ' ' || next2 == '>' || next2 == '*' && next3 == ' ' || next3 == '*' || next3 == '>')
                {
                    erase_enemy(ref maze, ref enemy, ref robo);

                    robo.enemyX_pos++;

                    print_enemy(ref maze, ref enemy, ref robo);
                }
                else
                {
                    enemyDirection = "UP";
                }
            }
        }
        // generate player bullets
      static  void generatebullet(ref Bullet[] fire,ref MAN player,ref int bulletCount,ref char[,]maze) 
        {
            char next = maze[player.xPos + 4, player.yPos + 1];
            if (next == ' ')
            {
                Bullet s1 = new Bullet();
                fire[bulletCount] = s1;
                fire[bulletCount].bulletX = player.xPos + 1;
                fire[bulletCount].bulletY = player.yPos + 4;
                fire[bulletCount].isbulletActive = true;
                Console.SetCursorPosition(player.yPos + 4,player.xPos + 1);
                Console.WriteLine(".");
                bulletCount++;
            }
        }
      public static void movebullet(ref char[,] maze, ref Bullet[] fire,ref int bulletCount)
        {
            for (int index = 0; index < bulletCount; index++)
            {
                if (fire[index].isbulletActive == true)
                {
                    char next = maze[fire[index].bulletX , fire[index].bulletY+1];
                    if (next != ' ' && next != '.')
                    {
                        eraseBullet(ref maze,fire[index].bulletX, fire[index].bulletY);
                        makebulletInActive(ref fire,index);
                    }
                    else
                    {
                        eraseBullet(ref maze, fire[index].bulletX, fire[index].bulletY);
                        fire[index].bulletY = fire[index].bulletY + 1;
                        printBullet(ref maze, fire[index].bulletX, fire[index].bulletY);
                    }
                }
            }
        }
    static  void makebulletInActive( ref Bullet[] fire,int z)
        {
            fire[z].isbulletActive = false;
        }
        static void eraseBullet(ref char[,] maze, int x, int y) // player  bullets ends
        {
            Console.SetCursorPosition(y, x);

            Console.WriteLine(" ");
            maze[x, y] = ' ';
        }
        static void printBullet(ref char[,] maze,int x, int y) // player  bullets ends
        {
            Console.SetCursorPosition(y, x);

            Console.WriteLine(".");
            maze[x, y] = '.';
        }

        // enemy1 bullets  generate for left side
      public static  void generateEnemy1Bullet(ref char[,] maze,ref EnemyBullet[] fires,ref Enemy robo,ref int EnemyBulletCoun) 
        {
            
           
                char next = maze[robo.enemyX_pos + 1, robo.enemyY_pos - 1];
                if (next == ' ')
                {
                EnemyBullet s1 = new EnemyBullet();
                fires[EnemyBulletCoun] = s1;
                fires[EnemyBulletCoun].eBulletX = robo.enemyX_pos + 1;
                fires[EnemyBulletCoun].eBulletY = robo.enemyY_pos - 1;
                fires[EnemyBulletCoun].iseBulletActive = true;
                    Console.SetCursorPosition(robo.enemyY_pos - 1, robo.enemyX_pos + 1);
                Console.Write("<");
                EnemyBulletCoun++;
                }

        }

        // enemy1 bullet movement
     public static   void moveEnemy1Bullet(ref char[,] maze, ref Enemy robo, ref MAN berzerk,ref EnemyBullet[] fires,ref int EnemyBulletCount) 
        {
            for (int y = 0; y <  EnemyBulletCount; y++)
            {
                if (fires[y].iseBulletActive == true)
                {
                    char next = maze[fires[y].eBulletX, fires[y].eBulletY - 1];
                    if (next != ' ' && next != '+')
                    {
                        eraseEnemyBullet(ref maze, fires[y].eBulletX, fires[y].eBulletY);
                        makeEnemyBulletInActive(ref fires ,y);
                    }
                    else
                    {
                        eraseEnemyBullet(ref maze, fires[y].eBulletX, fires[y].eBulletY);
                        fires[y].eBulletY = fires[y].eBulletY - 1;
                        printEnemyBullet(ref maze, fires[y].eBulletX, fires[y].eBulletY);
                    }
                }
            }
        }
       public static void eraseEnemyBullet(ref char[,] maze, int x,int y)
        {
            Console.SetCursorPosition(y, x);
            Console.WriteLine(" ");
            maze[x, y] = ' ';
        }
        public static void printEnemyBullet(ref char[,] maze, int x, int y)
        {
            Console.SetCursorPosition(y, x);
            Console.WriteLine("<");
            maze[x, y] = '<';
        }
      public static  void makeEnemyBulletInActive(ref EnemyBullet[] fires,int z)
        {
            fires[z].iseBulletActive = false;
        }

        //collision with enemy
    static    void collisionWithenemy(ref int bulletCount,ref Bullet[] fire,ref Enemy robo) // player bullets collision with enemy
        {
            for (int x = 0; x < bulletCount; x++)
            {
                if (fire [x].isbulletActive == true)
                {
                    if (fire[x].bulletX == robo.enemyX_pos - 1 && (fire[x].bulletY == robo.enemyY_pos || fire[x].bulletY == robo.enemyY_pos + 1 || fire[x].bulletY == robo.enemyY_pos + 2 || fire[x].bulletY == robo.enemyY_pos + 3 || fire[x].bulletY == robo.enemyY_pos + 4))
                    {
                        addScore();
                        enemyHealth();
                    }
                }
            }
        }
        //enenmy health
        static void printEHealth()
        {
            Console.SetCursorPosition(103, 10);
            Console.WriteLine("enemy-Health:{0} ", eHealth);
        }
        //enenmy health increasing
        static void enemyHealth()
        {
            eHealth--;
        }
        static void addScore()
        {
            score++;
        }
        static void printScore()
        {
            Console.SetCursorPosition(103, 11);
            Console.WriteLine("score: {0}  ", score);
        }
        // player health
        static void printPHealth()
        {
            Console.SetCursorPosition(103, 12);
            Console.WriteLine("playerHealth:{0} ", pHealth);
        }

        //player health increasing
        static void playerHealth()
        {
            pHealth--;
        }
      static  void enemyCollisionWithP(ref EnemyBullet[] fire,ref MAN berzerk ,ref int countB)
        {
            for (int index = 0; index < countB; index++)
            {
                if (fire[index].iseBulletActive == true)
                {
                    if (fire[index].eBulletX == berzerk.xPos + 4 && (fire[index].eBulletY == berzerk.yPos || fire[index].eBulletY == berzerk.yPos + 1 || fire[index].eBulletY == berzerk.yPos + 2 || fire[index].eBulletY == berzerk.yPos + 3))
                    {

                        playerHealth();
                    }
                    else if (berzerk.yPos + 4 == fire[index].eBulletY && (berzerk.xPos + 3 == fire[index].eBulletX || berzerk.xPos == fire[index].eBulletX || berzerk.xPos + 1 == fire[index].eBulletX || berzerk.xPos + 2 == fire[index].eBulletX))
                    {
                        playerHealth();
                    }
                }
            }
        }

        //player won the game
     static   void youWon()
        {
            Console.SetCursorPosition(15, 15);
            Console.WriteLine("#####################");
            Console.SetCursorPosition(15, 16);
            Console.WriteLine("-----------------------");
            Console.SetCursorPosition(15, 17);
            Console.WriteLine("*YOU LOST:YOUR SCORE: {0}*", score);
            Console.SetCursorPosition(15, 18);
            Console.WriteLine("-----------------------");
            Console.SetCursorPosition(15, 19);
            Console.WriteLine("-------GAME OVER------");
            Console.SetCursorPosition(15, 20);
            Console.WriteLine("#####################");
            Console.WriteLine("press any key to continue:");
            Console.ReadKey();

        }

        // player lost the game
        static void gameover()
        {
            Console.SetCursorPosition(15, 15);
            Console.WriteLine("#####################");
            Console.SetCursorPosition(15, 16);
            Console.WriteLine("-----------------------");
            Console.SetCursorPosition(15, 17);
            Console.WriteLine("*YOU LOST:YOUR SCORE: {0}*", score);
            Console.SetCursorPosition(15, 18);
            Console.WriteLine("-----------------------");
            Console.SetCursorPosition(15, 19);
            Console.WriteLine("-------GAME OVER------");
            Console.SetCursorPosition(15, 20);
            Console.WriteLine("#####################");
            Console.WriteLine("press any key to continue:");
            Console.ReadKey();

        }

        //starting functions
        static void sab_menu()
        {

            Console.Clear();
            Thread.Sleep(2000);
            top_header();
            Console.WriteLine("                  ");
            Console.WriteLine("-------------------");
            Console.WriteLine("press any key to continue:");
            Console.ReadKey();
            Console.Clear();
            submenu();
            Console.WriteLine("                  ");
            Console.WriteLine("-------------------");
            Console.WriteLine("Loading 30%");
            Thread.Sleep(1000);
            Console.Clear();
            submenu();
            Console.WriteLine("                  ");
            Console.WriteLine("-------------------");
            Console.WriteLine("Loading 90%");
            Thread.Sleep(1000);
            Console.Clear();
            submenu();
            Console.WriteLine("                  ");
            Console.WriteLine("-------------------");
            Console.WriteLine("Loading complete");
            Thread.Sleep(1000);
           
        }
        public static void submenu()
        {
            Console.WriteLine(" ____  ______ _____   ____________ _____   _  __");
            Console.WriteLine("|  _ \\|  ____|  __ \\ |___  /  ____|  __ \\ | |/ /");
            Console.WriteLine("| |_) | |__  | |__) |   / /| |__  | |__)  | ' / ");
            Console.WriteLine("|  _ <|  __| |  _  /   / / |  __| |  _  / |  <  ");
            Console.WriteLine("| |_) | |____| | \\ \\  / /__| |____| | \\ \\ | .\\ ");
            Console.WriteLine("|____/|______|_|  \\_\\/_____|______|_|  \\_\\_|\\_\\");
        }
        public static void instruction()
        {
            Console.WriteLine();
            submenu();
            Console.WriteLine("instruction:");
            Console.WriteLine("-------------------");
            Console.WriteLine();
            Console.WriteLine("beware of robots.");
            Console.WriteLine("firing on  all the robots it will increase your score");
            Console.WriteLine("press any key to continue:");
            Console.ReadKey();
            Thread.Sleep(300);
        }
       public static void key()
        {
            Console.WriteLine("KEY");
            Console.WriteLine(" ");
            Console.WriteLine( "---------------- - ");
            Console.WriteLine("1.for up movement of player            press up arrow key:");
            Console.WriteLine("2. for DOWN movement of player        press down arrow key:");
            Console.WriteLine("3. for Left movement of player         press left arrow key:");
            Console.WriteLine("4.for Rigt movement  of player        press Right arrow key:");
            Console.WriteLine("4.for firing  of player            press space :");
            Console.WriteLine("press any key to continue:");
            Console.ReadKey();
        }
        static void top_header()
        {


            Console.WriteLine("     ,,,,,,,,,,,    ");
            Console.WriteLine("     //////// \\\\\\ ");
            Console.WriteLine("    // ==     == \\\\ ");
            Console.WriteLine("     (  o    o  )\\\\         ");
            Console.WriteLine("      (    L    )\\\\            ");
            Console.WriteLine("       ( .___  )\\\\               ");
            Console.WriteLine("       \\_____/\\\\               ");
            Console.WriteLine("         |   |\\\\                    ");
            Console.WriteLine("  ------/  ^  \\----                ");
            Console.WriteLine(" /     ~~~o~~~~    \\                  ");
            Console.WriteLine("I         o         I                  ");
            Console.WriteLine("I    I     o     I    I                   ");
            Console.WriteLine("I   II     o     II   I                      ");
            Console.WriteLine(" I   II     o     II   I                     ");
            Console.WriteLine(" I   II     o     II   I                          ");
            Console.WriteLine("I   II     o     II   I                          ");
            Console.WriteLine("I   II     o     II  I                        ");
            Console.WriteLine("I__II%%%%%%@%%%%II__I                      ");
            Console.WriteLine(" 'm'I           I 'm'                              ");
            Console.WriteLine("    I           I                  ");
            Console.WriteLine("    I           I             ");
            Console.WriteLine("    I     i     I                ");
            Console.WriteLine("    I     I     I                 ");
            Console.WriteLine("    I     I     I                   ");
            Console.WriteLine("    I     I     I                      ");
            Console.WriteLine("     I____I____I                            ");
            Console.WriteLine("   __I    II   I__                       ");
            Console.WriteLine("  (_______II______)                         ");
        }
        public static void gameStart(ref string enemyDirection, ref char [,] enemy, ref char[,] player, ref char [,] maze, ref int EnemyBulletCount, ref EnemyBullet[] Fires, ref int bulletCount, ref Bullet[] fire, ref Enemy robo, ref MAN berzerk)
        {
            //print maze
            print_maze(maze);

            //print player
            print_Player(ref maze, ref player, ref berzerk);

            //print enemy
            print_enemy(ref maze, ref enemy, ref robo);

            //for running game
            while (true)
            {
                Thread.Sleep(90);
                if (eHealth <= 0)
                {
                    Console.Clear();
                    youWon();
                    Console.ReadKey();
                    break;
                }

                else if (pHealth <= 0)
                {
                    Console.Clear();
                    gameover();
                    Console.ReadKey();
                    break;
                }

                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    movetankright(ref maze, ref player, ref berzerk);
                }
                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    movetankup(ref maze, ref player, ref berzerk);
                }
                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    movetankleft(ref maze, ref player, ref berzerk);
                }
                if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    movetankdown(ref maze, ref player, ref berzerk);
                }
                if (Keyboard.IsKeyPressed(Key.Space))
                {
                    generatebullet(ref fire, ref berzerk, ref bulletCount, ref maze);
                }

                //player bullets move
                moveEnemyUp(ref enemyDirection, ref maze, ref enemy, ref robo);
                movebullet(ref maze, ref fire, ref bulletCount);

                ///bullets of enemy only generate when player is in front enemy
                if (berzerk.xPos + 1 == robo.enemyX_pos - 1 || berzerk.xPos == robo.enemyX_pos)
                {
                    generateEnemy1Bullet(ref maze, ref Fires, ref robo, ref EnemyBulletCount);
                }

                moveEnemy1Bullet(ref maze, ref robo, ref berzerk, ref Fires, ref EnemyBulletCount);
                // player bullets collision with enemy
                collisionWithenemy(ref bulletCount, ref fire, ref robo);

                //enemy bullets collision with player
                enemyCollisionWithP(ref Fires, ref berzerk, ref EnemyBulletCount);

                printScore();
                printEHealth();
                printPHealth();
            }
        }

    }
}
