using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class CanChi_Test
    {
        [TestMethod]
        public void TestCase1()
        {
            String result = Code.AmLich.CanChi(2019);
            String expected = "Kỷ Hợi";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestCase2()
        {
            String result = Code.AmLich.CanChi(-1);
            String expected = "Không hợp lệ";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestCase3()
        {
            String result = Code.AmLich.CanChi(2021);
            String expected = "Tân Sửu";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestCase4()
        {
            String result = Code.AmLich.CanChi(2003);
            String expected = "Quý Mùi";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestCase5()
        {
            String result = Code.AmLich.CanChi(2024);
            String expected = "Giáp Thìn";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestCase6()
        {
            String result = Code.AmLich.CanChi(2025);
            String expected = "Ất Tị";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestCase7()
        {
            String result = Code.AmLich.CanChi(2026);
            String expected = "Bính Ngọ";
            Assert.AreEqual(expected, result);
        }
    }
}
