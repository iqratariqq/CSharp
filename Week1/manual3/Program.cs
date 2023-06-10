using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace manual3
{
    class Program
    {
        public static int add(int num1,int num2)
        {
            return num1 + num2;
        }
        static void Main(string[] args)
        {
            //int num1, num2;
            //Console.WriteLine("enter a number1");
            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter number2");
            //num2 = int.Parse(Console.ReadLine());
            //int result;
            //result = add(num1, num2);
            //Console.WriteLine("the sum is {0}", result);
            //Console.ReadKey();
            readFile();
            //writeFile();
        }
        public static void readFile()
        {
            string path = "C:\\Users\\abdul sattar\\OneDrive\\Desktop\\OPP2\\WEEK1\\file.txt";
            if(File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string input;
                while((input=file.ReadLine()) != null)
                {
                    Console.WriteLine(input);
                    
                }
                file.Close();
            }
            else
            {
                Console.WriteLine("not exists ");
            }
            Console.ReadKey();
        }
        public static void writeFile()
        {
            string path= "C:\\Users\\abdul sattar\\OneDrive\\Desktop\\OPP2\\WEEK1\\file.txt";
            StreamWriter files = new StreamWriter(path,true);
            Console.WriteLine();
            files.WriteLine("my file");
            files.Flush();
            files.Close();
            Console.ReadKey();

        }
    }
}
