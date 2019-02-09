using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMethod
{
    class ListA
    {
        private List<int> myList = new List<int> { 1, 2, 3, 4, 5 };

        public List<int> MyList
        {
            get
            {
                return myList;
            }
            set
            {

            }
        }

        public void PrintFirstListElement (List<int> a)
        {
            Console.WriteLine("First element is: {0}", a[0]);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            ListA GetStuff = new ListA();

            GetStuff.PrintFirstListElement(GetStuff.MyList);
            Console.ReadLine();

        }
    }
}
