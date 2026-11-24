using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace ITDictionary
{
    public static class PasswordHelper
    {
        public static string CreateSalt()
        {
            return Convert.ToBase64String(RandomNumberGenerator.GetBytes(16));
        }

        public static string Hash(string password, string salt)
        {
            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
                password, Convert.FromBase64String(salt), 100000, HashAlgorithmName.SHA256, 32);
            return Convert.ToBase64String(hash);
        }

        public static bool Verify(string password, string salt, string storedHash)
        {
            return Hash(password, salt) == storedHash;
        }

        public static bool HasMinLength(string p) => p.Length >= 8;
        public static bool HasUpper(string p) => Regex.IsMatch(p, "[A-Z]");
        public static bool HasLower(string p) => Regex.IsMatch(p, "[a-z]");
        public static bool HasNumber(string p) => Regex.IsMatch(p, "[0-9]");
        public static bool HasSpecial(string p) => Regex.IsMatch(p, "[^a-zA-Z0-9]");

        public static int Score(string p)
        {
            int score = 0;
            if (HasMinLength(p)) score++;
            if (HasUpper(p)) score++;
            if (HasLower(p)) score++;
            if (HasNumber(p)) score++;
            if (HasSpecial(p)) score++;
            return score;
        }

        public static bool IsStrong(string p) => Score(p) == 5;
    }
}