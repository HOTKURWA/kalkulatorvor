using Kalkulator.OneArg;
using NUnit.Framework;

namespace Kalkulator.Tests.OneArg
{
    [TestFixture]
    public class SinusTests
    {
        [TestCase(0, 0)]
        [TestCase(60, -0.30481062110221668)]
        [TestCase(3, 0.14112000805986721)]
        public void SinusTest(double first, double expected)
        {
            var calc = new Sinus();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}
