using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uams.BL;

namespace uams
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            List<DegreeProgram> programList = new List<DegreeProgram>();

            int option = 0;
            do
            {
                option = menu();
                Console.Clear();
                if(option==1)
                {
                    DegreeProgram d = takeInputforDegree();

                }
                else if(option==2)
                {
                    if (programList.Count > 0)
                    {
                        Student s = takeInputForStudent();
                        addIntoStudentList(studentList, s);
                    }

                }
                else if(option==3)
                {
                    storeStudentsByMerit();
                    giveAdmission();
                    printStudent();
                }
                else if(option==4)
                {
                    viewRegisteredStudents();
                }
                else if(option==5)
                {
                    string degName;
                    Console.Write("enter Degree name: ");
                    degName = Console.ReadLine();
                    viewStudentInDegree(degName);

                }
                else if(option==6)
                {
                    Console.Write("Enter the Student Name: ");
                    string name = Console.ReadLine();
                    Student s = StudentPresent(name);
                    if(s!=null)
                    {
                        s.viewSubject();
                        registerSubject(s);
                    }
                }
                else if(option==7)
                {
                    calculateFee();
                }
            }
            while (option != 8);
            Console.ReadKey();

        }
    }
}
