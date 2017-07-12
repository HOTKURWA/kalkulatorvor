using Kalkulator.OneArg;
using NUnit.Framework;

namespace Kalkulator.Tests.OneArg
{
    [TestFixture]
    public class TangensTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(60, 0, 1.7320508076)]
        [TestCase(3, 0, 0.0524077793)]
        public void TangensTest(double first, double expected)
        {
            var calc = new Tangens();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}
