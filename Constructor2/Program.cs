using System;

namespace Constructor2
{
    public class Employee
    {
        public int Salary;

        public Employee(int annualSalary)
        {
            Salary = annualSalary;
        }

        public Employee(int weeklySalary, int numberOfWeeks)
        {
            Salary = weeklySalary * numberOfWeeks;
        }
    }

    public class Manager : Employee
    {
        public Manager(int annualSalary) : base(annualSalary) { }
        public Manager(int weeklySalary, int numberOfWeeks) : base(weeklySalary, numberOfWeeks) { }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Manager obj1 = new Manager(45000);
            Manager obj2 = new Manager(866, 52);

            Console.WriteLine("{0}, {1}", obj1.Salary, obj2.Salary);
            Console.ReadLine();
        }
    }
}
