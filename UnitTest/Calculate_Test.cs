using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class Calculate_Test
    {
        [TestMethod]
        public void TestCase1()
        {
            decimal result = Code.TinhTienDien.Calculate(0);
            decimal expected = 0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestCase2()
        {
            decimal result = Code.TinhTienDien.Calculate(500);
            decimal expected = 1321870;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestCase3()
        {
            decimal result = Code.TinhTienDien.Calculate(100);
            decimal expected = 187660;
            Assert.AreEqual(expected, result);
        }
    }
}
