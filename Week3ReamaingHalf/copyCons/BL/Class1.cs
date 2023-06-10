using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copyCons.BL
{
    class Student
    {
        public Student()
        {
            Console.WriteLine("defult const:");
        }
        public Student(Student s)
        {
            sname = s.sname;
            matricMarks =s.matricMarks;
            fscMarks = s.fscMarks;
            ecatMarks = s.ecatMarks;
        }


        public string sname;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;

    }
}
