using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch1
{
    class Switch1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your grade: ");
            string userGrade = Console.ReadLine();

            switch (userGrade)
            {
                case "A+":
                case "A":
                    Console.WriteLine("Very good!");
                    Console.ReadLine();
                    break;
                case "B":
                    Console.WriteLine("Not bad!");
                    Console.ReadLine();
                    break;
                case "C":
                    Console.WriteLine("Right!");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("You failed buddy!");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
