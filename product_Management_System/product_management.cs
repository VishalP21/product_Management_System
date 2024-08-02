using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_Management_System
{
    public class product_management
    {
        public List<productinfo> productinfo;

        public product_management()
        {
            productinfo = new List<productinfo>();
        }

        public void addproduct(productinfo info)
        {
            productinfo.Add(info);
        }
        public void removeproduct(productinfo info)
        {
            if(info.product_ID <= 0 )
            {
            productinfo.Remove(info);
            }
        }
        public void display()
        {
            foreach (productinfo info in productinfo)
            {
                Console.WriteLine(info.product_name);
                Console.WriteLine(info.product_ID);
                Console.WriteLine(info.product_cost_price);
                Console.WriteLine(info.product_sale_price);
                Console.WriteLine(info.product_availabal_stock);
            }
        }
    }
}
