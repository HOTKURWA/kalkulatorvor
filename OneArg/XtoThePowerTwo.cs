using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalkulator
{
    public class ExptoThePowerX : IOneArgumentsOperation
    {
        public double Calculate(double first)
        {
            return Math.Pow(2.71828182845, first);
        }
    }
}
