using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace CSProject
{
    class Staff
    {
        private float hourlyRate;
        private int hWorked;
        public float TotalPay { get; protected set; }
        public float BasicPay { get; private set; }
        public string NameOfStaff { get; private set; }

        public int HoursWorked
        {
            get
            {
                return hWorked; 
            }
            set
            {
                if (hWorked < 0)
                {
                    hWorked = 0;
                }
                else
                    hWorked = value;
            }
        }

        public Staff(string name, float rate)
        {
            NameOfStaff = name;
            hourlyRate = rate;
        }


        public virtual void CalculatePay()
        {
            Console.WriteLine("Calculating Pay...");
            BasicPay = hWorked * hourlyRate;
            TotalPay = BasicPay;
        }

        public override string ToString()
        {
            return "\nName of Staff is: "+NameOfStaff+"\nHourly Rate is: " + hourlyRate + "\nHours Worked are: " + hWorked + "\nBasic Pay is: " + BasicPay + "\nTotal pay is: " + TotalPay;
        }

    }

    class Manager : Staff
    {
        private const float managerHourlyRate = 50;
        public int Allowance { get; private set; }

        public Manager(string name) : base(name, managerHourlyRate) {}


        public override void CalculatePay()
        {
            base.CalculatePay();
            Allowance = 1000;

            if (HoursWorked > 160)
            {
                TotalPay = BasicPay + Allowance;
            }
            //else
            //{
              //  TotalPay = BasicPay;
            //}
        }

        public override string ToString()
        {
            return "\nName of Staff is: " + NameOfStaff + "\nManager's Hourly Rate is: " + managerHourlyRate + "\nPersonal Allowance is: " + Allowance + "\nBasic pay is: " + BasicPay + "\nTotal Pay is: " + TotalPay;
        }


    }

    class Admin : Staff
    {
        private const float overtimeRate=15.5f;
        private const float adminHourlyRate= 30f;

        public float Overtime { get; private set; }

        public Admin(string name): base(name, adminHourlyRate) { }

        public override void CalculatePay()
        {
            base.CalculatePay();

            

            if (HoursWorked > 160)
            {
                Overtime = overtimeRate * (HoursWorked - 160);
            }
           

        }

        public override string ToString()
        {
            return "\nName of Staff is: " + NameOfStaff + "\nAdmin's Hourly Rate is: " + adminHourlyRate + "\nOvertime is: " + Overtime + "\nBasic pay is: " + BasicPay + "\nTotal Pay is: " + TotalPay;
        }

    }

    class FileReader

    {
        
        public List<Staff> ReadFile()
        {
            List<Staff> myStaff = new List<Staff>();
            string[] result = new string[2];
            string[] separator = { ", " };
            string path = "CSPRoject.txt";


            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        result = sr.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);
                    }

                    if (result[1] == "Manager")
                    {
                        myStaff.Add(new Manager(result[0]));
                    }

                    else if (result[1] == "Admin")
                    {
                        myStaff.Add(new Admin(result[0]));
                    }
                    sr.Close();
                }
            }

            else
            {
                string pathlog = "Log.txt";
                DateTime date = DateTime.Now;

                using (StreamWriter sw = new StreamWriter(pathlog, true))
                {
                    sw.WriteLine("{0} - An error has occured. File is missing.", date);
                }
                

            }

            return myStaff;

        }
    }

    class PaySlip
    {
        private int month, year;

        public PaySlip(int payMonth, int payYear)
        {
            month = payMonth;
            year = payYear;
        }

        enum MonthOfTheYear
        {
            Jan = 1, Feb, Mar, Apr, May, June, July, Aug, Sep, Oct, Nov, Dec
        }
        public void GeneratePaySlip(List<Staff> myStaff)
        {
            string path;

            foreach (Staff f in myStaff)
            {
                path = f.NameOfStaff + ".txt";

                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("Payslip for {0} {1}", (MonthOfTheYear)month, year);
                    sw.WriteLine("============================");
                    sw.WriteLine("Name of Staff: {0}", f.NameOfStaff);
                    sw.WriteLine("Hours Worked: {0}", f.HoursWorked);
                    sw.WriteLine("");
                    sw.WriteLine("Basic pay is: {0:c}", f.BasicPay);
                    if (f.GetType() == typeof(Manager))
                    {
                        sw.WriteLine("Allowance is : {0:c}", ((Manager)f).Allowance);
                    }
                    else if (f.GetType() == typeof(Admin))
                    {
                        sw.WriteLine("Overtime is: {0:c}", ((Admin)f).Overtime);
                    }

                    sw.WriteLine("");
                    sw.WriteLine("=============================");
                    sw.WriteLine("Total Pay is: {0:c}", f.TotalPay);
                    sw.WriteLine("=============================");
                    sw.Close();
                }
                
            }
            
        }

        public void GenerateSummary(List<Staff> myStaff)
        {
            string path = "Summary.txt";
            var result = from f in myStaff where f.HoursWorked < 10 orderby f.NameOfStaff ascending select new { f.NameOfStaff, f.HoursWorked };

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("Staff with less than 10 working hours:");
                sw.WriteLine("");

                foreach (var f in result)
                {
                    sw.WriteLine("Name of Staff: {0};  Hours worked: {1}", f.NameOfStaff, f.HoursWorked);
                }
                sw.Close();
            }
        }

        public override string ToString()
        {
            return "Month is: " + month + "Year is: " + year;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Staff> myStaff = new List<Staff>();
            FileReader fr = new FileReader();
            int year = 0;
            int month = 0;
            PaySlip ps = new PaySlip(month, year);
            

            while (year==0)
            {
                Console.Write("\nPlease enter the year:");
                try
                {
                    year = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.Write("An error has occured: {0}", e);
                }
            }

            while (month == 0)
            {
                Console.Write("\nPlease enter a month:");
                try
                {
                    month = Convert.ToInt32(Console.ReadLine());

                    if (month<1 || month >12)
                    {
                        Console.Write("Number must be between 1 and 12. Please try again!");
                        month = 0;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error has occured: {0}", e);
                }
            }

            myStaff = fr.ReadFile();

            for (int i = 0; i < myStaff.Count; i++)
            {
                try
                {
                    Console.WriteLine("Enter hours worked for {0}", myStaff[i].NameOfStaff);

                    myStaff[i].HoursWorked = Convert.ToInt32(Console.ReadLine());

                    myStaff[i].CalculatePay();

                    Console.WriteLine(myStaff[i].ToString());

                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    i--;
                }
            }

            ps.GeneratePaySlip(myStaff);
            ps.GenerateSummary(myStaff);
            Console.Read();

        }
    }
}
