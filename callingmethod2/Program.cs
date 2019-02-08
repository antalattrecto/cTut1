using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callingmethod2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 200;
            int ret;

            Program n = new Program();

            ret = n.FindMax(a, b);
        }
    }
}
