using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uams.BL;
using uams.UI;
using uams.DL;

namespace uams
{
    class Program
    {
        static void Main(string[] args)
        {

if(subjectDL.readFromFile())
            {
                Console.WriteLine("subject data exist");
            }

            if (studentDL.readDataFromFile())
            {
                Console.WriteLine("student data exist");
            }
            if (degreeProgramDL.readDataFromFile())
            {
                Console.WriteLine("degree data exist");
            }
            // menu object
            MenuUI menus = new MenuUI();

            //degreeprogram UI object
            degreeProgramUI degree = new degreeProgramUI();

            //studentUI object
            studentUI student = new studentUI();

            //subject object
            subjectUI subjectui = new subjectUI();

            int option;
            do
            {
                option = menus. menu();
                if (option == 1)
                {
                    DegreeProgram d =degree. takeInPutForDegree();
                    degreeProgramDL.addDegreeInList( d);
                    degreeProgramDL.storeIntoFile(d);
                }
                else if (option == 2)
                {
                    Student s = student. takeInPutForStudent(degreeProgramDL.programList);
                    studentDL. storeStudentInList(s);
                    studentDL.storeIntoFile(s);
                }
                else if (option == 3)
                {
                    List<Student> sortedStudents = new List<Student>();
                    sortedStudents = studentDL.sortStudentsByMerit();
                    studentDL. giveAdmission(sortedStudents);
                    student. printStudents(sortedStudents);
                }
                else if(option==4)
                {
                    student. viewRegisteredStudents(studentDL.studentList);
                }
                else if(option==5)
                {
                    Console.WriteLine("enter student name");
                    string nameStu = Console.ReadLine();
                    student. viewStudentInDegree(nameStu, studentDL.studentList);

                }
                else if(option==6)
                {
                    Console.WriteLine("enter student name");
                    string nameStu = Console.ReadLine();
                    Student s = student. isStudentPresent(nameStu, studentDL.studentList);
                    subjectui. registerSubject(s);
                }
                else if(option==7)
                {
                    student.CalculateFeeFoeAll(studentDL.studentList);
                }
            } while (option != 8);


        }





        }
    }
