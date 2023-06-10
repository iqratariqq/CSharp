using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //task1();
            //task2();
            //task3();
            //task4();
            //task5();
            //task6();
            //Input1(); // taking input in the form of int
            //Input(); //taking input in the form of string
            /*inputF();*/ //taking input as a float
            calulate_Length();
        }
        public static void task1()
        {
            Console.Write("HELLO WORLD!");
            Console.Write("HELLO WORLD!");
            Console.Read();
        }
        public static void task2()
        {
            Console.WriteLine("HELLO WORLD!!");
            Console.WriteLine("HELLO WORLD!!");
            Console.ReadKey();

        }
        public static void task3()
        {
            int data = 7;
            Console.WriteLine("you have entered this" + data);
            Console.ReadKey();

        }
        public static void task4()
        {
            string name = "IQRA TARIQ";
            Console.Write("my name is {0}", name);
            Console.Read();
        }
        public static void task5()
        {
            char word = 'A';
            Console.WriteLine("world is:");
            Console.Write(word);
            Console.Read();
        }
        public static void task6()
        {
            float decimel = 7.5f;
            Console.WriteLine("Float is :");
            Console.Write(decimel);
            Console.Read();
        }
        public static void Input1()
        {
            int number;
            Console.WriteLine("enter a number:");
            number = int.Parse(Console.ReadLine());
            Console.Write("you entred {0}:",number);
            Console.Read();
        }
        public static void Input()
        {
            string sen;
            Console.WriteLine("enter a stirng:");
            sen = Console.ReadLine();
            Console.Write("you write this  "+  sen);
            Console.ReadKey();
        }
        public static void inputF()
        {
            float deci;
            Console.WriteLine("decimal:");
            deci = float.Parse(Console.ReadLine());
            Console.Write(deci);
            Console.ReadKey();
        }
       public static void  calulate_Length()
        {
            float length;
            Console.WriteLine("enter the length of the sqr:");
            length = float.Parse(Console.ReadLine());
          float area;
            area = length * length;
            Console.WriteLine("the area of sqr is {0}", area);
            Console.ReadKey();

        }

    }
}
