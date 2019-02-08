using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cTut1
{
    class Program
    {


        static void Main(string[] args)
        {
            int number = -3;
            byte binary = 255;
            float decim = -3.657877979798f;
            double longnumber = -4364565645645656445656464565.6;
            decimal decim2 = 1.34m;
            char justSomething = 'A';
            bool guessWhat = true;
            
         

            int x = 4;
            int y = 5;
            x = y = 0-1;
            Console.WriteLine("{0} {1}", y, x);


            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", number, binary, decim, longnumber, decim2, justSomething, guessWhat);
            Console.Read();
        }
    }
}
