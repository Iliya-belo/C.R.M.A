using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace FinalProject.Classes
{
    class hashing
    {
        // Field
        private string hash = "f0xle@rn";

        // Encrypts password
        public string encryptPassword(string password)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(password);
            using(MD5CryptoServiceProvider md5=new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider trip= new TripleDESCryptoServiceProvider(){ Key=keys,Mode=CipherMode.ECB,Padding=PaddingMode.PKCS7})
                {
                    ICryptoTransform transform = trip.CreateEncryptor();
                    byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                    password = Convert.ToBase64String(result, 0, result.Length);
                }
            }
            return password;
        }

        // Decrypt password
        public string decryptPassword(string password)
        {
            byte[] data = Convert.FromBase64String(password);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider trip = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = trip.CreateDecryptor();
                    byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                    password = UTF8Encoding.UTF8.GetString(result);
                }
            }
            return password;
        }
    }
}
