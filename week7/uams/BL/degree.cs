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
        public int duration;
        public int seats;
       public List<Subject> subjects;

        public DegreeProgram(string titelD)
        {
            this.titelD = titelD;
        }
        public DegreeProgram(string titelD, int duration, int seats)
        {
            this.titelD = titelD;
            this.duration = duration;
            this.seats = seats;
            subjects = new List<Subject>();
        }
        public int calculateCreditHour()
        {
            int craditHour = 0;
            foreach(Subject sub in subjects)
            {
                craditHour = craditHour + sub.creditHours;
            }
            return craditHour;

        }
        public bool isSubjectExist(Subject sub)
        {
            foreach(Subject s in subjects)
            {
                if(s.subjectType==sub.subjectType&&s.code==sub.code)
                {
                    return true;
                }
            }
          return false;
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
