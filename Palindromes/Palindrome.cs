using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Palindromes
{
    public class Palindrome
    {
        public bool checkPalindrome(string Phrase)
        {
            var isPalindrome = false;
            List<char> phraseNoSpaces = new List<char>();
            foreach (var character in Phrase.ToLower())
            {
                phraseNoSpaces.Add(character);
            }
            var forward = string.Concat(phraseNoSpaces);
            var backward = string.Concat(phraseNoSpaces.AsEnumerable().Reverse());
            var comparePhraseDirection = string.Compare(forward, backward, CultureInfo.CurrentCulture, CompareOptions.IgnoreSymbols);
            if (comparePhraseDirection == 0)
            {
                isPalindrome = true;
            }
            return isPalindrome;
        }
    }
}
