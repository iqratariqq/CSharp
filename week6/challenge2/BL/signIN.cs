using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using challenge2.DL;

namespace challenge2.BL
{
    class signIN
    {
                public string name;
                public string password;
                public string role;
        


        public signIN()
        {

        }
        public signIN(string name, string password)
        {
            this.name = name;
            this.password = password;

        }
        //for sign up

        public signIN(string name, string password, string role)
        {
            this.name = name;
            this.password = password;
            this.role = role;
        }


        public string ischeck()
        {
            return this.role;
        }

    }
}
