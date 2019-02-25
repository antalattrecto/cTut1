using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Lists3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> customers = new List<string>();
            string userInput;
            string path = "E:\\List.txt";
         
            

            Console.WriteLine("Capacity: {0}", customers.Capacity);

            customers.Add("JOHN");
            customers.Add("PETE");
            customers.Add("CHARLOTTE");
            customers.Add("ADAM");
            customers.Add("BILL");
            customers.Add("BRAD");
            customers.Add("GILL");
            customers.Add("JULIA");
            customers.Add("ELTON");
            customers.Add("ROBBY");

            foreach (string customer in customers)
            {
                Console.WriteLine(customer);
            }

            Console.WriteLine("Capacity: {0}", customers.Capacity);
            Console.WriteLine("Count: {0}", customers.Count);

            Start:
            while (customers.Count > 8)
            {
                Console.WriteLine("Type in a name to remove: ");
                userInput = Convert.ToString(Console.ReadLine());

                string query = (from customer in customers where customer == userInput.ToUpper() select customer).FirstOrDefault();

                if (query is null)
                {
                    Console.WriteLine("No results");
                    goto Start;

                }

                else
                {
                    customers.Remove(query);
                }

                foreach (string customer in customers)
                {
                    Console.WriteLine(customer);
                }

                Console.WriteLine("Count: {0}", customers.Count);

            }

            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string name = sr.ReadLine();

                        customers.Add(name);
                       
                    }
                }

            }

            else
            {
                Console.WriteLine("The file does not exists.");

            }

            foreach (string customer in customers)
            {
                Console.WriteLine(customer);
            }
            
            Console.ReadLine();
        }
    }
}
