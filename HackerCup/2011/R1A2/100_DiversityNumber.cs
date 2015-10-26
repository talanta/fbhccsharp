using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerCup._2011.R1A2
{
    /*
    Let's call a sequence of integers a1, a2, ..., aN almost monotonic if
    first K elements are non-decreasing sequence and last N-K+1 elements are non-increasing
    sequence: a1≤a2≤...≤aK and aK≥aK+1≥...≥aN.

    The diversity number of a sequence a1, a2, ..., aN is the number of possible
    sequences b1, b2,..., bN for which 0≤bi<ai and all of the numbers b1, b2,..., bN are
    different. The diversity number of an empty sequence is 1.

    You need to find the sum of the diversity numbers of all almost monotonic subsequences
    of a sequence. Since this number can be very large, find it modulo 1,000,000,007.
    A subsequence is a sequence that can be obtained from another sequence by deleting
    some elements without changing the order of the remaining elements. Two sequences
    are considered different if their lengths differ or there is at least one position
    at which they differ.

    Input

    The first line of the input file consists of a single number T, the number of
    test cases. Each test case consists of a number M, the number of elements in a
    sequence, followed by M numbers n, elements of some sequence (note that this
    sequence is not necessarily almost monotonic). All tokens are whitespace-separated

    Constraints

    T = 20
    1 ≤ M, n ≤ 100

    Output
    Output T lines, with the answer to each test case on a single line.
    */
    public class DiversityNumber : IExecutable
    {
        public string[] Execute(params string[] input)
        {
            throw new NotImplementedException();
        }
    }
}
