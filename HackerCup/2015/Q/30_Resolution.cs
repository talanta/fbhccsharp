﻿namespace HackerCup._2015.Q
{
    /*
Alex's New Year's resolution for 2015 is to eat healthier foods. He's done some research and has found 
out that calories come from three main sources, called macronutrients: protein, carbohydrates, and fat. 
Alex wants to get the right balance of protein, carbohydrates, and fat to have a balanced diet. 
For each available food, Alex can only choose to eat it or not eat it. He can't eat a certain food 
more than once, and he can't eat a fractional amount of a food.

Input
Input begins with an integer T, the number of test cases. For each test case, the first line consists 
of three space-separated integers: GP, GC, and GF, which represent the amount of protein, carbohydrates, 
and fat that Alex wants to eat. The next line has the number of foods for that test case, an integer N. 
The next N lines each consist of three space-separated integers: P, C, and F, which represent the amount 
of protein, carbohydrates, and fat in that food, respectively.

Output
For each test case i, print a line containing "Case #i: " followed by either "yes" if it is possible 
for Alex to eat the exact amount of each macronutrient, or "no" if it is not possible.

Constraints
1 ≤ T ≤ 20 
1 ≤ N ≤ 20 
10 ≤ GP, GC, GF ≤ 1000 
10 ≤ P, C, F ≤ 1000 

    */
    public class Resolution : IExecutable
    {
//		Food... calories ..protein, carboh Fat..
//		eat.. not eat.. 1 ..0
//		P C F
//		N
//		TTTT
//		FFFFF
//		FFFF
//		=>
        public string[] Execute(params string[] input)
        {
			return new []{"yes"};
        }
    }
}
