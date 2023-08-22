using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        /// <summary>
        /// Test when the first char is unique
        /// </summary>
        [Test]
        public void FirstCharIsUnique()
        {
            Assert.AreEqual(Str.UniqueChar("abcdef"), 0);
        }

        /// <summary>
        /// Test when the last char is unique
        /// </summary>
        [Test]
        public void LastCharIsUnique()
        {
            Assert.AreEqual(Str.UniqueChar("aabbccd"), 6);
        }

        /// <summary>
        /// Test when the middle char is unique
        /// </summary>
        [Test]
        public void MiddleCharIsUnique()
        {
            Assert.AreEqual(Str.UniqueChar("abcdcba"), 3);
        }

        /// <summary>
        /// Test when there is no unique char
        /// </summary>
        [Test]
        public void NoUniqueChar()
        {
            Assert.AreEqual(Str.UniqueChar("abcdeffedcba"), -1);
        }

        /// <summary>
        /// Test with an empty string
        /// </summary>
        [Test]
        public void EmptyString()
        {
            Assert.AreEqual(Str.UniqueChar(""), -1);
        }
    }
}