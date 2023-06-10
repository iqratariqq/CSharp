using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.BL
{
    class Student:Person
    {
        private string program;
        private int year;
        private double fee;
        public Student(string name, string address, string program, int year, double fee) : base(name, address )     
        {
            this.program = program;
            this.year = year;
            this.fee = fee;
        }
        public string getProgram()
        {
            return this.program;
        }
        public void setProgram(string program)
        {
            this.program = program;
        }

        public int getyear()
        {
            return this.year;
        }
        public void setyear(int year)
        {
            this.year = year;
        }

        public double getfee()
        {
            return this.fee;
        }
        public void setfee(double fee)
        {
            this.fee = fee;
        }
        public override string toString()
        {
            return base.toString()+" program: " +this.program +" yaer "+" fee "+this.fee;
        }

    }
}
