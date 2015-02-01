using System.Collections.Generic;

namespace HackerCup._2015.Q
{
	/*
    https://www.facebook.com/hackercup/problems.php?pid=582062045257424&round=742632349177460
    
	Every business can make use of a good accountant and, if they're not big on following the law, 
	sometimes a bad one. Bad accountants try to make more money for their employers by fudging numbers 
	without getting caught.

	Sometimes a bad accountant wants to make a number larger, and sometimes smaller. It is widely 
	known that tax auditors will fail to notice two digits being swapped in any given number, but 
	any discrepancy more egregious will certainly be caught. It's also painfully obvious when a number 
	has fewer digits than it ought to, so a bad accountant will never swap the first digit of a number with a 0.

	Given a number, how small or large can it be made without being found out?

	Input
	Input begins with an integer T, the number of numbers that need tweaking. Each of the next T 
	lines contains a integer N.

	Output
	For the ith number, print a line containing "Case #i: " followed by the smallest and largest numbers 
	that can be made from the original number N, using at most a single swap and following the rules above.

	Constraints
	1 ≤ T ≤ 100 
	0 ≤ N ≤ 999999999 
	N will never begin with a leading 0 unless N = 0
	 */
    public class CookingBooks : IExecutable
    {
        public string[] Execute(params string[] input)
        {
			var originalNumber = input [0].ToCharArray();
			string minTweak = new string(originalNumber), maxTweak = new string(originalNumber);

			for(int i = 0; i < originalNumber.Length; i++) {
				for(int j = 0; j < i; j++) {

					var temp = originalNumber [i];
					originalNumber [i] = originalNumber [j];
					originalNumber [j] = temp;

					if (originalNumber [0] != '0') {
						minTweak = Maths.Min (minTweak, new string(originalNumber));
						maxTweak = Maths.Max (maxTweak, new string(originalNumber));
					}
					originalNumber = input [0].ToCharArray();
				}
			}
			return new []{ minTweak, maxTweak};
        }
    }
}
