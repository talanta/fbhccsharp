using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerCup
{
    internal static class Maths
    {
		public static string Min(string a, string b)
		{
			if (a.CompareTo(b) < 0)
				return a;
			return b;
		}
		public static string Max(string a, string b)
		{
			if (a.CompareTo(b) >= 0)
				return a;
			return b;
		}


		public static double Combination(int k, int n)
        {
            var top = Factorial(n);
			var factK = Factorial (k);
			var factNK = Factorial (n - k);
			var bottom = factK * factNK;

		
			if (bottom == 0) {
				if (bottom == 0) {
				}
			}
            return top / bottom;
        }

		public static double Factorial(int n)
        {
            if (n <= 2)
                return n;
			long result = n;

			for (int i = n - 1; i > 1; i--) 
			{
				var las = result;
				result *= i;
				if (result == 0) {
				}
			}

            return result;
        }
    }
}
