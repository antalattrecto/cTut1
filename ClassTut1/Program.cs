using System;


namespace ClassTut1
{
    class Staff
    {
        //fields
        private string nameOfStaff;
        private const int hourlyRate = 30;
        private int hWorked;


        //constructor
        public Staff (string name)
        {
            nameOfStaff = name;
            Console.WriteLine("\n" + nameOfStaff);
            Console.WriteLine("----------------------------------------");
        }
        //constructor
        public Staff(string firstName, string lastName)
        {
            nameOfStaff = firstName + " " + lastName;

            Console.WriteLine("\n" + nameOfStaff);
            Console.WriteLine("----------------------------------------");
        }

        //properties
        public int HoursWorked
        {
            get
            {
                return hWorked;
            }
            set
            {
                if (value > 0)
                    hWorked = value;
                else
                    hWorked = 0;
            }
        }

        //methods
        public void PrintMessage()
        {
            Console.WriteLine("Calculating pay ...");
        }

        public int CalculatePay()
        {
            PrintMessage();
            int staffPay;

            staffPay = hWorked * hourlyRate;

            if (hWorked > 0)
            {
                return staffPay;
            }
            else
            {
                return 0;
            }
        }

            public int CalculatePay(int bonus, int allowance)

            {
            int staffPay;

            staffPay = hWorked * hourlyRate + bonus + allowance;

            PrintMessage();

            if (hWorked > 0)
                return staffPay;

            else
                return 0;
            }

        public override string ToString()
        {
            return "Name of Staff = " + nameOfStaff + ", hourlyrate = " + hourlyRate + ", hWorked = " + hWorked;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            int pay;

            Staff staff1 = new Staff("Peter", "James");
            staff1.HoursWorked = 160;
            pay = staff1.CalculatePay(1000, 400);
            Console.WriteLine("Pay = {0}", pay);
            Console.WriteLine(staff1.ToString());

            Staff staff2 = new Staff("Suzie", "Lee");

            staff2.HoursWorked = 160;
            pay = staff2.CalculatePay();
            Console.WriteLine("Pay = {0}", pay);
            Console.WriteLine(staff2.ToString());

            Staff staff3 = new Staff("Sajmolin", "Kukuruza");
            staff3.HoursWorked = -10;
            pay = staff3.CalculatePay();
            Console.WriteLine("Pay = {0}", pay);
            Console.WriteLine(staff3.ToString());

            Console.ReadLine();
        }
    }
}
