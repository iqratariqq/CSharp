using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMAS.BL;
using UMAS.DL;
using UMAS.UL;

namespace UMAS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studens = new List<Student>();
            List<DegreeProgram> programs = new List<DegreeProgram>();
            int option;
            do
            {
                topHeader();
                option = menu();
                ClearScreen();
                if (option == 1)
                {
                    Student s = takeInPutForStudent(programs);
                    storeStudentInList(s, studens);
                }
                else if (option == 2)
                {
                    DegreeProgram d = takeInputForDegree();
                    Subject s = takeInPutForSubject();
                }
                else if(option==3)
                {
                    List<Student> sortedStudentList = new List<Student>();
                    sortedStudentList = sortStudentsByMerit(studens);
                    giveAdmission(sortedStudentList);
                    printStudents(studens);
                }
                else if(option==4)
                {
                    viewRegisteredStudents(studens);
                }
                else if(option==5)
                {
                    string degName;
                    Console.WriteLine("enter degree Name");
                    degName = Console.ReadLine();
                    viewStudentInDegree(degName,studens);
                }
                else if (option==6)
                {
                    Console.WriteLine("enter the Student Name: ");
                    string name = Console.ReadLine();
                    Student s = StudentPresent(name,studens);
                    if(s!=null)
                    {
                        viewSubjects(s);
                        registerSubjects(s);
                    }
                }
                else if(option==7)
                {
                    calculateFeeForAll(studens);
                }
                ClearScreen();
            }
            while (option != 8);
        }
/*        public static int menu()
        {
            Console.WriteLine("1.add degree");
            Console.WriteLine("2.add student");
            Console.WriteLine("3.generate Merit");
            Console.WriteLine("4.view Registered Students");
            Console.WriteLine("5.view Student for a Specific program");
            Console.WriteLine("6.Register Subjects for a Specific Student");
            Console.WriteLine("7.Calculate fees for all registered students");
            Console.WriteLine("8.Exit");
            int option = int.Parse(Console.ReadLine());
            return option;

        }
        public static Student StudentPresent(string name,List<Student> students)
        {
            foreach(Student s in students)
            {
                if(name==s.name&& s.regDegree!=null)
                {
                    return s;
                }
            }
            return null;
        }
        public static Student takeInPutForStudent(List<DegreeProgram> programList)
        {
            List<DegreeProgram> pref = new List<DegreeProgram>();
            Console.WriteLine("enter student name: ");
            string name = Console.ReadLine();
            Console.WriteLine("enter student age: ");
           int age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter student fscMarks: ");
            float fscMarks = float.Parse(Console.ReadLine());
            Console.WriteLine("enter student ecatMarks: ");
            float ecatMarks = float.Parse(Console.ReadLine());
            viewDegreeProgram(programList);
            Console.WriteLine("enter how many pref you want to add");
            int prefNum = int.Parse(Console.ReadLine());
            
            for(int x=0; x<prefNum;x++)
            {
                Console.WriteLine("enter your pref:");
                string prefer = Console.ReadLine();
                bool flag = false;
                foreach(DegreeProgram dp in programList)
                {
                    if (prefer == dp.degreeName&&!(pref.Contains(dp)))
                    {
                        pref.Add(new DegreeProgram(prefer));
                        flag =true;
                    }
                }
                if(flag==false)
                {
                    Console.WriteLine("enter valid degree name:");
                }
               
            }
            Student student = new Student(name, age, fscMarks, ecatMarks, pref);
            return student;
        }
        public static void viewDegreeProgram(List<DegreeProgram> programList)
        {
            foreach(DegreeProgram dp in programList)
            {
                Console.WriteLine(dp.degreeName);
            }
        }
        public static void storeStudentInList(Student s,List<Student> students)
        {
            students.Add(s);
        }
        public static void registerSubjects( Student s)
        {
            Console.WriteLine("enter how manu subjects you want to register");
            int count = int.Parse(Console.ReadLine());
            for(int x=0; x<count;x++)
            {
                Console.WriteLine("enter the subject code");
                string code = Console.ReadLine();
                bool flag = false;
                foreach(Subject sub in s.regDegree.subjects)
                {
                    if (code == sub.code && !(s.regSubject.Contains(sub))) ;
                    s.regStudentSubject(sub);
                    flag =true;
                    break;
                }
                if(flag==false)
                {
                    Console.WriteLine("enter valid course");
                    x--;
                }
            }
        }
        public static DegreeProgram takeInputForDegree()

        {
            List<Subject> subjects = new List<Subject>();
            Console.WriteLine("enter degree name: ");
            string name = Console.ReadLine();
            Console.WriteLine("enter degree Duration: ");
            int duration = int.Parse(Console.ReadLine());
            Console.WriteLine("enter Seats for Degree: ");
            int seat = int.Parse(Console.ReadLine());
            DegreeProgram program = new DegreeProgram(name, duration,seat);
            Console.WriteLine("enter how many subject you want to add");
            int subNum = int.Parse(Console.ReadLine());
            for (int x = 0; x < subNum; x++)
            {
                program.AddSbject(takeInPutForSubject());
            }
                return program;

        }
        public static Subject takeInPutForSubject()
        {
          
                Console.WriteLine("enter subject code:");
                string code = Console.ReadLine();
                Console.WriteLine("enter subject type:");
                string type = Console.ReadLine();
                Console.WriteLine("enter subject cradit hours:");
                int hour = int.Parse(Console.ReadLine());
                Console.WriteLine("enter subject fee:");
                int fee = int.Parse(Console.ReadLine());
                Subject subject= new Subject(code, type, hour, fee);
            return subject;
        }
        public static void addDegreeInList(List<DegreeProgram> programs,DegreeProgram program)
        {
            programs.Add(program);
        }
public static List<Student> sortStudentsByMerit(List<Student> studentList)
        {
            List<Student> sortedStudentList = new List<Student>();
            foreach(Student s in studentList)
            {

                s.CalculateMerit();
            }
            sortedStudentList = studentList.OrderByDescending(o => o.merit).ToList();
            return sortedStudentList;
        }
        static void giveAdmission(List<Student> sortedStudentList)
        {
            foreach(Student s in sortedStudentList)
            {
                foreach(DegreeProgram d in s.preferences)
                {
if (d.seats>0&&s.regDegree==null)
                    {
                        s.regDegree = d;
                        d.seats--;
                        break;
                    }
                }
            }
        }
        public static void printStudents(List<Student> studentList)
        {
            foreach(Student s in studentList)
            {
                if(s.regDegree!=null)
                {
                    Console.WriteLine(s.name + "got Admission in " + s.regDegree.degreeName);
                }
                else
                {
                    Console.WriteLine(s.name + "did not get admission");
                }
            }
        }
        static void ClearScreen()
        {
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        static void viewStudentInDegree(string degrName,List<Student> studentList)
        {
            Console.WriteLine("name\t\tFSC\t\tAge");
            foreach(Student s in studentList)
            {
                if(s.regDegree!=null)
                {
                    if(degrName==s.regDegree.degreeName)
                    {
                        Console.WriteLine(s.name + "\t\t" + s.fscMarks + "\t\t" + s.age);
                    }
                }
            }
        }
        static void viewRegisteredStudents(List<Student> students)
        {
            Console.WriteLine("name\t\tfsc\t\tEcat\t\tage");
            foreach(Student s in students)
            {
                if(s.regDegree!=null)
                {
                    Console.WriteLine(s.name + " " + s.fscMarks + " " + s.ecatMarks + " " + s.age);
                }
            }
        }
        static void topHeader()
        {
            Console.WriteLine("************************************");
            Console.WriteLine("            UAMS                      ");
            Console.WriteLine("************************************");
        }
        static void viewSubjects(Student s)
        {
if(s.regDegree!=null)
            {
                Console.WriteLine("Sub Code\tSub Type");
                foreach(Subject sub in s.regDegree.subjects)
                {
                    Console.WriteLine(sub.code + "\t\t" + sub.type);
                }
            }
        }
        static void calculateFeeForAll(List<Student> Students)
        {
            foreach(Student s in Students)
            {
                if(s.regDegree!=null)
                {
                    Console.WriteLine(s.name + "has " + s.calculateFee() + " Fees");
                }
            }
        }*/
    }
}
