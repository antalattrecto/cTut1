using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace UserAge
{
    class UserAge
    {
        static void Main(string[] args)
        {
            string userName;
            int userAge;
            int born;
            int currentYear = DateTime.Now.Year;

            WriteLine("Username:");
            userName = Console.ReadLine();

            WriteLine("Userage: ");
            userAge = Convert.ToInt32(ReadLine());

            born = currentYear - userAge;
            WriteLine("Current year is: {1}; Username is: {2}; Userage is:{3}; Born:{0}", born, currentYear, userName, userAge);

            ReadLine();
            




        }
    }
}
