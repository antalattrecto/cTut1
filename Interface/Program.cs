using System;

namespace Interface
{
    interface IMyInterFace
    {
        int MyAge
        {
            get;
            set;
        }

         void GetMyAge();
    }

    class Child : IMyInterFace
    {
        private int myAge;
        public int MyAge
        {
            get
            {
                return myAge;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Please use bigger number!");
                    myAge = 0;
                }
                else
                {
                    myAge = value;
                }
            }
        }

            public void GetMyAge()
        {
            Console.WriteLine("This is your age: {0}", MyAge);
            Console.ReadLine();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Child obj = new Child();

            Console.WriteLine("Type in age:");
            obj.MyAge = Convert.ToInt32(Console.ReadLine());

            obj.GetMyAge();

        }
    }
}
