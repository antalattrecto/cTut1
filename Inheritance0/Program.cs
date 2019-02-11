using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance0
{
    public class A
    {
        private int value = 10;

        public class B:A
        {
            public int GetValue()
            {
                return this.value;
            }
        }
    }

    //won't compile as value is private and not nested in the base class

    public class C : A
    {
    //    public int GetValue()
      //  {
        //    return this.value;
       // }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var b = new A.B();
            Console.WriteLine(b.GetValue());

         //   var c = new A.C();
         //   Console.WriteLine(c.GetValue());


            Console.ReadLine();

        }
    }
}
