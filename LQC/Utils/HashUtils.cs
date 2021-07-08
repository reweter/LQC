using System;
using System.Security.Cryptography;
using System.Text;

namespace LQC.Utils
{
    public static class HashUtils
    {
        public static char[] Letters = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'q', 'a', 'z', 'w', 's', 'x', 'e', 'd', 'c', 'r', 'f', 'v', 't', 'g', 'b', 'y', 'h', 'n', 'u', 'j', 'm', 'i', 'k', 'o', 'l', 'p' };

        public static string GenesisHash()
        {
            Random rand = new Random();
            char[] sims = new char[10];
            for (int i = 0; i < 10; i++)
                sims[i] = Letters[rand.Next(0, Letters.Length)];
            StringBuilder predHashData = new StringBuilder();
            for (int i = 9; i > 5; i--)
                predHashData.Append(sims[i]);
            predHashData.Append(DateTime.Now.ToString());
            for (int i = 4; i > 0; i--)
                predHashData.Append(sims[i]);
            string HashData = GetSHA256(predHashData.ToString());
            return HashData;
        }

        public static string GetSHA256(string input)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            hashString = HashString(hash, hashString);
            return hashString;
        }

        public static string GetSHA512(string input)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            HMACSHA512 hashstring = new HMACSHA512();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            hashString = HashString(hash, hashString);
            return hashString;
        }

        public static string HashString(byte[] hash, string hashString)
        {
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }
    }
}
