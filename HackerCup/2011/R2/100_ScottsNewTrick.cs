using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerCup._2011.R2
{
    /*
    Little Scott recently learned how to perform arithmetic operations modulo some
    prime number P. As a training set he picked two sequences a of length N and b of
    length M, generated in the following way:

    a1=A1
    a2=A2
    ai=(ai-2 * A3 + ai-1*A4 + A5) mod P, for i=3...N
    b1=B1
    b2=B2
    bj=(bj-2 * B3 + bj-1 * B4 + B5) mod P, for j=3...M
    Now he wants to find the number of pairs (i, j), where 1 ≤ i ≤ N and 1 ≤ j ≤ M,
    such that (ai * bj) mod P < L, for given number L. He asked you to do the same to
    help him check his answers.

    Input

    The first line of input file consists of a single number T, the number of test
    cases. Each test consists of three lines. The first line of a test case contains
    two integers: prime number P and positive integer L. The second line consists of
    six non-negative integers N, A1, A2, A3, A4, A5. Likewise, the third line contains
    six non-negative integers M, B1, B2, B3, B4, B5.

    Output

    Output T lines, with the answer to each test case on a single line.

    Constraints

    T = 20
    2 ≤ P < 250,000
    P is prime
    1 ≤ L ≤ P
    2 ≤ N, M ≤ 10,000,000
    0 ≤ A1, A2, A3, A4, A5, B1, B2, B3, B4, B5 < P
    */
    public class ScottsNewTrick : IExecutable
    {
        public string[] Execute(params string[] input)
        {
            throw new NotImplementedException();
        }
    }
}
