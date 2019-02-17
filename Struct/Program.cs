using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    struct MyStruct
    {
        //fields
        private int x, y;
        private AnotherClass myClass;
        private Days myDays;

            //constructor
            public MyStruct (int a, int b, int c)
        {
            myClass = new AnotherClass();
            myClass.number = a;
            x = b;
            y = c;
            myDays = Days.Mon;
        }
        //method

        public void PrintStatement()
        {
            Console.WriteLine("x={0}; y={1}; myDays ={2}; number = {3}", x, y, myDays, myClass.number);
            Console.ReadLine();
        }
     }
    class AnotherClass
    {
        public int number = 2;
        
    }

    enum Days { Mon, Tue, Wed }
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct obj = new MyStruct(2, 3, 5);
            obj.PrintStatement();
        }
    }
}
