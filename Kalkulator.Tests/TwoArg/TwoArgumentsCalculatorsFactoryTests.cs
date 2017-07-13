using Kalkulator.TwoArg;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class TwoArgumentFactoryTest
    {
        [TestCase("Sum", typeof(Addition))]
        [TestCase("Mul", typeof(Multiply))]
        [TestCase("Div", typeof(Division))]
        public void CalculateTest(string testName, Type expected)
        {
            var calculator = TwoArgumentsCalculatorsFactory.CreateCalculator(testName);
            Assert.AreEqual(expected, calculator.GetType());
        }
    }