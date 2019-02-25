using System;


namespace ConstructorPrivate
{
    public class Counter
    {
        private Counter() { }
        public static int currentCount;
        public static int IncrementCount()
        {
            return ++currentCount;
        }
    }
 
    class Program
    {
        static void Main(string[] args)
        {
        
            //Counter aCounter = new Counter();

            Counter.currentCount = 0;
            Counter.IncrementCount();
            Console.WriteLine("New count: {0}", Counter.currentCount);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
