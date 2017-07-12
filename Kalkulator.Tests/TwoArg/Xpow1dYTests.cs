using Kalkulator.TwoArg;
using NUnit.Framework;
using System;

namespace Kalkulator.Tests.TwoArg
{
    [TestFixture]
    public class Xpow1dYTests
    {
        [TestCase(4, 2, 2)]
        [TestCase(3, 1, 3)]
        [TestCase(-2, 0.5, 4)]
        public void Xpow1dYTest(double first, double second, double expected)
        {
            var calc = new Xpow1dY();
            double result = calc.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void DivisionByZeroTest()
        {
            var calc = new Division();
            Assert.Throws<Exception>(() => calc.Calculate(1, 0));
        }
    }
}
