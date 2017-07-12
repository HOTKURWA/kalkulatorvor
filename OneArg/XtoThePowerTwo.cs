using System;

namespace Kalkulator.OneArg
{
    public class ExptoThePowerX : IOneArgumentsOperation
    {
        public double Calculate(double first)
        {
            return Math.Pow(2.71828182845, first);
        }
    }
}
