using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerCup._2011.Qualification
{
    /*
    A double-square number is an integer X which can be expressed as the sum of two perfect squares. 
    For example, 10 is a double-square because 10 = 3^2 + 1^2. Your task in this problem is, given X, 
    determine the number of ways in which it can be written as the sum of two squares. 
    
    For example, 10 can only be written as 3^2 + 1^2 (we don't count 1^2 + 3^2 as being different). 
    On the other hand, 25 can be written as 5^2 + 0^2 or as 4^2 + 3^2.

    Input
    You should first read an integer N, the number of test cases. The next N lines will contain N 
    values of X.
    Constraints
    0 ≤ X ≤ 2147483647
    1 ≤ N ≤ 100
    Output
    For each value of X, you should output the number of ways to write X as the sum of two squares.
    */
    /// <summary>
    /// https://www.facebook.com/hackercup/problems.php?pid=112921602098268&round=4
    /// </summary>
    public class DoubleSquares : IExecutable
    {
        public string[] Execute(params string[] inputStr)
        {
            int input = int.Parse(inputStr[0]);
            int sqrt = (int)Math.Sqrt(input) + 1;
            int result = 0;

            for (int i = 0; i < sqrt; i++)
            {
                // on calcule le carre de chaque index
                double pow = Math.Pow(i, 2);
                double y = Math.Sqrt(input - pow);
                // si mon résultat est entier
                if (Math.Floor(y) != y)
                    continue;
                if (pow == y)
                    result += 2;
                else
                    result++;
            }
            return new[] { Convert.ToString(result / 2) };
        }
    }
}
