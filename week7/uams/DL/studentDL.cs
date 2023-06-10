using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using uams.BL;

namespace uams.DL
{
    class studentDL
    {
       public static List<Student> studentList = new List<Student>();

        public static void storeStudentInList(Student s)
        {
            studentList.Add(s);
        }

        public static List<Student> sortStudentsByMerit()
        {
            List<Student> sortedStudentList = new List<Student>();
            foreach (Student stu in studentList)
            {
                stu.calculateMerit();
            }
            sortedStudentList = studentList.OrderByDescending(o => o.merit).ToList();
            return sortedStudentList;

        }
        public   static void giveAdmission(List<Student> sortedStudentList)
        {
            foreach (Student stu in sortedStudentList)
            {
                foreach (DegreeProgram D in stu.prefrence)
                {
                    if (stu.registerDeg == null && D.seats > 0)
                    {
                        stu.registerDeg = D;
                        D.seats--;
                        break;
                    }
                }
            }
        }

        public static void storeIntoFile(Student s)
        {
            string path = "student.txt";
            StreamWriter f = new StreamWriter(path, true);
            string degreeNames = "";
            for (int x = 0; x < s.prefrence.Count-1; x++)
            {
                degreeNames = degreeNames + s.prefrence + ";";
            }
            degreeNames = degreeNames + s.prefrence[s.prefrence.Count - 1].titelD;
            f.WriteLine(s.name + "," + s.age + "," + s.fscMarks + "," +","+s.ecatMarks+","+ degreeNames);
            f.Flush();
            f.Close();

        }
        public static bool readDataFromFile()
        {
            string path = "student.txt";
            StreamReader f = new StreamReader(path, true);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string Name = splittedRecord[0];
                    int age = int.Parse(splittedRecord[1]);
                    int fscMarks = int.Parse(splittedRecord[2]);
                    int ecatMarks = int.Parse(splittedRecord[3]);
                    string[] splittedRecordforSubject = splittedRecord[4].Split(';');
                    List<DegreeProgram> pref = new List<DegreeProgram>();
                    for (int x = 0; x < splittedRecordforSubject.Length; x++)
                    {
                        DegreeProgram d = degreeProgramDL.isDegreeExist(splittedRecordforSubject[x]);
                        if (d != null)
                        {
                            if (!(pref.Contains(d)))
                            {
                                pref.Add(d);

                            }
                        }
                    }
                    Student s = new Student(Name, age, fscMarks, ecatMarks, pref);
                    storeStudentInList(s);
                }
                f.Close();
                return true;
            }
            return false;
        }

    }
}
