using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop1
{
    class WhileLoop1
    {
        static void Main(string[] args)
        {
            Console.Write("Where would yo like to start the countdown? ");
            int counter = Convert.ToInt32(Console.ReadLine());

            while (counter > 0)
            {
                Console.WriteLine(counter);
                counter = counter - 1;
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine("Lift-Off!");
            Console.ReadLine();
        }
    }
}
