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
        public List<DegreeProgram> prefrence = new List<DegreeProgram>();
      public  List<Subject> regsubjects;
        public DegreeProgram registerDeg;
        public Student(string name, int age, float fscMarks, float ecatMarks, List<DegreeProgram> prefrence)
        {
            this.age = age;
            this.name = name;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            this.prefrence = prefrence;
        }
        public void calculateMerit()
        {
            this.merit=(((fscMarks/1100)*60)+((ecatMarks/400)*40));
        }
        public int getCreditHours()
        {
            int creditHour = 0;
            foreach(Subject s in regsubjects)
            {
                creditHour = s.creditHours + creditHour;
            }
            return creditHour;

        }
        public float calculateFee()
        {
            float fee=0.0f;
            if(registerDeg!=null)
            {
                foreach(Subject sub in regsubjects)
                {
                    fee = fee + sub.subjectFee;
                }
            }
            return fee;
            
        }
        public bool regStudentSubject(Subject s)
        {
            int stCH = getCreditHours();
            if (registerDeg != null && registerDeg.isSubjectExist(s) && stCH + s.creditHours <= 9)
            {
                regsubjects.Add(s);
                return true;
            }
            return false;
        }
    }
}
