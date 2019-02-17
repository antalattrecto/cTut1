using System;


namespace AbstractClass
{
    abstract class MyClass
    {
        public abstract void MyAbstractMethod();
    }

    class YourClass : MyClass
    {
        public override void MyAbstractMethod()
        {
            Console.WriteLine("Abstract?");
            Console.ReadLine();
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            YourClass obj = new YourClass();

            obj.MyAbstractMethod();
        }
    }
}
