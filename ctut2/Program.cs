using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctut2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                int x;
                int y;
                string result1;
                string result2;
                string result3;
                string result4;
                string result5;


                Console.WriteLine("Type in number Athen press Enter.");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Type in number B then press Enter for results");
                y = Convert.ToInt32(Console.ReadLine());



                result1 = Convert.ToString(x + y);
                result2 = Convert.ToString(x - y);
                result3 = Convert.ToString(x * y);
                result4 = Convert.ToString(x / y);
                result5 = Convert.ToString(x % y);

                if (result5 == "0")

                {
                    Console.WriteLine("Results are: {0}, {1}, {2}, {3}", result1, result2, result3, result4);
                    Console.Read();

                }

                else

                {
                    Console.WriteLine("Results are:{0}, {1}, {2}, {3}.{4}", result1, result2, result3, result4, result5);
                    Console.Read();

                }

            }

            catch (Exception e)

            {
                Console.WriteLine("Following exception occured.(Have you typed in a correct number?): {0}", e);
                Console.ReadLine();
            }

        }
    }
}
