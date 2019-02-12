using System;


namespace AnotherInherit
{
    class BaseClass
    {
       private static DateTime currentDate = DateTime.Now.Date;
       public int currentYear = currentDate.Year;
       public int userAge;
       private int userYearOfBirth;

        public int UserYearOfBirth
        {
            get
            {
                return userYearOfBirth;
            }
            set
            {
                if (value < 1900 || value > 3000)
                    Console.WriteLine("Type in a year between 1900 and 3000");
                else
                    userYearOfBirth = value;
            }
        }



        public override string ToString()
        {
            return "\nCurrent year is: " + currentYear + "\nUser's year of birth: " + UserYearOfBirth + "\nUser's age is: " + userAge;
        }

       
    }

    class ChildClass: BaseClass
    {
        public void GetBirth()
        {
            Console.Write("Type in your year of birth: ");
            UserYearOfBirth = Convert.ToInt32(Console.ReadLine());
        }

        public int CalculateAge()
        {

            userAge = currentYear - UserYearOfBirth;

            return userAge;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            
            ChildClass obj = new ChildClass();
            

            obj.GetBirth();
            obj.CalculateAge();

          Console.WriteLine(obj.ToString());
  
            Console.ReadLine();
        }
    }
}
