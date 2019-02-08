using System;
using System.Text;
using System.Security.Cryptography;

namespace Hash
{
    

    class Hash
    {
        public string inputString { get; set; }

        public static byte[] GetHash(string inputString)
    {
        HashAlgorithm algorithm = SHA256.Create();
        return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
    }

    public static string GetHashString(string inputString)
    {
        StringBuilder sb = new StringBuilder();
        foreach (byte b in GetHash(inputString))
            sb.Append(b.ToString("X2"));

        return sb.ToString();
    }
    static void Main(string[] args)
        {
            string result;

            Hash GetStuff = new Hash();

            Console.Write("User name: ");
            GetStuff.inputString = Console.ReadLine();
            result = Convert.ToString(Hash.GetHashString(GetStuff.inputString));
            Console.Write("Hashed username: {0}", result);
            Console.ReadLine();

            

        }
    }
}
