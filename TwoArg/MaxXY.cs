using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalkulator
{
    public class MaxXY : ITwoArgumentsOperation
    {
        public double Calculate(double first, double second)
        {
            if (first > second) return first;
<<<<<<< HEAD
            else return second;
=======
            else return first;
>>>>>>> d7d00b8a094d42f55c7e6092c41466896aabcd94
        }
    }
}
