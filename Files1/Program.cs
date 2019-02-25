using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "E:\\myFile.txt";

            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine("ABC");
                sw.WriteLine("DEF");
                sw.Close();
            }
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                            
                    }
                    Console.Read();
                    sr.Close();
                }
            }
        }
    }
}
