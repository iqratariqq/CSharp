using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //check_PF();
            //for_Loop();
            //While_Loop();
            //Do_While_Loop();
            Arr();
        }
        public static void check_PF()
        {
            float marks;
            Console.WriteLine("enter your marks:");
            marks = float.Parse(Console.ReadLine());
            if(marks>=50)
            {
                Console.WriteLine("you are pass :)");
            }
            else
            {
                Console.WriteLine("you fail(:");
            }
            Console.ReadKey();
        }
        public static void for_Loop()
        {
            for(int x=0;x<=5;x++)
            {
                Console.WriteLine("welcom iqra:");
           
            }
            Console.Read();
        }
        public static void While_Loop()
        {
            int number=0;
            int sum = 0;
            Console.WriteLine("enter a numebr:");
          
            while(number!=-1)
            {
                sum = sum + number;
                number = int.Parse(Console.ReadLine());
            
            }
            Console.WriteLine("the sum is: {0}", sum);
            Console.ReadKey();
        }
        public static void Do_While_Loop()
        {
            int sum = 0;
            int number = 0;
            Console.WriteLine("enter a number:");
         
            do
            {

                sum = sum + number;
                number = int.Parse(Console.ReadLine());
            }
            while (number != -1);
            Console.WriteLine("sum is : {0}", sum);
            Console.ReadKey();
            
        }
        public static void Arr()
        {
            int[] arr = new int[3];
            int number, large=0;
            Console.WriteLine("enter a number:");
            for (int index = 0; index < 3; index++)
            {
                number = int.Parse(Console.ReadLine());
                if(large<number)
                {
                    large = number;
                }
            }
            Console.WriteLine("the large number is {0}", large);
            Console.ReadKey();
        }
    }
}
