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

        [TestMethod]
        public void TestGiveMoney()
        {
            int amount = -1;
            int totalMoney = 1000;
            int result = BankController.giveMoney(amount);

            Assert.AreEqual(amount, -1, "So tien rut khong duoc nho hon 0");

        }
    }
}
