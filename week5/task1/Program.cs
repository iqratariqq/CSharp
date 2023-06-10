using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.BL;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int option;

            
            do
            {
                option = menu();
                if (option == 1)
                {
                    Student student = takeInput();
                    string inform = hostelInformation();
                    student.isHostelite(inform);
                    informationStoreInList(student, students);
                }

                else if (option == 2)
                    {
                    //Console.WriteLine("Enter your fsc marks:");
                    //int fscMarks = int.Parse(Console.ReadLine());
                    //Console.WriteLine("Enter your ecat marks:");
                    //int ecatMarks = int.Parse(Console.ReadLine());
                    Student studentM=takeInputForAggre(students);
                    if (studentM == null)
                    {
                        Console.WriteLine("user not found");
                    }
                    else
                    {
                        Student student = new Student(studentM.fscMarks, studentM.ecatMarks);
                        float merit = student.calculateMerit();
                        bool isCheck = student.isEligibleForScholerShip(merit);
                        checkScholerShipStatus(isCheck);
                    }
                    }
                
            } while (option != 3);

            Console.ReadKey();


        }
        public static int menu()
        {
            Console.WriteLine("1.enter inforation about yourself");
            Console.WriteLine("2.check your scholerShip information:");
            Console.WriteLine("3.exit");
            int option = int.Parse(Console.ReadLine());
            return option;
            
        }
        public static Student  takeInput()
        {
            Console.WriteLine("enter your name:");
            string name = Console.ReadLine();
           Console.WriteLine("enter your rolnumber:");
            int rol = int.Parse(Console.ReadLine());
            Console.WriteLine("enter your cgpa");
            float cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine("enter your fscmarks");
            int marks2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter your ecat marks");
            int marks3 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter your matricmarks");
            int marks1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter your home town name");
            string nameT = Console.ReadLine();

            Student student = new Student(name, rol, cgpa, marks2, marks3, marks1, nameT);
            return student;


        }
        public static string hostelInformation()
        {
            Console.WriteLine("are you hostelite?yes or no");
            string inform = Console.ReadLine();
            Console.ReadKey();
            return inform;
        }
        public static void informationStoreInList( Student student,List<Student> students)
        {
            students.Add(student);
        }
        public static void checkScholerShipStatus(bool isCHeck)
        {
            if(isCHeck==true)
            {
                Console.WriteLine("yes you are availing scholerShip:");
            }
            else if(isCHeck==false)
            {
                Console.WriteLine("no you are not availing scholerShip:");
            }
            Console.ReadKey();
                
        }
        public static Student takeInputForAggre(List<Student>students)
        {
            Console.WriteLine("enter you name:");
            string name = Console.ReadLine();
            Console.WriteLine("enter your rollnu");
            int rolNo = int.Parse(Console.ReadLine());
            foreach(Student storedStudent in students )
            {
                if(storedStudent.name==name&& storedStudent.rolNumber==rolNo)
                {
                    return storedStudent;
                }
            }
            return null;
        }
    }
}
