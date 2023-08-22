using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        /// <summary>
        /// Test with 1 word
        /// </summary>
        [Test]
        public void OneWord()
        {
            Assert.AreEqual(Str.CamelCase("camel"), 1);
        }

        /// <summary>
        /// Test with 2 words
        /// </summary>
        [Test]
        public void TwoWords()
        {
            Assert.AreEqual(Str.CamelCase("camelCase"), 2);
        }

        /// <summary>
        /// Test with 4 words
        /// </summary>
        [Test]
        public void FourWords()
        {
            Assert.AreEqual(Str.CamelCase("camelCaseIsGreat"), 4);
        }

        /// <summary>
        /// Test with an empty string
        /// </summary>
        [Test]
        public void EmptyString()
        {
            Assert.AreEqual(Str.CamelCase(""), 0);
        }
    }
}