using Kalkulator.OneArg;
using NUnit.Framework;

namespace Kalkulator.Tests.OneArg
{
    [TestFixture]
    public class CosinusTests
    {
        [TestCase(0, 1 )]
        [TestCase(60, -0.95241298041515632)]
        [TestCase(3, -0.98999249660044542)]
        public void CosinusTest(double first, double expected)
        {
            var calc = new Cosinus();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}
