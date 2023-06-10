using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using selfAssistance.DL;

namespace selfAssistance.BL
{
    class ShopBL
    {
        public string shopName;
        public List<MenuBL> menu = new List<MenuBL>();
        public List<string> orders = new List<string>();
        public ShopBL(string shopName)
        {
            this.shopName = shopName;
        }
        public ShopBL(List<MenuBL> menu)
        {
            this.menu = menu;
        }
/*        public ShopBL(List<string> order)
        {
            this.order = order;
        }*/
        public ShopBL()
        {

        }
        public void addOrderIntoList(string order)
        {
            orders.Add(order);
        }

        public int totalPayableAmount()
        {
            int bill=0;
            foreach (var p in orders)
            {
            bill=bill+ ShopDL.payableAmount(p);
            }
            return bill;
        }
        public void removeOrderFromList(int x)
        {
            orders.RemoveAt(x);
        }

    }
}
