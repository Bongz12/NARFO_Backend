using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NARFO_API
{
    public class Encript
    {
        public static string Encrypt_user(string pass)
        {
            MD5 newEN = new MD5CryptoServiceProvider();
            newEN.ComputeHash(ASCIIEncoding.ASCII.GetBytes(pass));
            byte[] byteresults = newEN.Hash;
            StringBuilder strb = new StringBuilder();
            for (int a = 0; a < byteresults.Length; a++)
            {
                strb.Append(byteresults[a].ToString("X2"));
            }
            return strb.ToString();
        }
    }
}
