using System;
using Kalkulator.OneArg;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    public class OneArgumentFactoryTest
    {
        [TestCase("cos", typeof(Cosinus))]
        [TestCase("sin", typeof(Sinus))]
        [TestCase("tan", typeof(Tangens))]
        public void CalculateTest(string testName, Type expected)
        {
            var calculator = OneArgumentsCalculatorsFactory.CreateCalculator(testName);
            Assert.AreEqual(expected, calculator.GetType());
        }
    }
}