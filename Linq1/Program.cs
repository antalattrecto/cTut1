using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq1
{
    class Customer
    {
        public enum StatusType
        {
            Open,
            Closed,
            Suspended
        };

        public int ID { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }
        public string Address { get; set; }
        public StatusType Status { get; set; }




        public static List <Customer> customerList = new List <Customer>()
        {
            new Customer () {ID = 1, Name = "John", Balance = 23, Address = "1 London Road", Status = StatusType.Open},
            new Customer () {ID = 2, Name = "Bill", Balance = -1, Address = "2 London Road", Status = StatusType.Closed},
            new Customer () {ID = 3, Name = "Jeremy", Balance = 5000, Address = "3 London Road", Status = StatusType.Suspended},
            new Customer () {ID = 4, Name = "Dan", Balance = -2, Address = "4 London Road", Status = StatusType.Open},
            new Customer () {ID = 5, Name = "Eric", Balance = 0, Address = "5 London Road", Status = StatusType.Open},
            new Customer () {ID = 6, Name = "Bella", Balance = -100, Address = "6 London Road", Status = StatusType.Open},
            new Customer () {ID = 5, Name = "Philip", Balance = -1000, Address = "7 London Road", Status = StatusType.Suspended},
        };

        public void Query()
        {
            var query = from Cust in customerList
                        where Cust.Balance <= 0
                        orderby Cust.Balance ascending
                        select new { Cust.ID, Cust.Name, Cust.Balance, Cust.Address, Cust.Status };

            foreach(var Cust in query)
            {

                Console.WriteLine("ID = {0}; Name = {1}; Balance = {2}; Address = {3}; Status = {4};", Cust.ID, Cust.Name, Cust.Balance, Cust.Address, Cust.Status);
                
            }

            Console.ReadLine();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer obj = new Customer();

            obj.Query();
        }
    }
}
