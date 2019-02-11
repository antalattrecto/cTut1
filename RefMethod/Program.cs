using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefMethod
{
    class MethodDemo
    {
        public void PassByValue(int a)
        {
            a = 10;
            Console.WriteLine("a inside method is: {0}", a);
        }

        public void PassByRef(int[] b)
        {
            b[0] = 5;
            Console.WriteLine("b[0] in method is: {0}", b[0]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int[] b = { 1, 2, 3 };
            MethodDemo obj = new MethodDemo();

            Console.WriteLine("a before method is: {0}", a);
            obj.PassByValue(a);
            Console.WriteLine("a after method is: {0}", a);

            Console.WriteLine();

            Console.WriteLine("b[0] before method is: {0}", b[0]);
            obj.PassByRef(b);
            Console.WriteLine("b[0] after method is: {0}", b[0]);

            Console.ReadLine();



        }
    }
}
