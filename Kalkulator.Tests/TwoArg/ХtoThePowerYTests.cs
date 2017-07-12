using Kalkulator.TwoArg;
using NUnit.Framework;

namespace Kalkulator.Tests.TwoArg
{
    [TestFixture]
    public class ХtoThePowerYTests
    {
        [TestCase(2, 2, 4)]
        [TestCase(4, -1, 0.25)]
        [TestCase(4, 0.5, 2)]
        public void ХtoThePowerYTest(double first, double second, double expected)
        {
            var calc = new ХtoThePowerY();
            double result = calc.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}
