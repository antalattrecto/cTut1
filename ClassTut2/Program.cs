using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTut2
{
    class ClassTut2
    {
        //non-static members
        public string message = "Hello World!";
        public string Name { get; set; }

        public ClassTut2(string name)
        {
            Name = name;
        }
        public void DisplayName ()
        {
            Console.WriteLine("Name = {0}", Name);
            Console.ReadLine();
        }

        //static members
        public static string greetings = "Good night!";
        public static int Age { get; set; }

        public ClassTut2 (int age)
        {
            Age = age;
        }
        public void DisplayAge()
        {
            Console.WriteLine("Age = {0}", Age);
            Console.ReadLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ClassTut2 tut1 = new ClassTut2("Pujok");
            ClassTut2 tut2 = new ClassTut2(34);

            tut1.DisplayName();
            tut2.DisplayAge();


        }
    }
}
