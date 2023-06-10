using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.BL
{
    class User
    {
        public string name;
        public string password;
        public string role;
         public User(string name,string password)
        {
            this.name = name;
            this.password = password;
        }
        public User(string name,string password,string role)
        {
            this.name = name;
            this.password = password;
            this.role = role;
        }
        public bool isAdmin()
        {
            if(role=="Admin"||role=="admin")
            {
                return true;
            }
            return false;
        }
    }
}
