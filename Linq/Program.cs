using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
   
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenQuery = from num in numbers
                            where (num % 2) == 0
                            select num;

            foreach (int i in evenQuery)
            {
                Console.WriteLine("{0},", i);
                
            }
            Console.ReadLine();
        }
    }
}
