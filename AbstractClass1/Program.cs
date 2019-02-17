using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass1
{
    abstract class MyAbstractClass
    {
        private string message = "Hello!";
        private string message1 = "OK";

        public string Message1
        {
            get
            {
                return message1;
            }

            set
            {
                if (message1 == "")
                {

                    Console.WriteLine("Something went wrong!");

                }

                else
                {
                    message1=value;
                }

            }
        }

        public void PrintMessage()
        {
            Console.WriteLine(message);
        }

        public abstract void PrintMessageAbstract();

    }

    class ClassA : MyAbstractClass
    {
        public override void PrintMessageAbstract()
        {
            Console.WriteLine(Message1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClassA obj = new ClassA();
            obj.PrintMessage();
            obj.PrintMessageAbstract();
            

            Console.ReadLine();
        }
    }
}
