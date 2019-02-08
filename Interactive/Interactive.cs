using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Interactive
{
    class Interactive
    {
        static void Main(string[] args)
        {
            int userAge = 33;
            double number = 1.23456789;
            string result = "John";
            string userInput;

            WriteLine(userAge);
            WriteLine("Monday"
                        + " "+ "Tuesday" + " "+
                        "Wednesday");

            DateTime time = DateTime.Now.AddHours(+2);

            WriteLine("The date and time in Bucharest is: {0}", time);
            WriteLine("The number is: {0 :F6}", number);
            WriteLine("The amount is: {0:C}", number);
            WriteLine("BREXIT".Substring(2, 4));
            WriteLine("Length is: {0}", result.Length);
            WriteLine("If\twe shadows have offended\n Think but this \\ and all is mended.");
            WriteLine("I am 6'9\" tall");

            WriteLine("Userinput - please let it be a number :)");
            userInput = ReadLine();
            int newUserInput = Convert.ToInt32(userInput);
            WriteLine("Userinput was:{0}, {1}", userInput, newUserInput);






            Read();
        }
    }
}
