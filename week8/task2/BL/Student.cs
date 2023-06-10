using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.BL
{
    class Staff:Person
    {
        private string school;
        private double pay;
        public Staff(string name,string address,string school,double pay ):base(name,address)
        {
            this.school = school;
            this.pay = pay;
        }

        public void setSchool(string school)
        {
            this.school = school;
        }
        public string getSchool()
        {
            return this.school;
        }
        public void setPay(double pay)
        {
            this.pay = pay;
        }
        public double getPay()
        {
            return pay;
        }
        public override string toString()
        {
            return base.toString() + "  school: "+this.school+" pay :" +pay;
        }
    }
}
