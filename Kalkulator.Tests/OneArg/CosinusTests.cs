using Kalkulator.OneArg;
using NUnit.Framework;

namespace Kalkulator.Tests.OneArg
{
    [TestFixture]
    public class CosinusTests
    {
        [TestCase(0, 0, 1 )]
        [TestCase(60, 0, -0.9524129804)]
        [TestCase(3, 0, -0.9899924966)]
        public void CosinusTest(double first, double expected)
        {
            var calc = new Cosinus();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}
