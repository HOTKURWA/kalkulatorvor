using Kalkulator.OneArg;
using NUnit.Framework;

namespace Kalkulator.Tests.OneArg
{
    [TestFixture]
    public class ExptoThePowerXTests
    {
        [TestCase(0, 0, 1)]
        [TestCase(2, 0, 7.38906)]
        [TestCase(1, 0, 2.71828)]
        public void ExptoThePowerXTest(double first, double expected)
        {
            var calc = new ExptoThePowerX();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}
 