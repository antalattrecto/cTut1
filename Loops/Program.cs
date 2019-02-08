using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = -10;
            int c = -11;
            

            while (a<=10)
            {
                Console.Write("{0}, ", a);
                a++;
            }

            Console.WriteLine();

            for (int b=-10; b <= 10; b +=1)
            {
                Console.Write("{0}, ", b);
            }

            Console.WriteLine();
            
            do
            {
                Console.Write("{0}, ", c+=1);
                
            }

            while (c < 10);

            Console.WriteLine();



            Console.Read();
        }
    }
}
