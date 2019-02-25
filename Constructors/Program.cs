using System;


namespace Constructors
{
    public class Set
    {
        public int num = 1;

        public Set()
        {
            num = 2;

        }
    }
        class Program
        {
            static void Main(string[] args)
            {

            Set obj = new Set();

            Console.WriteLine("{0}", obj.num);
            Console.ReadLine();

            }
        }
    
}
