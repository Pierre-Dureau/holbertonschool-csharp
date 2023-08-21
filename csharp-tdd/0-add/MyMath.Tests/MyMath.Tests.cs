using NUnit.Framework;

namespace MyMath.Tests
{
    /// <summary>
    /// Represent the Test class
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// Test an addition with 2 positive Int
        /// </summary>
        [Test]
        public void AdditionOfTwoInt()
        {
            Assert.AreEqual(Operations.Add(2, 5), 7);
        }

        /// <summary>
        /// Test an addition with 2 negative Int
        /// </summary>
        [Test]
        public void AdditionOfTwoNegativeInt()
        {
            Assert.AreEqual(Operations.Add(-4, -12), -16);
        }
    }
}
