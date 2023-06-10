
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using management.BL;

namespace management
{
    class Program
    {
        static void Main(string[] args)
        {
            Students[] s1 = new Students[10];
            int count = 0;
            char option;


            do
            {
                 option = sub_menu();
                if (option=='1')
                {
                   s1[count]= add_student();
                    count++;
                }
                else if (option == '2')
                {
                    view_studnets(s1, count);
                }
                else if (option == '3')
                {
                    view_Top_Student(s1, count);
                }
                else if (option == '4')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("invalid Input:");

                }

            }
            while (option != 4);
            Console.ReadKey();
         

        }
        static char sub_menu()
        {
            char option;
            Console.WriteLine("1.Add student");
            Console.WriteLine("2.view all students");
            Console.WriteLine("3.view top 3 students");
            Console.WriteLine("4.exit");
            option = char.Parse(Console.ReadLine());
            return option;

        }
        static Students add_student()
        {
            Console.Clear();
            Students s = new Students();
            Console.WriteLine("entre name:");
            s.name = Console.ReadLine();
            Console.WriteLine("entre roll no:");
            s.rol_no = int.Parse(Console.ReadLine());
            Console.WriteLine("entre cgpa:");
            s.cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine("entre department:");
            s.department = Console.ReadLine();
            Console.WriteLine("are you hostelide(y||n:");
            s.isHostelide = char.Parse(Console.ReadLine());
            return s;
        }
        static void view_studnets(Students[] s1,int count)
        {
            Console.Clear();
for(int x=0;x<count;x++)
            {
                Console.WriteLine("name {0}: roll no {1}: cgpa {2}: hostelide {3}: Department{4}", s1[x].name, s1[x].rol_no, s1[x].cgpa, s1[x].isHostelide, s1[x].department);
            }
            Console.ReadKey();
        }

        static void view_Top_Student(Students[] s1, int count)
        {
            Console.Clear();
            if(count==0)
            {
                Console.WriteLine("no student found");
                Console.ReadKey();
            }
          else  if(count==1)
            {
                view_studnets(s1, count);
            }
            else if(count==2)
            {
                for(int x=0;x<count;x++)
                {
                    int index = largest(s1, x, count);
                    Students temp = s1[index];
                    s1[index] = s1[x];
                    s1[x] = temp;
                    view_studnets(s1, 2);
                    view(x);
                } 
            }
            else
            {
                for (int x = 0; x < count; x++)
                {
                    int index = largest(s1, x, count);
                    Students temp = s1[index];
                    s1[index] = s1[x];
                    s1[x] = temp;
                    view_studnets(s1, 3);
                }
            }
         
        }
        static void view(int start)
        {
            Console.WriteLine(start);
        }
        static int largest(Students[] s1,int start,int end)
        {
            int index = start;
            float large = s1[start].cgpa;
            for(int x=start;x<end;x++)
            {
   
                if(large<s1[x].cgpa)
                {
                    large = s1[x].cgpa;
                    index = x;
                }
            }
            return index;
        }

    }
}
