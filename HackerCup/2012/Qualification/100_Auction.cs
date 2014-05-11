using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerCup._2012.Qualification
{
    /*
    You have encountered a new fancy online auction that offers lots of products. You are only interested in their price and weight. 
    We shall say that product A is strictly preferred over product B if A costs less than B and is not heavier (they may be of 
    equal weight) or if A weighs less and is not more expensive (they can have equal price).

    We shall call a product A a bargain if there is no product B such that B is better than A. Similarly, we shall call a product 
    C a terrible deal if there exists no product D such that C is better than D. Note that according to our definitions, the same 
    product may be both a bargain and a terrible deal! Only wacky auctioneers sell such products though.

    One day you wonder how many terrible deals and bargains are offered. The number of products, N, is too large for your human-sized
    brain though. Fortunately, you discovered that the auction manager is terribly lazy and decided to sell the products based on a 
    very simple pseudo-random number generator.

    If product i has price Pi and weight Wi, then the following holds for product i+1:

    Pi = ((A*Pi-1 + B) mod M) + 1 (for all i = 2..N)
    Wi = ((C*Wi-1 + D) mod K) + 1 (for all i = 2..N)
    You carefully calculated the parameters for the generator (P1, W1, M, K, A, B, C and D). Now you want to calculate the number of 
    terrible deals and bargains on the site.
    */
    /// <summary>
    /// https://www.facebook.com/hackercup/problems.php?pid=268598303201105&round=146094915502528
    /// </summary>
    public class Auction : IExecutable
    {
        public string[] Execute(params string[] input)
        {
            int[] vals = input[0].Select(c => int.Parse(c.ToString())).ToArray();

            

            throw new NotImplementedException();
        }
    }
}
