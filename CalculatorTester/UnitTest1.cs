using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator2;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        Calculation cal;
        
        public TestContext TestContext { get; set; }
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
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"D:\DEMO\Calculator2\CalculatorTester\Data\TextData.csv", "TextData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestWithDataSource()
        {
            Calculation c;
            //Random rand = new Random();
            //string[] str = { "+", "-", "*", "/" };
            //int phepToan = rand.Next(0, 4);
            //string phepTinh;
            int a, b, expected;
            string operation;
            a = int.Parse(TestContext.DataRow[0].ToString());
            b = int.Parse(TestContext.DataRow[1].ToString());
            operation = TestContext.DataRow[2].ToString();
            operation = operation.Remove(0, 1);
            expected = int.Parse(TestContext.DataRow[3].ToString());
            c = new Calculation(a, b);
            Assert.AreEqual(expected, c.Execute(operation));
        }

        [TestMethod]
        public void CompareTest()
        {
            Calculation c;
            int a, b, expected, actural;
            a = 3;
            b = 2;
            c = new Calculation(a, b);
            expected = 1;
            actural = c.SoSanh(a, b);
            Assert.AreEqual(1, actural);

        }
        [TestMethod]
        public void PowerTest()
        {
            Calculation c;
            double a;
            int b;
            int expected;
            double actural;
            a = 2;
            b = 0;
            
            c = new Calculation(a, b);
            expected = 1;
            actural = c.Power(a, b);
            Assert.AreEqual(1, actural);

        }
       
    }
}
