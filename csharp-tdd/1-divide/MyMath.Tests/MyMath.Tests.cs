using NUnit.Framework;

namespace MyMath.Tests
{
    public class Tests
    {
        [Test]
        public void DivideMatrixBy2()
        {
            int[,] matrix = new int[,] {{2, 4}, {6, 8}};

            Assert.AreEqual(Matrix.Divide(matrix, 2), new int[,] {{1, 2}, {3, 4}});
        }

        [Test]
        public void DivideMatrixByNegative()
        {
            int[,] matrix = new int[,] {{3, 7, 10}, {6, 9, 16}, {-6, -15, 0}};

            Assert.AreEqual(Matrix.Divide(matrix, -3), new int[,] {{-1, -2, -3}, {-2, -3, -5}, {2, 5, 0}});
        }

        [Test]
        public void DivideBy0()
        {
            int[,] matrix = new int[,] {{2, 4}, {6, 8}};

            Assert.AreEqual(Matrix.Divide(matrix, 0), null);
        }

        [Test]
        public void MatrixNull()
        {
            int[,] matrix = null;

            Assert.AreEqual(Matrix.Divide(matrix, 5), null);
        }
    }
}
