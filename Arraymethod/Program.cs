using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraymethod
{
    class AMethod
    {
        private int[] myArray = { 1, 2, 3, 4, 5 };
        public int[] MyArray
        {
            get
            {
                return myArray;
            }
            set
            {

            }
        }
        
        public void PrintFirstElement(int[] a)
        {
            Console.WriteLine("First element: {0}", a[0]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AMethod GetFirst = new AMethod();

            GetFirst.PrintFirstElement(GetFirst.MyArray);
            Console.ReadLine();
        }
    }
}
