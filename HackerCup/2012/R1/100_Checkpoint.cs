using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerCup._2012.R1
{
    /// <summary>
    /// https://www.facebook.com/hackercup/problems.php?pid=191596157517194&round=225705397509134
    /// </summary>
    public class Checkpoint : IExecutable
    {
        public string[] Execute(params string[] input)
        {
            //freopen("input.txt", "r", stdin);
            //freopen("output.txt", "w", stdout);

            //int i, j;

            //W[1] = 1;
            //for (i = 2; i <= 10000000; i++) W[i] = 0x7fffffff;
            //for (i = 2; i <= 10000000; i++)
            //{
            //    U = 1;
            //    for (j = 0; j < i; j++)
            //    {
            //        U = U * (i - j) / (j + 1);
            //        if (U > 10000000) break;
            //        W[U] = min(W[U], i);
            //    }
            //}

            //scanf("%d", &T); while (T--)
            //{
            //    scanf("%d", &N);
            //    int ans = 0x7fffffff;
            //    for (i = 1; i * i <= N; i++)
            //        if (N % i == 0)
            //        {
            //            ans = min(ans, W[i] + W[N / i]);
            //        }
            //    printf("Case #%d: %d\n", ++C, ans);
            //}
            throw new NotImplementedException();
        }
    }
}
