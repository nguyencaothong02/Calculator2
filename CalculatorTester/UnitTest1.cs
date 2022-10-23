using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator2;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        Calculation cal;
        [TestInitialize]
        public void SetUp()
        {
            cal = new Calculation(10, 5);
        }

        [TestMethod]
        public void TestAddOperation()
        {            
            Assert.AreEqual(15, cal.Execute("+"));
        }
        [TestMethod]
        public void TestSubOperation()
        {          
            Assert.AreEqual(5, cal.Execute("-"));
        }
        [TestMethod]
        public void TestMulOperation()
        {      
            Assert.AreEqual(50, cal.Execute("*"));
        }
        [TestMethod]
        public void TestDivOperation()
        {
            Assert.AreEqual(2, cal.Execute("/"));
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivByZero()
        {
            Calculation c = new Calculation(10, 0);
            c.Execute("/");
        }
    }
}
