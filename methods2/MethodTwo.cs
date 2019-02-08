using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods2
{
    class MethodTwo
    {
        public int FindMax (int num1, int num2)
        {
            int result;

            if (num1 > num2)
            
                result = num1;
            

            else result = num2;

                    return result;

        }
        static void Main(string[] args)
        {
            int a = 100;
            int b = 200;
      
            int ret;

            MethodTwo n = new MethodTwo();

            ret = n.FindMax(a, b);

            Console.Write(ret);
            Console.Read();

        }
    }
}
