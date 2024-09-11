using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace LibraryProject.Modules
{
    
    class CommonModule
    {
        private static readonly string KEY = "EpsmBYwin1Afe5F5LgM8udYBJ2KpyZUlIA5/G+SS8kY=".Substring(0, 128 / 8);

        public string DecodeByAES128(string encrypt)
        {
            byte[] encryptBytes = Convert.FromBase64String(encrypt);

            RijndaelManaged rijndael = new RijndaelManaged();
            rijndael.Mode = CipherMode.CBC;
            rijndael.Padding = PaddingMode.PKCS7;
            rijndael.KeySize = 128;

            MemoryStream memoryStream = new MemoryStream(encryptBytes);
            ICryptoTransform decryptor = rijndael.CreateDecryptor(Encoding.UTF8.GetBytes(KEY), Encoding.UTF8.GetBytes(KEY));
            CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);

            byte[] plainBytes = new byte[encryptBytes.Length];

            int plainCount = cryptoStream.Read(plainBytes, 0, plainBytes.Length);

            string plainString = Encoding.UTF8.GetString(plainBytes, 0, plainCount);

            cryptoStream.Close();
            memoryStream.Close();

            return plainString;
        }

        public static string EncodeByAES128(string plain)
        {
            byte[] plainBytes = Encoding.UTF8.GetBytes(plain);

            RijndaelManaged rijndael = new RijndaelManaged();

            rijndael.Mode = CipherMode.CBC;

            rijndael.Padding = PaddingMode.PKCS7;

            rijndael.KeySize = 128;
            MemoryStream memoryStream = new MemoryStream();
            ICryptoTransform encryptor = rijndael.CreateEncryptor(Encoding.UTF8.GetBytes(KEY), Encoding.UTF8.GetBytes(KEY));

            CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(plainBytes, 0, plainBytes.Length);
            cryptoStream.FlushFinalBlock();

            byte[] encryptBytes = memoryStream.ToArray();
            string encryptString = Convert.ToBase64String(encryptBytes);

            cryptoStream.Close();
            memoryStream.Close();

            return encryptString;
        }
    }
}

