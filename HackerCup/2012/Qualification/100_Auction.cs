using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace HackerCup._2012.Qualification
{
    /*
    You have encountered a new fancy online auction that offers lots of products. You are only interested 
    in their price and weight. 
    We shall say that product A is strictly preferred over product B if A costs less than B and is not 
    heavier (they may be of 
    equal weight) or if A weighs less and is not more expensive (they can have equal price).

    We shall call a product A a bargain if there is no product B such that B is better than A. Similarly, 
    we shall call a product C a terrible deal if there exists no product D such that C is better than D. 
    Note that according to our definitions, the same product may be both a bargain and a terrible deal! 
    Only wacky auctioneers sell such products though.

    One day you wonder how many terrible deals and bargains are offered. The number of products, N, is too large 
    for your human-sized
    brain though. Fortunately, you discovered that the auction manager is terribly lazy and decided to sell the 
    products based on a very simple pseudo-random number generator.

    If product i has price Pi and weight Wi, then the following holds for product i+1:

    Pi = ((A*Pi-1 + B) mod M) + 1 (for all i = 2..N)
    Wi = ((C*Wi-1 + D) mod K) + 1 (for all i = 2..N)
    You carefully calculated the parameters for the generator (P1, W1, M, K, A, B, C and D). Now you want to 
    calculate the number of 
    terrible deals and bargains on the site.
    */
    /// <summary>
    /// https://www.facebook.com/hackercup/problems.php?pid=268598303201105&round=146094915502528
    /// </summary>
    public class Auction : IExecutable
    {
        internal class AucGenerator
        {
            public int P1 { get; private set; }
            public int W1 { get; private set; }
            public int M { get; private set; }
            public int K { get; private set; }
            public int A { get; private set; }
            public int B { get; private set; }
            public int C { get; private set; }
            public int D { get; private set; }

            public AucGenerator(int p1, int w1, int m, int k, int a, int b, int c, int d)
            {
                P1 = p1;
                W1 = w1;
                M = m;
                K = k;
                A = a;
                B = b;
                C = c;
                D = d;
            }
        }
        [DebuggerDisplay("Cost {Cost} Weight {Weight}")]
        internal class Product
        {
            public int Cost { get; private set; }
            public int Weight { get; private set; }

            public Product(int cost, int weight)
            {
                Cost = cost;
                Weight = weight;
            }
            //We shall call a product A a bargain if there is no product B such that B is better than A. Similarly, 
            internal bool Bargain(IList<Product> list)
            {
                foreach (var B in list)
                {
                    if (B.IsPreferableTo(this))
                        return false;
                }
                return true;
            }
            //we shall call a product C a terrible deal if there exists no product D such that C is better than D. 
            internal bool Terrible(IList<Product> list)
            {
                foreach (var D in list)
                {
                    if (this.IsPreferableTo(D))
                        return false;
                }
                return true;
            }
            //We shall say that product A is strictly preferred over product B if A costs less than B and is not 
            //heavier (they may be of 
            //equal weight) or if A weighs less and is not more expensive (they can have equal price).
            bool IsPreferableTo(Product B)
            {
                return (this.Cost < B.Cost && this.Weight <= B.Weight) || (this.Weight < B.Weight && this.Cost <= B.Cost);
            }
        }


        public string[] Execute(params string[] input)
        {
            int[] vals = input[0].Split(' ').Select(s => int.Parse(s)).ToArray();
            int n = vals[0];

            var gen = new AucGenerator(vals[1], vals[2], vals[3], vals[4], vals[5], vals[6], vals[7], vals[8]);
            //(P1, W1, M, K, A, B, C and D)
            var productList = new List<Product>();
            productList.Add(new Product(gen.P1, gen.W1));
            int bargainIndex = 0;
            int terribleIndex = 0;
            for (int i = 1; i < n; i++)
            {
                int pi = ((gen.A * productList[i - 1].Cost + gen.B) % gen.M) + 1;
                int wi = ((gen.C * productList[i - 1].Weight + gen.D) % gen.K) + 1;
                //Pi = ((A*Pi-1 + B) mod M) + 1 (for all i = 2..N)
                //Wi = ((C*Wi-1 + D) mod K) + 1 (for all i = 2..N)

                var product = new Product(pi, wi);
                productList.Add(product);
            }

            for (int i = 0; i < n; i++)
            {
                if (productList[i].Bargain(productList))
                {
                    bargainIndex++;
                    continue;
                }
                if (productList[i].Terrible(productList))
                {
                    terribleIndex++;
                    continue;
                }

            }

            return new[] { string.Format("{0} {1}", terribleIndex, bargainIndex) };
        }



    }
}
