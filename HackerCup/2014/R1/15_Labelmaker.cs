using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerCup._2014.R1
{
    /*
    David is labelling boxes in a giant warehouse. He has a *lot* of boxes to label, but unfortunately his 
    labeling machine is broken, so only some of the letters work. In order to be efficient, David labels
    the boxes by first using every possible 1-letter label in alphabetical order, then using every possible 
    2-letter label in alphabetical order, then every 3-letter label, etc.

    For example, suppose only the letters 'D', 'T', and 'Z' work. David would label the first 15 boxes as 
    follows: D, T, Z, DD, DT, DZ, TD, TT, TZ, ZD, ZT, ZZ, DDD, DDT, DDZ. The first box is considered box #1, 
    not box #0.

    Given a set of working letters L on David's labelling machine and a number N of boxes to label, return
    the label on the last box.

    Input
    The first line of the input consists of a single integer T, the number of test cases. 
    Each test case consists of the string L and the integer N, separated by a space.
    */
    /// <summary>
    /// https://www.facebook.com/hackercup/problems.php?pid=637270059647812&round=1437956993099239
    /// </summary>
    public class Labelmaker : IExecutable
    {
        public string[] Execute(params string[] input)
        {
            var split = input[0].Split();
            string lettres = split[0];
            long index = long.Parse(split[1]);
            string result = string.Empty;

            do
            {
                int mod = (int)(index % lettres.Length);
                if (mod == 0)
                {
                    mod = lettres.Length;
                    index = (index / lettres.Length) - 1;
                }
                else
                    index = index / lettres.Length;

                result = lettres[mod - 1] + result;
            } while (index >=1);

            return new[] { result };
        }
    }
}
