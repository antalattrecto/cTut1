using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop2
{
    class ForLoop2
    {
        static void Main(string[] args)
        {

            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i=1; i<numbers.Length; i++)
            {
                Console.Write("{0}, ", numbers[i]);

            }

            Console.ReadLine();
        }
    }
}
