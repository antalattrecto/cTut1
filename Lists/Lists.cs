using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Lists
    {
        public List<int> intList = new List<int> {0,1,2,3,4,5,6,7,8,9};
        
        public void DisplayList()
        {
            List<int> intListResultEven = intList.FindAll(x => (x % 2) == 0);
            List<int> intListResultOdd = intList.FindAll(x => (x % 2) != 0);
            

            foreach (int res in intListResultEven)
            {
                Console.Write("{0}, ", res);
                
            }
            Console.WriteLine();

            foreach (int res in intListResultOdd)
            {
                Console.Write("{0}, ", res);
            }

            }
        
        static void Main(string[] args)
        {
           

            List<int> intList1 = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Lists GetStuff = new Lists();

            intList1.Add(11);

            foreach (int res in intList1)
            {
                Console.Write("{0}", res);
                Console.Read();
            }

            GetStuff.DisplayList();

            


            Console.ReadLine();
            
        }
    }
}
