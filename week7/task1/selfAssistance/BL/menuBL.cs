using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selfAssistance.BL
{
    class MenuBL
    {
        public string name;
        public string type;
        public int price;
        public MenuBL(string name, string type, int price)
        {
            this.name = name;
            this.type = type;
            this.price = price;

        }

    }
}
