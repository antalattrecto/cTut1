using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
    class Reader
    {
        public string path = "E:\\Test.txt";
        public string path1 = "E:\\Log.txt";
        public DateTime d = DateTime.Now;

        public void Read()
        {
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.EndOfStream != true)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                    Console.ReadLine();

                    sr.Close();
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(path1, true))
                {
                    sw.WriteLine("{0}- The file does not exist.", d);
                    sw.Close();
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Reader read = new Reader();

            read.Read();
           
            
        }
    }
}
