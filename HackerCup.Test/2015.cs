using NUnit.Framework;
using HackerCup._2015.Q;

namespace HackerCup.Test
{
    public class _2015
    {
		[TestCase("31524", "13524", "51324")]
		[TestCase("897", "798", "987")]
		[TestCase("123", "123", "321")]
		[TestCase("10","10", "10")]
		[TestCase("5", "5", "5")]
		public void CookingBooks(string input, string expectedSmallestTweak, string expectedLargestTweak)
		{
			var tested = new CookingBooks();
			var result = tested.Execute (input);

			Assert.AreEqual(expectedSmallestTweak, result[0]);
			Assert.AreEqual(expectedLargestTweak, result[1]);
		}
    }
}
