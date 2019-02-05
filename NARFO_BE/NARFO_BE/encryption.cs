using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NARFO_BE
{
    public class encryption
    {/*
        public static String sha256_hash(string value)
        {
            StringBuilder Password = new StringBuilder();

            using (var hash = SHA256.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Password.Append(b.ToString("x2"));
            }

            return Password.ToString();
        }*/
        


       public static byte[] SaltBytes { get; private set; }
        public enum Supported_HA
        {
            SHA256
        }

       
        public static string ComputeHash(string plainText)
        {
            string value = "shasha";
            byte[] salt = Encoding.ASCII.GetBytes(value);
            //int minSaltLength = 4, maxSaltLength = 16;

           
           /* else
            {
                Random r = new Random();
                int SaltLength = r.Next(minSaltLength, maxSaltLength);
                SaltBytes = new byte[SaltLength];
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                rng.GetNonZeroBytes(SaltBytes);
                rng.Dispose();
            }
            */
            byte[] plainData = ASCIIEncoding.UTF8.GetBytes(plainText);
            byte[] plainDataWithSalt = new byte[plainData.Length + salt.Length];

            for (int x = 0; x < plainData.Length; x++)
                plainDataWithSalt[x] = plainData[x];
            for (int n = 0; n < salt.Length; n++)
                plainDataWithSalt[plainData.Length + n] = salt[n];

            byte[] hashValue = null;

          
            SHA256Managed sha = new SHA256Managed();
            hashValue = sha.ComputeHash(plainDataWithSalt);
            sha.Dispose();
                   

            byte[] result = new byte[hashValue.Length + salt.Length];
            for (int x = 0; x < hashValue.Length; x++)
                result[x] = hashValue[x];
            for (int n = 0; n < salt.Length; n++)
                result[hashValue.Length + n] = salt[n];

            return Convert.ToBase64String(result);
        }

        public static bool Confirm(string plainText, string hashValue)
        {
            
            byte[] hashBytes = Convert.FromBase64String(hashValue);
            int hashSize = 32;

            byte[] saltBytes = new byte[hashBytes.Length - hashSize];

            for (int x = 0; x < saltBytes.Length; x++)
                saltBytes[x] = hashBytes[hashSize + x];

            string newHash = ComputeHash(plainText);

            return (hashValue == newHash);
        }
    }
}
