using System;
using Xunit;

namespace Palindromes.Tests
{
    public class check_palindrome_bool
    {
        [Fact]
        public void stars_returns_false()
        {
            var phrase = "Stars";
            var expectedResult = false;
            var test = new Palindrome();

            var actualResult = test.checkPalindrome(phrase);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void o_a_kak_returns_true()
        {
            var phrase = "O, a kak Uwakov lil vo kawu kakao!";
            var expectedResult = true;
            var test = new Palindrome();

            var actualResult = test.checkPalindrome(phrase);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void some_men_returns_true()
        {
            var phrase = "Some men interpret nine memos";
            var expectedResult = true;
            var test = new Palindrome();

            var actualResult = test.checkPalindrome(phrase);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}
