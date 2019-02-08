using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandler
{
    class ExceptionHandler
    {
        static void Main(string[] args)
        {
            int userChoice;
            int result;
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };

            Console.Write("Type in array index (0-6): ");

            try
            {
                userChoice = Convert.ToInt32(Console.ReadLine());
                result = numbers[userChoice]/ userChoice;

                Console.WriteLine("Result1: {0}; Result 2: {1}", numbers[userChoice], result);
                
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Error: Index was out of range: {0}", e.ToString());
                
            }

            catch (ArithmeticException e)

            {
                Console.WriteLine("Dividing by zero? {0}", e.ToString());
            }

            catch (FormatException e)
            {
                Console.WriteLine("Error: You did not type in an integer. {0}", e.ToString());
            }
          
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }

            finally
            {
                Console.WriteLine("Just do this whatever!");
            }
            Console.ReadLine();

        }
    }
}
