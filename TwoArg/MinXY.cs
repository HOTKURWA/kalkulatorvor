using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalkulator
{
    public class MinXY : ITwoArgumentsOperation
    {
        public double Calculate(double first, double second)
        {
<<<<<<< HEAD
            if (first > second) return second ;
            else return first;
=======
            if (first > second) return first;
            else return second;
>>>>>>> d7d00b8a094d42f55c7e6092c41466896aabcd94
        }
    }
}
