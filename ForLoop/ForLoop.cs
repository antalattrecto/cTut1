using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class ForLoop
    {
        static void Main(string[] args)
        {

            int userInput;
            Console.Write("You number: ");
            userInput = Convert.ToInt32(Console.ReadLine());

            for (int i = userInput; i <=100; i++)
            {
                Console.Write("{0}, ", i - 100);
               
            }
            Console.ReadLine();
        }
    }
}
