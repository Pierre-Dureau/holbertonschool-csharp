using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        /// <summary>
        /// Test a palindrome with Maj
        /// </summary>
        [Test]
        public void PalindromeWithMaj()
        {
            Assert.AreEqual(Str.IsPalindrome("Laval"), true);
        }

        /// <summary>
        /// Test a non palindrome
        /// </summary>
        [Test]
        public void NonPalindrome()
        {
            Assert.AreEqual(Str.IsPalindrome("False"), false);
        }

        /// <summary>
        /// Test a palindrome with ponctuations and space
        /// </summary>
        [Test]
        public void PalindromeWithPonctuationsAndSpace()
        {
            Assert.AreEqual(Str.IsPalindrome("A man, a plan, a canal: Panama."), true);
        }
    }
}