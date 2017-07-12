using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalkulator
{
    public class TenToThePowerX : IOneArgumentsOperation
    {
        public double Calculate(double first)
        {
            return Math.Pow(10,first);
        }
    }
}
