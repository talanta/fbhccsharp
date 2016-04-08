using System;

namespace HackerCup._2016.R2
{
    public class Boomrang : IExecutable
    {

        private int Match(string l, string r, int start, int count)
        {
            int index = 0;
            int res = 0;
            while (index++ < count)
            {
                res += (l[index + start] == r[index + start]) ? 0 : 1;
            }
            return res;
        }
        private int Root(string left, string right, int ln)
        {
            if (ln % 2 == 0)
            {
                return Math.Max(Match(left, right, 0, ln / 2)
                    , Match(left, right, ln / 2 - 1, ln / 2));
            }
            return Match(left, right, 0, 1)
                + Root(left.Substring(1), right.Substring(1), ln - 1);
        }
        public string[] Execute(params string[] input)
        {
            var ln = int.Parse(input[0]);
            var right = input[2];
            var left = input[1];

            return new[] { Root(left, right, ln).ToString() };
        }
    }
}
