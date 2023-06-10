using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.BL
{
    class Person
    {
        protected string name;
        protected string address;
        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public string getName()
        {
            return this.name;
        }
        public string getAddress()
        {
            return this.address;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setAdress(string address)
        {
            this.address = address;
        }
        public virtual string toString()
        {
            string person = "name " + name + " address " + address;
            return person;
        }
    }
}
