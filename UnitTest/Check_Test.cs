using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class Check_Test
    {
        [TestMethod]
        public void TestCase1()
        {
            String result = Code.KiemTraTamGiac.Check(4, 6, 8);
            String expected = Code.global.TGTHUONG;
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestCase2()
        {
            String result = Code.KiemTraTamGiac.Check(4, 4, 4);
            String expected = Code.global.TGDEU;
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestCase3()
        {
            String result = Code.KiemTraTamGiac.Check(3, 4, 5);
            String expected = Code.global.TGVUONG;
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestCase4()
        {
            String result = Code.KiemTraTamGiac.Check(7, 7, 9);
            String expected = Code.global.TGCAN;
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestCase5()
        {
            String result = Code.KiemTraTamGiac.Check(4, 6, 8);
            String expected = Code.global.TGTHUONG;
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestCase6()
        {
            String result = Code.KiemTraTamGiac.Check(1, 1, 3);
            String expected = Code.global.KPTAMGIAC;
            Assert.AreEqual(expected, result);
        }
    }
}
