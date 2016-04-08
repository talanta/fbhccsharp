using NUnit.Framework;
using HackerCup._2015.Q;
using HackerCup._2015.R1;

namespace HackerCup.Test
{
    public class _2015
    {
		[TestCase("31524", "13524#51324")]
		[TestCase("897", "798#987")]
		[TestCase("123", "123#321")]
		[TestCase("10","10#10")]
		[TestCase("5", "5#5")]
		public void _2015_q_CookingBooks(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<CookingBooks>(input));
        }

        //[TestCase("P C F", new[]{""})]
        public void Resolution(string input, string expectedSmallestTweak, string expectedLargestTweak)
		{
			var tested = new Resolution();
			var result = tested.Execute (input);

			Assert.AreEqual(expectedLargestTweak, result[1]);
		}


		[TestCase("5 15 2", "5")]
		[TestCase("2 10 1", "7")]
		[TestCase("24 42 3", "2")]
		[TestCase("1000000 1000000 1", "0")]
		[TestCase("1000000 1000000 2", "1")]
		public void _2015_r1_Homework(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<Homework>(input));
        }

    }
}
