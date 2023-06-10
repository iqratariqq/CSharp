using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uams.BL;

namespace uams.UI
{
    class studentUI
    {
        //degreeUI object
        degreeProgramUI degree = new degreeProgramUI();
        public Student takeInPutForStudent(List<DegreeProgram> programList)
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
            degree.viewProgram(programList);
            Console.WriteLine("enter how many pref you want to add");
            int prefNum = int.Parse(Console.ReadLine());
            Console.WriteLine("enter preference");
            for (int x = 0; x < prefNum; x++)
            {
                string prefer = Console.ReadLine();
                bool flag = false;
                foreach (DegreeProgram d in programList)
                {
                    if (prefer == d.titelD && !(pref.Contains(d)))
                    {
                        pref.Add(new DegreeProgram(prefer));
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("enter valid degree name:");
                }

            }
            Student student = new Student(name, age, fscMarks, ecatMarks, pref);
            return student;
        }

        public  void printStudents(List<Student> studentList)
        {
            foreach (Student s in studentList)
            {
                if (s.registerDeg != null)
                {
                    Console.WriteLine("student {0} got admission in ", s.name, s.registerDeg.titelD);
                }
                else
                {
                    Console.WriteLine("student {0} got admission in ", s.name);
                }
            }
        }

        public  void viewRegisteredStudents(List<Student> studentList)
        {
            Console.WriteLine("name\t\tage\t\tfscMarks\t\tecatMarks\t\t");
            foreach (Student s in studentList)
            {
                if (s.registerDeg != null)
                {
                    Console.WriteLine(s.name + "\t\t" + s.age + "\t\t" + s.fscMarks + "\t\t" + s.ecatMarks + "\t\t" + s.merit);
                }
            }
        }

        public  void CalculateFeeFoeAll(List<Student> students)
        {
            foreach (Student s in students)
            {
                if (s.registerDeg != null)
                {

                    Console.WriteLine("student " + s.name + "has fee" + s.calculateFee());
                }
            }
        }

        public  Student isStudentPresent(string nameStu, List<Student> studentList)
        {
            foreach (Student s in studentList)
            {
                if (s.name == nameStu && s.registerDeg != null)
                {
                    return s;

                }
            }
            return null;
        }

        public  void viewStudentInDegree(string nameStu, List<Student> studentList)
        {
            foreach (Student s in studentList)
            {
                if (nameStu == s.name && s.registerDeg != null)
                {
                    Console.WriteLine("student" + s.name + " got admission in " + s.registerDeg.titelD);

                }
            }

        }
    }
}
