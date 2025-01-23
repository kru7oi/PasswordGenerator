using System;
using System.Collections.Generic;

namespace PasswordGenerator.AppData
{
    public class GenerationService
    {
        private readonly string _numbers = "1234567890";
        private readonly string _symbols = "!#$%&()*+-_";
        private readonly string _lowerCharacters = "qwertyuiopasdfghjklzxcvbnm";
        private readonly string _upperCharacters = "QWERTYUIOPASDFGHJKLZXCVBNM";
        private readonly string[] _words = { "cat", "dog", "mouse", "elephant" };
        private readonly Random random = new Random();
        public GenerationService(int length, int numberOfPasswords, bool hasNumbers, bool hasSymbols, bool isUpper, bool isLower, bool hasWords)
        {
            Length = length;
            HasNumbers = hasNumbers;
            HasSymbols = hasSymbols;
            IsUpper = isUpper;
            IsLower = isLower;
            HasWords = hasWords;
        }

        public int Length { get; private set; }
        public int NumberOfPasswords { get; private set; }
        public bool HasNumbers { get; private set; }
        public bool HasSymbols { get; private set; }
        public bool IsUpper { get; private set; }
        public bool IsLower { get; private set; }
        public bool HasWords { get; private set; }

        public List<string> Start()
        {
            string password = string.Empty;
            List<string> patterns = new List<string>() { _numbers, _symbols, _lowerCharacters, _upperCharacters };
            List<string> passwords = new List<string>();





            return passwords;
        }
    }
}
