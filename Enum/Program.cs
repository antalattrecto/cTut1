using System;


namespace Enum
{

    class MyEnum
    {
        enum DaysOfTheWeek : byte
        {
            Monday = 12,
            Tuesday = 0,
            Wednesday = 1 ,
            Thursday = 2,
            Friday = 3,
            Saturday = 4,
            Sunday
        }

        enum Results
        {
            Bingo,
            Fail
        }

        public string myDay = DaysOfTheWeek.Friday.ToString();
        public string days = DateTime.Now.DayOfWeek.ToString();

        public void MyMethod()
        {
            Console.WriteLine(myDay);
        
            Console.WriteLine((DaysOfTheWeek)5);
        }

        public void Result()
        {
            if (days == myDay)
            {
                Console.WriteLine(Results.Bingo);
            }
            else
            {
                Console.WriteLine(Results.Fail);
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyEnum obj = new MyEnum();
            obj.MyMethod();
            obj.Result();
            Console.ReadLine();
        }
    }
    
}
