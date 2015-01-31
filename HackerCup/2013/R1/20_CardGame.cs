﻿using System.Collections.Generic;
using System.Linq;

namespace HackerCup._2013.R1
{
    /*
    Card Game

    John is playing a game with his friends. The game's rules are as follows: There is deck of N cards from 
    which each person is dealt a hand of K cards. Each card has an integer value representing its strength. 
    A hand's strength is determined by the value of the highest card in the hand. The person with the strongest 
    hand wins the round. Bets are placed before each player reveals the strength of their hand.

    John needs your help to decide when to bet. He decides he wants to bet when the strength of his hand is 
    higher than the average hand strength. Hence John wants to calculate the average strength of ALL possible 
    sets of hands. John is very good at division, but he needs your help in calculating the sum of the strengths 
    of all possible hands.

    Problem
    You are given an array a with N ≤ 10 000 different integer numbers and a number, K, where 1 ≤ K ≤ N. 
    For all possible subsets of a of size K find the sum of their maximal elements modulo 1 000 000 007.

    Input
    The first line contains the number of test cases T, where 1 ≤ T ≤ 25

    Each case begins with a line containing integers N and K. The next line contains N space-separated 
    numbers 0 ≤ a [i] ≤ 2 000 000 000, which describe the array a.

    Output
    For test case i, numbered from 1 to T, output "Case #i: ", followed by a single integer, the sum of 
    maximal elements for all subsets of size K modulo 1 000 000 007.

    Example
    For a = [3, 6, 2, 8] and N = 4 and K = 3, the maximal numbers among all triples are 6, 8, 8, 8 and the sum is 30.
    */
    /// <summary>
    /// https://www.facebook.com/hackercup/problems.php?pid=321892127915788&round=189890111155691
    /// </summary>
    public class CardGame : IExecutable
    {
        int _n = 0, _k = 0;
        int[] _a;

        protected void InitializeSet(string[] split1, string[] split2)
        {
            _n = int.Parse(split1[0]);
            _k = int.Parse(split1[1]);
            var sortedValues = new SortedSet<int>();

            for (int i = 0; i < _n; sortedValues.Add(int.Parse(split2[i++]))) ;

            _a = sortedValues.ToArray();
        }

		protected double GetMaxCombinationWhereMaxIs(int value, int index)
        {
            if (index < _k-1)
                return 0;
            if (index == _k-1)
                return 1;
            return Maths.Combination(_k-1, index);
        }


        public string[] Execute(params string[] input)
        {
			double result = 0;
            InitializeSet(input[0].Split(' '), input[1].Split(' '));

            for (int i = _n - 1; i >= 0;
                 result += _a[i] * GetMaxCombinationWhereMaxIs(_a[i], i--)) ; 

            return new [] { result.ToString() };
        }
    }
}
