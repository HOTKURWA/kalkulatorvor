using Kalkulator.TwoArg;
using NUnit.Framework;

namespace Kalkulator.Tests.TwoArg
{
    [TestFixture]
    public class MultiplyTests
    {
        [TestCase(2, 2, 4)]
        [TestCase(3, -4, -12)]
        [TestCase(0, 2, 0)]
        public void MultiplyTest(double first, double second, double expected)
        {
            var calc = new Multiply();
            double result = calc.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }

    }
}
