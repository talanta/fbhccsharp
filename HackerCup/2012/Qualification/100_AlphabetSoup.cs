using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerCup._2012.Qualification
{
    /// <summary>
    /// https://www.facebook.com/hackercup/problems.php?pid=341666075863455&round=146094915502528
    /// </summary>
    public class AlphabetSoup : IExecutable
    {
        public string[] Execute(params string[] input)
        {
            // H A C K E R C U P
            int[] count = new int[9];
            Dictionary<char, int> countDic = new Dictionary<char, int>()
            {
                {'c', 0},
                {'h', 0},
                {'a', 0},                
                {'k', 0},
                {'e', 0},
                {'r', 0},               
                {'u', 0},
                {'p', 0},
            };


            foreach (var c in input[0].ToLower())
            {
                if (!countDic.ContainsKey(c))
                    continue;
                countDic[c]++;
            }
            int result = Math.Min((int) (countDic['c'] / 2), countDic.Skip(1).Min(c=> c.Value));
            return new[] { result.ToString() };
        }
    }
}
