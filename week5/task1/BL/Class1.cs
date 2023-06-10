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
        public int rolNumber;
        public float cGpa;
        public int fscMarks;
        public int ecatMarks;
        public int matricMarks;
        public string homeTown;
        public bool isAvailScholership;
        public Student(int fscMarks,int ecatMarks)
        {
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
        }
        public Student(string name, int rolNumber, float cGpa, int fscMarks, int ecatMarks, int matricMarks, string homeTown)
        {
            this.name = name;
            this.rolNumber = rolNumber;
            this.cGpa = cGpa;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            this.matricMarks = matricMarks;
            this.homeTown = homeTown;            
        }
        public float calculateMerit()
        {
            float Merit;
            Merit = (((fscMarks / 1100) * 60) + ((ecatMarks / 400) * 40));
            return Merit;
        }
        public bool isEligibleForScholerShip(float meritPercentage)
        {
            if (meritPercentage >= 80.0)
            {
                return true;
            }
            else
                return false;
        }

        public bool isHostelite(string inform)
        {
            if (inform == "yes")
            {
                return true;
            }
            else
                return false;
        }
    }
}
