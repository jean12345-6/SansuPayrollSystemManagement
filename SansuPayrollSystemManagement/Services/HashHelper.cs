using System;
using System.Security.Cryptography;
using System.Text;

namespace SansuPayrollSystemManagement.Services
{
    public static class HashHelper
    {
        private const int SaltSize = 16;
        private const int KeySize = 32;
        private const int Iterations = 10000;

        public static string HashPassword(string password)
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[SaltSize];
                rng.GetBytes(salt);

                using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations))
                {
                    byte[] key = pbkdf2.GetBytes(KeySize);
                    return $"{Iterations}${Convert.ToBase64String(salt)}${Convert.ToBase64String(key)}";
                }
            }
        }

        public static bool VerifyPassword(string password, string storedHash)
        {
            try
            {
                var parts = storedHash.Split('$');
                if (parts.Length != 3) return false;

                int iterations = int.Parse(parts[0]);
                byte[] salt = Convert.FromBase64String(parts[1]);
                byte[] storedKey = Convert.FromBase64String(parts[2]);

                using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations))
                {
                    byte[] key = pbkdf2.GetBytes(storedKey.Length);
                    return SlowEquals(key, storedKey);
                }
            }
            catch
            {
                return false;
            }
        }

        private static bool SlowEquals(byte[] a, byte[] b)
        {
            uint diff = (uint)a.Length ^ (uint)b.Length;

            for (int i = 0; i < a.Length && i < b.Length; i++)
            {
                diff |= (uint)(a[i] ^ b[i]);
            }

            return diff == 0;
        }
    }
}
