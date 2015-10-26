namespace HackerCup._2015.R1
{
    using System.Collections.Generic;
    /*
        https://www.facebook.com/hackercup/problems.php

        Your first-grade math teacher, Mr. Book, has just introduced you to an 
        amazing new concept — primes! According to your notes, a prime is a positive 
        integer greater than 1 that is divisible by only 1 and itself.

        Primes seem fun, but without giving you and your 6-year-old colleagues time to 
        consider their implications, he's promptly gone on to define another term: primacity. 
        He explains that the primacity of an integer is the number of distinct primes 
        which divide it. For example, the primacity of 12 is 2 (as it's divisible by 
        primes 2 and 3), the primacity of 550 is 3 (as it's divisible by primes 2, 5, and 11), 
        and the primacity of 7 is 1 (as the only prime it's divisible by is 7).

        Following his lesson, Mr. Book has given you homework with some rather mean questions of 
        the following form: Given 3 integers A, B, and K, how many integers in the inclusive 
        range [A, B] have a primacity of exactly K?

        Mr. Book probably expects his little homework assignment to take you and your classmates 
        the rest of the year to complete, giving him time to slack off and nap during the remaining 
        math classes. However, you want to learn more things from him instead! Can you use the 
        skills you've learned in your first-grade computer science classes to finish Mr. Book's 
        homework before tomorrow's math class?

        Input
        Input begins with an integer T, the number of homework questions. For each question, there 
        is one line containing 3 space-separated integers: A, B, and K.

        Output
        For the ith question, print a line containing "Case #i: " followed by the number of integers 
        in the inclusive range [A, B] with a primacity of K.


        Constraints
        1 ≤ T ≤ 100 
        2 ≤ A ≤ B ≤ 107 
        1 ≤ K ≤ 109 
	
        Explanation of Sample
        In the first test case, the numbers in the inclusive range [5, 15] with primacity 2 
        are 6, 10, 12, 14, and 15. All other numbers in this range have primacity 1.

        */
    using System.Linq;
    public class Homework : IExecutable
    {
        readonly int[] _basePrimes = { 2, 3, 5, 7, 11, 13 };

        private int getPrimacity(int number, IList<int> memPrimes)
	 	{
            if (number <= 1)
            {
                return 0;
            }
            if (memPrimes.Contains(number))
            {
                return 1;
            }
            int middle = (int)System.Math.Floor(number / 2d);
            bool hasdividers = false;
            int primacity = 0;
            while (middle > 1)
            {
                if (number % middle == 0)
                {
                    int p = getPrimacity(middle, memPrimes);
                    if (memPrimes.Contains(middle))
                    {
                        primacity++;
                    }
                    hasdividers = true;
                }
                middle--;

            }
            if (!hasdividers)
            {
                if (!memPrimes.Contains(number))
                {
                    memPrimes.Add(number);
                }
                return 1;
            }
            return primacity;
		}

        private int getCountOfNumberHavingPrimacity(int primacity, int min, int max)
        {
            var result = 0;
            var memPrimes = new List<int> { 2, 3, 5, 7, 11, 13 };
            for (int number = min; number <= max; number++)
            {
                if (getPrimacity(number, memPrimes) == primacity)
                    result++;
            }

            return result;
        }

        public string[] Execute(params string[] input)
        {
            var split = input[0].Split(' ');
            int A = int.Parse(split[0]), B = int.Parse(split[1]), K = int.Parse(split[2]);

            var result = getCountOfNumberHavingPrimacity(K, A, B);
            return new[] { result.ToString() };
        }
    }
}
