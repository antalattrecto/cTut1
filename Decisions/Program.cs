using System;



namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int d;
            int alpha;



            Console.Write("Type in a: ");
            a = Convert.ToInt32(Console.ReadLine());


            Console.Write("Type in b: ");
            b = Convert.ToInt32(Console.ReadLine());


            Console.Write("Type in c: ");
            c = Convert.ToInt32(Console.ReadLine());


            Console.Write("Type in d: ");
            d = Convert.ToInt32(Console.ReadLine());

            alpha = a > b ? 1 : 0;

            if (alpha == 1)

            {


                if (a >= b && b != 0 && c < d)
                {
                    Console.WriteLine("1");
                    Console.ReadLine();
                }

                else if (a <= b || b != 4 || c < d)
                {
                    Console.WriteLine("2");
                    Console.ReadLine();
                }

                else if (a == d && b < c || c + a > d)
                {
                    Console.WriteLine("3");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("Wow!");
                    Console.ReadLine();
                }

            }

            else
            {
                Console.WriteLine("Right!");
                Console.ReadLine();
            }

        }
    }
}
