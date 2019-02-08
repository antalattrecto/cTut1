using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        

        public static double GetSpeed()
        {
            return 100;
        }


        static void Main(string[] args)
        {
            double output = GetSpeed();
                 

            Console.WriteLine("Your speed is: {0}", output);
            Console.Read();
        }
    }
}

