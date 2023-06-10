using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2b.BL
{
    class Student
    {
        public Student(string name, float M1, float F1, float E1)
        {
            sname = name;
            matricMarks = M1;
            fscMarks = F1;
            ecatMarks = E1;
        }
        public string sname;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;

    }
}
