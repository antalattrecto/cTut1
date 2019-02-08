using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraytut
{
    class Program
    {
        static void Main(string[] args)
        {
            //one dimensional array
            string[] array1d = { "pulyki", "mulyki", "serek", "hujon" };
            ShowArrayInfo(array1d);

            //two dimensional array
            string[,] array2d = { { "monday", "tuesday" }, { "may", "june" } };
            ShowArrayInfo(array2d);

            //three dimensional array
            int[, ,] array3d = { { { 1, 2, 3 }, { 4, 5, 6 } } };
            ShowArrayInfo(array3d);
        } 

        private static void ShowArrayInfo (Array arr)
        {
            Console.WriteLine("Length of array is:             {0,3}", arr.Length);
            Console.WriteLine("Dimension of array is:          {0,3}", arr.Rank);

            if (arr.Rank > 1)

            {
                for (int dimension = 1; dimension <= arr.Rank; dimension++)
                    Console.WriteLine("   Dimension {0}: {1,3}", dimension, arr.GetUpperBound(dimension - 1) + 1);
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}
