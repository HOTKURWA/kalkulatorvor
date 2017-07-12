using Kalkulator.OneArg;
using NUnit.Framework;

namespace Kalkulator.Tests.OneArg
{
    [TestFixture]
    public class TenToThePowerXTests
    {
        [Test]
        public void TenToThePowerXTest()
        {
            var calc = new TenToThePowerX();
            double first = 2;
            double result = calc.Calculate(first);
            Assert.AreEqual(100, result);
        }
    }
}
