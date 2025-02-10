using System;
using System.Collections.Generic;

namespace PasswordGenerator.AppData
{
    public class GenerationService
    {
        private const string UPPER_CASE = "QWERTYUIOPASDFGHJKKLZXCVBNM";
        private const string LOWER_CASE = "qwertyuiopasdfghjklzxcvbnm";
        private const string NUMBERS = "0123456789";
        private const string SEPARATORS = "-_";
        private const string SYMBOLS = "!@#$%^&*()";

        private readonly string pattern;

        public GenerationService(bool useUpperCase, bool useLowerCase, bool useNumbers, bool useSeparators, bool useSymbols)
        {
            if (useUpperCase) pattern += UPPER_CASE;
            if (useLowerCase) pattern += LOWER_CASE;
            if (useNumbers) pattern += NUMBERS;
            if (useSeparators) pattern += SEPARATORS;
            if (useSymbols) pattern += SYMBOLS;
        }

        public List<string> GeneratePassword(int length, int countOfPassword)
        {
            List<string> passwords = new List<string>();
            string password = string.Empty;

            Random random = new Random();

            // Реализовать кол-во повторений в зависимости от countOfPassword.

            for (int i = 0; i < length; i++)
            {
                int characterIndex = random.Next(pattern.Length);
                password += pattern[characterIndex];
            }

            passwords.Add(password);

            return passwords;
        }
    }
}
