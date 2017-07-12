using System;

namespace Kalkulator.OneArg
{
    public class ExptoThePowerX : IOneArgumentsOperation
    {
        public double Calculate(double first)
        {
            return Math.Exp(first);
        }
    }
}
