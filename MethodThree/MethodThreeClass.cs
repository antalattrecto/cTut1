using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodThree
{
    class MethodThreeClass
    {
     
        public int factorial(int num)
        {
            /* local variable declaration */
            int result;
            if (num == 1)
            {
                return 1;
            }
            else
            {
                result = factorial(num - 1) * num;
                return result;
            }
        }



        //creating the method - return c as string
        public string IsItSameOrNot (string a, string b)
        {
        
            string c;

            if (a == b)

                c = "Same";

            else

                c = "Not Same";

            return c;
                
        }
        static void Main(string[] args)
        {
            //creating local variables
            string d = "Kush";
            string e = "Kush";

            string result;


           MethodThreeClass n = new MethodThreeClass();

            result = n.IsItSameOrNot (d, e);

            Console.Write(result);

            Console.ReadLine();
           


       
            //calling the factorial method {0}", n.factorial(6));
            Console.WriteLine("Factorial of 1 is : {0}", n.factorial(1));
            Console.WriteLine("Factorial of 8 is : {0}", n.factorial(5));
            Console.ReadLine();




        }
    }
}
