using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.BL
{
    class Student
    {
        public string name;
        public string session;
        public bool isDayScholer;
        public double entryMarks;
        public double HSMarks;


        public double calculateMerit()
        {
            double merit = 0.0;
            merit = ((entryMarks / 400.0) * 30.0 + ((HSMarks / 1100.0) * 70.0));
            return merit;
        }
    }
}
