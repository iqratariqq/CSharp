using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMAS.BL;


namespace UMAS.DL
{
    class StudentDL
    {
       public static List<Student> studens = new List<Student>();
        public static List<DegreeProgram> preferences;
        public static List<Subject> regSubject;
        public static DegreeProgram regDegree;
        public static bool regStudentSubject(Subject s)
        {
            int stCh = getCreditHour();
            if (regDegree != null && DegreeDL.isSubjectExist(s) && stCh + s.creditHour <= 9)
            {
                regSubject.Add(s);
                return true;
            }
            return false;
        }
        public static int getCreditHour()
        {
            int count = 0;
            foreach (Subject sub in regSubject)
            {
                count = count + sub.creditHour;
            }
            return count;
        }
        public static float calculateFee()
        {
            float fee = 0;
            if (regDegree != null)
            {
                foreach (Subject sub in regSubject)
                {
                    fee = fee + sub.subjectFee;
                }
            }
            return fee;
        }
        public static void storeStudentInList(Student s)
        {
            studens.Add(s);
        }


    }
}

