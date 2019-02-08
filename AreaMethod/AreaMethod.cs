using System;

namespace AreaMethod
{
    public class AreaMethodClass
    {

        public string Shape { get; set;}
        public double Length { get; set;}
        public double Width { get; set;}
        public double TrBase { get; set;} 
        public double Height { get; set;}
        public double Radius { get; set;}
        public double SmallBase { get; set;}
        public double BigBase { get; set;}
        public string Answer { get; set;}


        public string GetShape()
        {
            Console.Write("Type in shape ");
            Console.Write("(available options are: Triangle, Square, Circle, Trapezoid, Parallelogram.):");

            //convert shape input to lower case
            Shape = Console.ReadLine().ToLower();
            return Shape;
           
        }

        public double GetLength()
        {
            Console.Write("Type in length in cm: ");
            Length = Convert.ToDouble(Console.ReadLine());
            return Length;
        }

        public double GetWidth()
        {
            Console.Write("Type in width in cm: ");
            Width = Convert.ToDouble(Console.ReadLine());
            return Width;
        }

        public double GetBase()

        {
            Console.Write("Type in base in cm: ");
            TrBase = Convert.ToDouble(Console.ReadLine());
            return TrBase;
        }

        public double GetHeight()
        {
            Console.Write("Type in height in cm: ");
            Height = Convert.ToDouble(Console.ReadLine());
            return Height;
        }

        public double GetRadius()

        {
            Console.Write("Type in radius cm: ");
            Radius = Convert.ToDouble(Console.ReadLine());
            return Radius;
        }

        public double GetSmallBase()
        {
            Console.Write("Type in small base length in cm: ");
            SmallBase = Convert.ToDouble(Console.ReadLine());
            return SmallBase;
        }

        public double GetBigBase()
        {
            Console.Write("Type in big base length in cm: ");
            BigBase = Convert.ToDouble(Console.ReadLine());
            return BigBase;
        }

        public double RectangleAndSquareArea(double Length, double Width)
        {
           
           
           double ReqResults = Width * Length;

           return ReqResults;

        }

        public double TriangleArea(double Trbase, double Height)
        {


            double ReqResults = (Trbase * Height)/2;

            return ReqResults;

        }

        public double CircleArea (double Radius)
        {
            double CircleAreaResult = Math.PI * (Radius * Radius);

            return CircleAreaResult;
        }

        public double TrapezoidArea(double SmallBase, double BigBase, double Height)
        {
            double TrapezoidAreaResult = (SmallBase + BigBase) * Height / 2;
            return TrapezoidAreaResult;
        }

        public double ParallelogramArea(double TrBase, double Height)
        {
            double ParallelogramResult = TrBase * Height;
            return ParallelogramResult;
        }
        

        public static void Main(string[] args)
        {

        Start:
            
            AreaMethodClass getMyShape = new AreaMethodClass();
            AreaMethodClass getMyLength = new AreaMethodClass();
            AreaMethodClass getMyWidth = new AreaMethodClass();
            AreaMethodClass getMyBase = new AreaMethodClass();
            AreaMethodClass getMyHeight = new AreaMethodClass();
            AreaMethodClass getMySmallBase = new AreaMethodClass();
            AreaMethodClass getMyBigBase = new AreaMethodClass();
            AreaMethodClass getMyRadius = new AreaMethodClass();
            AreaMethodClass getMyArea = new AreaMethodClass();
            
            string shape = getMyShape.GetShape();


            try
            { 

                if (shape == "rectangle")
                {

                    getMyLength.GetLength();

                    getMyWidth.GetWidth();

                    double rectangleresults = getMyArea.RectangleAndSquareArea(getMyLength.Length, getMyWidth.Width);

                    Console.WriteLine("The result is: {0}", rectangleresults);
                   

                }

                else if (shape == "square")

                {
                    getMyLength.GetLength();

                    double squareresults = getMyArea.RectangleAndSquareArea(getMyLength.Length, getMyLength.Length);


                    Console.WriteLine("The result is: {0}", squareresults);
                    

                }

                else if (shape == "triangle")

                {
                    getMyBase.GetBase();

                    getMyHeight.GetHeight();

                    double triangleResults = getMyArea.TriangleArea(getMyBase.TrBase, getMyHeight.Height);


                    Console.WriteLine("The result is: {0}", triangleResults);
                   
                }

                else if (shape == "circle")
                {
                    getMyRadius.GetRadius();

                    double circleResult = getMyArea.CircleArea(getMyRadius.Radius);

                    Console.WriteLine("The result is: {0}", circleResult);
                    
                }

                else if (shape == "trapezoid")
                {
                    getMySmallBase.GetSmallBase();
                    getMyBigBase.GetBigBase();
                    getMyHeight.GetHeight();

                    double trapezoidResult = getMyArea.TrapezoidArea(getMySmallBase.SmallBase, getMyBigBase.BigBase, getMyHeight.Height);

                    Console.WriteLine("The result is: {0}", trapezoidResult);
                    
                }

                else if (shape == "parallelogram")
                {
                    getMyBase.GetBase();
                    getMyHeight.GetHeight();

                    double parallelogramResult = getMyArea.ParallelogramArea(getMyBase.TrBase, getMyHeight.Height);

                    Console.WriteLine("The result is: {0}", parallelogramResult);
                    

                }

                else

                {
                    Console.WriteLine("Please try again with a valid shape");
                    goto Start;
                }
            }

            catch (FormatException e)
            {
                Console.WriteLine("Please type in a valid number: {0}", e);
                goto Start;
            }

            Console.Write("Would you like to calculate area for another shape(yes or no)?");

            string answer = Convert.ToString(Console.ReadLine()).ToLower();

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

