using System;

namespace Arrays
{
    class Arrays
    {


        public void GetLength()
        {
            int[] userAge = { 22, 23, 24, 25, 26, 27 };


            //write array length to console - 6

            Console.WriteLine("Length of Array is:");

            Console.Write("{0}", userAge.Length);

            Console.WriteLine();
           
        }

        public void copyArray()

        {
            string[] source = {"january", "february" };
            string[] dest = {"monday", "tuesday" };

            Array.Copy(source, dest, 1);

            Console.WriteLine("Copied Array is: ");

            foreach (string str in dest)
            {
                Console.Write("{0}, ", str);
               
            }

        }

        public void SortArray()
        {
            int[] sortArray = {23, 4, -1, 6, 232 };

            Array.Sort(sortArray);

            Console.WriteLine();

            Console.WriteLine("Sorted Array is: ");

            foreach (int i in sortArray)

            {
                Console.Write(i + ", ");
            }
        }

        public void IndexOfArray()
        {
            int [] intArray = {1, 2, 3, 4, 5};
            string[] stringArray = {"Heron", "Robin", "Woodpecker" };

            int intResult1 = Array.IndexOf(intArray, 4);
            int intResult2 = Array.IndexOf(intArray, 6);

            int stringResult1 = Array.IndexOf(stringArray, "Robin");
            int stringResult2 = Array.IndexOf(stringArray, "Poppy");

            Console.WriteLine();
            Console.WriteLine("Result 1: {0}; Result 2: {1}; Result 3: {2}; Result 4: {3}", intResult1, intResult2, stringResult1, stringResult2);

        }
       

        static void Main(string[] args)
        {
            Arrays GetThings = new Arrays();

            GetThings.GetLength();
            GetThings.copyArray();
            GetThings.SortArray();
            GetThings.IndexOfArray();
            
           
            Console.Read();

        }
    }
}
