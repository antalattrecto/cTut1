using System;

namespace Strings
{
    class StringClass
    {

        public void StringStuff()
        {
            string day = ("Monday");
            string month = ("January");
            

            int result1 = day.Length;
            string result2 = day.Substring(3);

            bool result3 = day.Equals(month);
            bool result4 = month.Equals(day);
            bool result5 = day.Equals("Alterturmsforcher");
            bool result6 = month.Equals("alterturmsforcer");

            Console.WriteLine("Result1 is:{0};Result2 is:{1};Result3 is:{2};Result4 is:{3};Result5 is:{4};Result6 is:{5}", result1, result2, result3, result4, result5, result6);

            

        }

        public void StringSplit()

        {
            string[] separator = { ", ", "; " };
            string names = "Peter, John; Andy, , David";
            string[] substrings = names.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            foreach (string res in substrings)
            {
                Console.Write("{0} ", res);

            }


        }

        public void DisplayStringArray()
        {
            string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

            foreach (string res in days)
            {
                Console.WriteLine();

                Console.Write("{0}, ", res);
            }
        }


        static void Main(string[] args)
        {
            StringClass GetStuff = new StringClass();

            GetStuff.StringStuff();
            GetStuff.StringSplit();
            GetStuff.DisplayStringArray();


            Console.Read();
        }
    }
}
