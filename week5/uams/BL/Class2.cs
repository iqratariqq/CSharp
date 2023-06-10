using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uams.BL
{
    class DegreeProgram
    {
        public string titelD;
        public string duration;
        public int seats;
        List<Subject> subjects;
        public DegreeProgram(string titelD, string duration, int seats, List<Subject> subjects)
        {
            this.titelD = titelD;
            this.duration = duration;
            this.seats = seats;
            this.subjects = subjects;
        }
        public int calculateCreditHour()
        {

        }
        public bool isSubjectExist(Subject sub)
        {

        }
        public bool AddSubject(Subject s)
        {
            int creditHour = calculateCreditHour();
            if (creditHour + s.creditHours <= 20)
            {
                subjects.Add(s);
                return true;
            }
            else
                return false;
        }
    }
}
