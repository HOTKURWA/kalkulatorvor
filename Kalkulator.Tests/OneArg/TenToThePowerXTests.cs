using Kalkulator.OneArg;
using NUnit.Framework;

namespace Kalkulator.Tests.OneArg
{
    [TestFixture]
    public class TenToThePowerXTests
    {
        [TestCase(0, 1)]
        [TestCase(2, 100)]
        [TestCase(-1, 0.1)]
        public void TenToThePowerXTest(double first, double expected)
        {
            var calc = new TenToThePowerX();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}
