using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NARFO_BE
{
    public class encryption
    {
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
        }
    }
}
