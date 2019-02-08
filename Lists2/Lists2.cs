using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists2
{
    class Lists2
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int contResult1 = numbers.Count;

            numbers.Add(10);
            numbers.Insert(11, -1);
            numbers.Remove(-1);
            numbers.RemoveAt(10);
            bool result = numbers.Contains(54);
            numbers.Clear();

            int countResult2 = numbers.Count;

            Console.WriteLine("Before: {0}; After: {1} Contains?: {2}", contResult1, countResult2, result);
            Console.Read();
        }
    }
}
