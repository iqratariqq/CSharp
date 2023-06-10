using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uams.BL
{
    class Student
    {
        public string name;
        public int age;
        public float fscMarks;
        public float ecatMarks;
        public float merit;
        List<DegreeProgram> prefrence;
        List<Subject> subjects;
        public DegreeProgram registerDeg;
        public Student (string name,int age,float fscMarks ,float ecatMarks,List<DegreeProgram> prefrence)
        {
            this.age = age;
            this.name = name;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            this.prefrence = prefrence;
        }
        public void calculateMerit()
        {

        }
        public int getCreditHours()
        {

        }
        public float calculateFee()
        {

        }
        public bool regStudentSubject(Subject s)
        {
            int stCH = getCreditHours();
            if(registerDeg!=null&&registerDeg.isSubjectExist(s)&&stCH+s.creditHours<=9)
            {
                subjects.Add(s);
                return true;
            }
            return false;
        }
        public void viewSubject()
        {

        }
    }      


} 
    