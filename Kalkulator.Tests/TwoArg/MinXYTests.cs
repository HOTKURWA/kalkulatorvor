﻿using Kalkulator.TwoArg;
using NUnit.Framework;

namespace Kalkulator.Tests.TwoArg
{
    [TestFixture]
    public class MinXYTests
    {
        [TestCase(5, 2, 2)]
        [TestCase(1, 6, 1)]
        [TestCase(-1, -3, -3)]
        public void MinXYTest(double first, double second, double expected)
        {
            var calc = new MinXY();
            double result = calc.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}
