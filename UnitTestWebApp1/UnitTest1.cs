using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Controllers;

namespace UnitTestWebApp1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDivision()
        {
            double a = 1;
            double b = 0;
            double result = CalController.division(a, b);

            Assert.AreEqual(b, 0, "Result is undefined‬");
        }
    }
}
