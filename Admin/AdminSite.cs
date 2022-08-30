using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin
{
    public class AdminSite:IAdmin
    {
        public string UserId { get; set; }
        public string passwordd { get; set; }

        public void MenuItem()
        {
            Console.WriteLine("press Insert to insert Customer Data ");
            Console.WriteLine("press Delete to insert Customer Data ");
        }
    }
}
