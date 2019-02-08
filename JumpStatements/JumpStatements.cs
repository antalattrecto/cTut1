using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpStatements
{
    class JumpStatements
    {
        static void Main(string[] args)
        {
            Console.Write("Where would yo like to start the countdown? ");
            int counter = Convert.ToInt32(Console.ReadLine());

           for (int i = counter; i>0; i-- )
            {
                Console.WriteLine(counter);
                counter = counter - 1;
                System.Threading.Thread.Sleep(1000);
                if (i == 2)
                    //break;
                    continue;
            }
                Console.WriteLine("Lift-Off!");
                Console.ReadLine();
        }
    }
}
