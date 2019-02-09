using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMethod2
{
    class UserInput
    {
        private int[] a = new int[5];
        private List<int> l = new List<int>();

        public int[] A
        {
            get
            {
                return a;
            }
            set
            {

            }
        }

        public List<int> L
        {
            get
            {
                return l;
            }
            set
            {

            }
        }

        public List<int> GatherInputL()
        {
            int input;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter integer:");
                input = Convert.ToInt32(Console.ReadLine());
                L.Add(input);
            }
            return L;
        }

        public List<int> ReturnInputL()
        {
            List<int> resultList = GatherInputL();

            for(int i=0; i<1;i++)
            {
                resultList.ForEach(Console.Write);
                
            }
            return resultList;
        }

        public int[] GatherInput()
        {
            for (int i = 0; i<A.Length; i++)
            {
                Console.Write("Input your int:");
                A[i] = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Int added to the array");
            }
            return A;
        }

        public void ReturnInput()
        {
            for (int i =0; i<A.Length; i++)
            {
                Console.Write("{0}, ", A[i]);
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {

            UserInput GetStuff = new UserInput();

            GetStuff.GatherInput();
            GetStuff.ReturnInput();
            Console.ReadLine();
            GetStuff.GatherInputL();
            GetStuff.ReturnInputL();
            Console.ReadLine();

        }
    }
}
