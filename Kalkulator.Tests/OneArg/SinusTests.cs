using Kalkulator.OneArg;
using NUnit.Framework;

namespace Kalkulator.Tests.OneArg
{
    [TestFixture]
    public class SinusTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(60, 0, 0.8660254038)]
        [TestCase(3, 0, 0.0523359562)]
        public void SinusTest(double first, double expected)
        {
            var calc = new Sinus();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}
