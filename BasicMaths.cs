using Microsoft.VisualStudio.TestTools.UnitTesting;
using RSASoftOnline;
using System;

namespace RSASoftOnlineTest
{
    [TestClass]  
    public class BasicMaths
    {
        [TestMethod]
        public void Test_AddMethod()
        {
            RSASoftOnline.BasicMaths bm = new RSASoftOnline.BasicMaths();
            double res = bm.Add(10, 10);
            Assert.AreEqual(res, 20);
        }
        [TestMethod]
        public void Test_SubstractMethod()
        {
            RSASoftOnline.BasicMaths bm = new RSASoftOnline.BasicMaths();
            double res = bm.Substract(10, 10);
            Assert.AreEqual(res, 0);
        }
        [TestMethod]
        public void Test_DivideMethod()
        {
            RSASoftOnline.BasicMaths bm = new RSASoftOnline.BasicMaths();
            double res = bm.Divide(10, 5);
            Assert.AreEqual(res, 2);
        }
        [TestMethod]
        public void Test_MultiplyMethod()
        {
            RSASoftOnline.BasicMaths bm = new RSASoftOnline.BasicMaths();
            double res = bm.Multiply(10, 10);
            Assert.AreEqual(res, 100);
        }
    }
}
