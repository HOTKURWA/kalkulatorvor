using System;

namespace Kalkulator.OneArg
{
    public class TenToThePowerX : IOneArgumentsOperation
    {
        public double Calculate(double first)
        {
            return Math.Pow(10,first);
        }
    }
}
