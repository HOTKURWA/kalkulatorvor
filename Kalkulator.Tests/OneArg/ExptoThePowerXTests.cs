using Kalkulator.OneArg;
using NUnit.Framework;

namespace Kalkulator.Tests.OneArg
{
    [TestFixture]
    public class ExptoThePowerXTests
    {
        [TestCase(0, 1)]
        [TestCase(2, 7.3890560989306504)]
        [TestCase(1, 2.7182818284590451)]
        public void ExptoThePowerXTest(double first, double expected)
        {
            var calc = new ExptoThePowerX();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}
 