﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMAS.BL
{
    class Student
    {
        public string name;
        public int age;
        public double fscMarks;
        public double ecatMarks;
        public double  merit;
/*      public  List<DegreeProgram> preferences;
        public List<Subject> regSubject;*/
        public DegreeProgram regDegree;
        public Student(string name, int age, double fscMarks, double ecatMarks)
        {
            this.name = name;
            this.age = age;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
           /* this.preferences = preferences;*/
        }
        public void CalculateMerit()
        {
            this.merit = (((fscMarks / 1100) * 0.45f) + (ecatMarks / 400) * 0.55) * 100;
        }
        /*ublic bool regStudentSubject(Subject s)
        {
            int stCh = getCreditHour();
            if (regDegree != null && regDegree.isSubjectExist(s) && stCh + s.creditHour <= 9)
            {
                regSubject.Add(s);
                return true;
            }
            return false;
        }
        public int getCreditHour()
        {
            int count = 0;
            foreach (Subject sub in regSubject)
            {
                count = count + sub.creditHour;
            }
            return count;
        }
        public float calculateFee()
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
        }*/

    }
}
