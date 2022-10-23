using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Caculator;

namespace TestCaculator
{
    [TestClass]
    public class UnitTest1
    {
        Caculation cal;
        [TestInitialize]
        public void Setup()
        {
            cal = new Caculation(10, 5);
        }
        [TestMethod]
        public void TestOperator()
        {
            Assert.AreEqual(15,cal.Execute("+"));
        }

        [TestMethod]
        public void TestMinus()
        {
            Assert.AreEqual(5, cal.Execute("-"));
        }

        [TestMethod]
        public void Testtime()
        {
            Assert.AreEqual(50, cal.Execute("*"));
        }

        [TestMethod]
        public void Testdivi()
        {
            Assert.AreEqual(2, cal.Execute("/"));
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDividedbyzero()
        {
            Caculation c = new Caculation(10, 0);
            c.Execute("/");
        }
    }
}
