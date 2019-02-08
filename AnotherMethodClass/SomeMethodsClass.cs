using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeMethods
{
    class SomeMethodsClass
    {

        double length;
        double width;

        public void Details()
        {
            length = 4.5;
            width = 3.5;
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display ()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }

        class ExecuteMethods
        {
            static void Main(string[] args)
            {
                SomeMethodsClass r = new SomeMethodsClass();

                r.Details();
                r.GetArea();
                r.Display();
                Console.Read();
            }
        }
    }
}
