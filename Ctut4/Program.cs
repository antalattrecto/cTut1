using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ctut4
{
    class Program
    {


        static void Main(string[] args)
        {
           

            int[] userAge = { 2, 4, 33, 36, 68, 69 };

            int[] userAge1;
            userAge1 = new[] { 1, 2, 3, 4, 5 };

            int[] userAge2 = new int[5];

            string[] stringArray = {"Bela", "Szalami", "Kenyer", "Tujok" };

            IEnumerable<int> userAgeQuery = from age in userAge where age > 4 select age;
            IEnumerable<string> stringArrayQuery = from things in stringArray where things ==  "Szalami" || things == "Bela" select things;

            userAge[0] = 3;
            userAge1[3] = userAge1[3] + 5;
         
            foreach (int i in userAgeQuery)
            {
                Console.Write(i+ ", ");
                
            }

            foreach (string i in stringArrayQuery)
            {
                Console.Write(i+ ", ");

            }

            Console.Read();
        }
    }
}
