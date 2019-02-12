using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit1
{
    class BaseClass
    {
        private static DateTime currentDate = DateTime.Now.Date;
        public int currentYear = currentDate.Year;
     

        public override string ToString()
        {
            return "\nCurrent Year is: " + currentYear + "\nUser's date fo birth is: " + userDateOfBirth + "\nUser's Age is: " + userAge;
        }

        public int userAge { get; set; }
        public int userDateOfBirth { get; set; }

        public int CalculateAge(int currentYear, int userDateOfBirth)


        {
            userAge = currentYear - userDateOfBirth;

            return userAge;
        }

       
    }

    class ChildClass:BaseClass
    {
        public void UserInput()
        {

            CalculateAge(currentYear, 34);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ChildClass obj = new ChildClass();

            obj.UserInput();

            Console.ReadLine();

        }
    }
}
