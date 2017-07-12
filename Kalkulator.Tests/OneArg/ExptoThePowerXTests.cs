using Kalkulator.OneArg;
using NUnit.Framework;

namespace Kalkulator.Tests.OneArg
{
    [TestFixture]
    public class ExptoThePowerXTests
    {
        [Test]
        public void ExptoThePowerXTest()
        {
            var calc = new ExptoThePowerX();
            double first = 0;
            double result = calc.Calculate(first);
            Assert.AreEqual(1, result);
        }
    }
}
