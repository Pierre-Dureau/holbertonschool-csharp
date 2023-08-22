using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    /// <summary>
    /// Represent the Test class
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// Maximum of a List of positive numbers
        /// </summary>
        [Test]
        public void MaxOfPositiveNumbers()
        {
            Assert.AreEqual(Operations.Max(new List<int>(){2, 7, 3}), 7);
        }

        /// <summary>
        /// Maximum of a List of negative numbers
        /// </summary>
        [Test]
        public void MaxOfNegativeNumbers()
        {
            Assert.AreEqual(Operations.Max(new List<int>(){-2, -7, -3}), -2);
        }

        /// <summary>
        /// Maximum of an empty List
        /// </summary>
        [Test]
        public void EmptyList()
        {
            Assert.AreEqual(Operations.Max(new List<int>(){}), 0);
        }
    }
}
