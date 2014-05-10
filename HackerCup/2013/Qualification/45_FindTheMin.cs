using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerCup._2013.Qualification
{
    /*
    Find the Min

    After sending smileys, John decided to play with arrays. Did you know that hackers enjoy playing with arrays? 
    John has a zero-based index array, m, which contains n non-negative integers. However, only the first k values 
    of the array are known to him, and he wants to figure out the rest.

    John knows the following: for each index i, where k <= i < n, m[i] is the minimum non-negative integer which 
    is *not* contained in the previous *k* values of m.

    For example, if k = 3, n = 4 and the known values of m are [2, 3, 0], he can figure out that m[3] = 1.

    John is very busy making the world more open and connected, as such, he doesn't have time to figure out the rest of the array. 
    It is your task to help him.

    Given the first k values of m, calculate the nth value of this array. (i.e. m[n - 1]).

    Because the values of n and k can be very large, we use a pseudo-random number generator to calculate the first 
    k values of m. Given non-negative integers a, b, c and positive integer r, the known values of m can be calculated as follows:

    m[0] = a
    m[i] = (b * m[i - 1] + c) % r, 0 < i < k
      
    Input
    The first line contains an integer T (T <= 20), the number of test cases.
    This is followed by T test cases, consisting of 2 lines each.
    The first line of each test case contains 2 space separated integers, n, k (1 <= k <= 105, k < n <= 109).
    The second line of each test case contains 4 space separated integers a, b, c, r (0 <= a, b, c <= 109, 1 <= r <= 109).
      
    Output
    For each test case, output a single line containing the case number and the nth element of m.
    */
    /// <summary>
    /// https://www.facebook.com/hackercup/problems.php?pid=494433657264959&round=185564241586420
    /// </summary>
    public class FindTheMin : IExecutable
    {
        public class PairLong : IComparable
        {
            public long Item1 { get; set; }

            public long Occurence { get; set; }

            public PairLong(long item1, long occurence)
            {
                this.Item1 = item1;
                this.Occurence = occurence;
            }

            public int CompareTo(object obj)
            {
                var cc = obj as PairLong;
                if (null == cc)
                    return 0;
                if (Occurence == cc.Occurence)
                {
                    return (int)(Item1 - cc.Item1);
                }
                return (int)(Occurence - cc.Occurence);
            }
        }

        public string[] Execute(params string[] input)
        {
            var split1 = input[0].Split();
            var split2 = input[1].Split();
            int n = int.Parse(split1[0]), k = int.Parse(split1[1]);

            long b = int.Parse(split2[1]), c = int.Parse(split2[2]), r = int.Parse(split2[3]);

            long[] _array = new long[2 * k + 1];

            _array[0] = int.Parse(split2[0]);

            for (int i = 1; i < k; i++)
            {
                _array[i] = (b * _array[i - 1] + c) % r;
            }


            PairLong[] f = new PairLong[2 * k + 1];

            SortedSet<PairLong> tree = new SortedSet<PairLong>();
            for (int i = 0; i < 2 * k + 1; i++)
            {
                f[i] = new PairLong(i, 0);
            }

            for (int i = 0; i < k; i++)
            {
                long xx = _array[i];
                if (xx <= 2 * k)
                    f[xx].Occurence++;
            }

            for (int i = 0; i < 2 * k + 1; i++)
            {
                tree.Add(f[i]);
            }

            for (int i = k; i < 2 * k + 1; i++)
            {
                PairLong first = tree.First();
                tree.Remove(first);

                _array[i] = first.Item1;

                if (_array[i - k] <= 2 * k)
                {
                    PairLong rem = f[_array[i - k]];
                    tree.Remove(rem);
                    rem.Occurence--;
                    tree.Add(rem);
                }
                first.Occurence++;
                tree.Add(first);
            }

            int index = (n - k - 1) % (k + 1);

            return new[] { Convert.ToString(_array[k + index]) };
        }
    }
}
