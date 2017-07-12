using Kalkulator.TwoArg;
using NUnit.Framework;
using System;

namespace Kalkulator.Tests.TwoArg
{
    [TestFixture]
    public class LogXfromYTests
    {
        [TestCase(2, 2, 1)]
        [TestCase(6, 36, 2)]
        [TestCase(2, 4, 0.5)]
        public void DivisionTest(double first, double second, double expected)
        {
            var calc = new Division();
            double result = calc.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void DivisionByZeroTest()
        {
            var calc = new Division();
            Assert.Throws<Exception>(() => calc.Calculate(1, 0));
            Assert.Throws<Exception>(() => calc.Calculate(3, 0));
            Assert.Throws<Exception>(() => calc.Calculate(-3, 4));
        }
    }
}