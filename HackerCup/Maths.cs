using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerCup
{
    internal static class Maths
    {
        public static int Combination(int k, int n)
        {
            var top = Factorial(n);
            var bottom = Factorial(k) * Factorial(n - k);

            return top / bottom;
        }

        public static int Factorial(int n)
        {
            if (n <= 2)
                return n;
            int result = n;

            for (int i = n - 1; i >= 1; result *= (i--)) ;

            return result;
        }
    }
}
