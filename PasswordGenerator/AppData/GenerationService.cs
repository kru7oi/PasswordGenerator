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

        private readonly List<string> patterns = new List<string>();

        public GenerationService(bool useUpperCase, bool useLowerCase, bool useNumbers, bool useSeparators, bool useSymbols)
        {
            if (useUpperCase) patterns.Add(UPPER_CASE);
            if (useLowerCase) patterns.Add(LOWER_CASE);
            if (useNumbers) patterns.Add(NUMBERS);
            if (useSeparators) patterns.Add(SEPARATORS);
            if (useSymbols) patterns.Add(SYMBOLS);
        }

        public List<string> GeneratePassword(int length, int countOfPasswords)
        {
            List<string> passwords = new List<string>();
            string password = string.Empty;
            Random random = new Random();

            for (int i = 0; i < countOfPasswords; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    int patternIndex = random.Next(0, patterns.Count);
                    int charIndexFromPattern = random.Next(0, patterns[patternIndex].Length);

                    password += patterns[patternIndex][charIndexFromPattern];
                }

                passwords.Add(password);
            }

            return passwords;
        }
    }
}
