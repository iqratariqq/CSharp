using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMAS.BL;

namespace UMAS.DL
{
    class DegreeDL
    {
        public  static List<Subject> subjects;

     public   DegreeDL()
        {
            subjects = new List<Subject>();
        }

        public static int calculateCreditHour()
        {
            int craditHour = 0;
            foreach (Subject storeCradit in subjects)
            {
                craditHour += storeCradit.creditHour;
            }
            return craditHour;
        }
        public static bool AddSbject(Subject s)
        {
            int creditHour = calculateCreditHour();
            if (creditHour + s.creditHour <= 20)
            {
                subjects.Add(s);
                return true;
            }
            return false;
        }
        public static bool isSubjectExist(Subject sub)
        {
            foreach (Subject storesubject in subjects)
            {
                if (storesubject.code == sub.code && storesubject.type == sub.type)
                {
                    return true;
                }
            }
            return false;
        }
    }

}
