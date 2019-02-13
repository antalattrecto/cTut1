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
                {
                    Console.WriteLine("Type in a year between 1900 and 3000");
                  
                }
                else
                {
                    userYearOfBirth = value;
                }
            }
        }



        public override string ToString()
        {
            return "\nCurrent year is: " + currentYear + "\nUser's year of birth: " + UserYearOfBirth + "\nUser's age is: " + userAge;
        }


        public virtual void Exit()
        {
            Console.WriteLine("Press any key to continue!");
            Console.ReadLine();

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

        public override void Exit()
        {
            Console.WriteLine("Thank you and Bye now!");
            System.Threading.Thread.Sleep(2000);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            
            ChildClass obj = new ChildClass();
            BaseClass obj1 = new BaseClass();

            

            obj.GetBirth();
            obj.CalculateAge();

            if (obj.userAge == obj.currentYear)
            {
                obj1.Exit();
            }

            else
            {
                Console.WriteLine(obj.ToString());
                obj.Exit();
            }

  
            
        }
    }
}
