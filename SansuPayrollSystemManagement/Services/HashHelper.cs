using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SansuPayrollSystemManagement.Services
{
    internal class HashHelper
    {
        public static string HashPassword(string password)
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[16];
                rng.GetBytes(salt);
                var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
                byte[] hash = pbkdf2.GetBytes(32); // 256-bit
                byte[] hashBytes = new byte[49]; // 16 salt + 32 hash + 1 version
                Buffer.BlockCopy(salt, 0, hashBytes, 1, 16);
                Buffer.BlockCopy(hash, 0, hashBytes, 17, 32);
                hashBytes[0] = 0; // version
                return Convert.ToBase64String(hashBytes);
            }
        }

        public static bool VerifyPassword(string password, string storedHash)
        {
            try
            {
                byte[] hashBytes = Convert.FromBase64String(storedHash);
                if (hashBytes[0] != 0) return false;
                byte[] salt = new byte[16];
                Buffer.BlockCopy(hashBytes, 1, salt, 0, 16);
                var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
                byte[] hash = pbkdf2.GetBytes(32);
                for (int i = 0; i < 32; i++)
                {
                    if (hashBytes[i + 17] != hash[i]) return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
