using System;

namespace AreaCalc
{
    class AreaCalcClass
    {  
          static void Main(string[] args)
        {

            double length, width, height, trbase, radius, result, smallbase, bigbase;
            string shape, answer;

        Start:

            Console.WriteLine("Type in a two dimensional shape (e.g. triangle):");
            Console.WriteLine("Available options are: Triangle, Square, Circle, Trapezoid, Parallelogram.");

            //convert shape input to lowe case
            shape = Console.ReadLine().ToLower();

            try
            {


                if (shape == "rectangle" ||shape == "square")
                {
                    Console.Write("Type in length in cm: ");
                    length = Convert.ToDouble(Console.ReadLine());

                    if (shape == "square")
                    {
                        width = length;
                    }

                    else
                    {
                        Console.Write("Type in width in cm:");
                        width = Convert.ToDouble(Console.ReadLine());

                    }


                    result = length * width;

                    Console.WriteLine("Result is: {0}", result);
                }

                else if (shape == "triangle")
                {
                    Console.Write("Type in base length in cm: ");
                    trbase = Convert.ToDouble(Console.ReadLine());


                    Console.Write("Type in height in cm:");
                    height = Convert.ToDouble(Console.ReadLine());


                    result = (trbase * height) / 2;

                    Console.WriteLine("Result is: {0} ", result);
                }


                else if (shape == "circle")

                {
                    Console.Write("Type in radius cm: ");
                    radius = Convert.ToDouble(Console.ReadLine());

                    result = Math.PI * (radius * radius);

                    Console.WriteLine("Result is: {0}", result);
                }

                else if (shape == "trapezoid")
                {
                    Console.Write("Type in small base length in cm: ");
                    smallbase = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Type in big base length in cm: ");
                    bigbase = Convert.ToDouble(Console.ReadLine());


                    Console.Write("Type in height in cm:");
                    height = Convert.ToDouble(Console.ReadLine());


                    result = (smallbase + bigbase) * height / 2;

                    Console.WriteLine("Result is: {0} ", result);
                }

                else if (shape == "parallelogram")
                {
                    Console.Write("Type in base length in cm: ");
                    trbase = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Type in height in cm:");
                    height = Convert.ToDouble(Console.ReadLine());


                    result = trbase * height;

                    Console.WriteLine("Result is: {0} ", result);
                }

                else
                {
                    Console.WriteLine("Please try again with a valid shape!");
                    goto Start;
                }
            }




            catch (FormatException e)
            {
                Console.WriteLine("Please type in a correct number in cm: {0}", e);
               

                goto Start;
            }

            

            Console.Write("Would you like to calculate area for another shape(yes or no)?");

            answer = Convert.ToString(Console.ReadLine()).ToLower();

            if (answer == "yes")
            {
                goto Start;
            }

            else
            {
                Console.WriteLine("Bye now!");
                System.Threading.Thread.Sleep(1500);
                
            }

        }
    }
}
