using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamMethod
{
    class Param
    {
        public void PrintNames(params string[] names)
        {
            for (int i = 0; i< names.Length; i++)
            {
                Console.Write(names[i] + " ");
                
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Param GetStuff = new Param();

            GetStuff.PrintNames("John", "Jim", "Julie");

            Console.ReadLine();
        }
    }
}
