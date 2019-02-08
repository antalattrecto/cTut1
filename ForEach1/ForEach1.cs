using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach1
{
    class ForEach1
    {
        static void Main(string[] args)
        {
            char [] message = { 'H', 'E', 'L', 'L', 'O', '!' };

            foreach (char i in message)
            {
                Console.Write(i);
            }
            Console.ReadLine();
        }
    }
}
