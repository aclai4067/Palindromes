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
            List<char> phraseToChar = new List<char>();

            foreach (var character in Phrase.ToLower()) phraseToChar.Add(character);

            var forward = string.Concat(phraseToChar);
            var backward = string.Concat(phraseToChar.AsEnumerable().Reverse());

            var comparePhraseDirection = string.Compare(forward, backward, CultureInfo.CurrentCulture, CompareOptions.IgnoreSymbols);
            if (comparePhraseDirection == 0) isPalindrome = true;
            
            return isPalindrome;
        }
    }
}
