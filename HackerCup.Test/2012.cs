using HackerCup._2012.Qualification;
using HackerCup._2012.R1;
using HackerCup._2012.R2;
using HackerCup._2012.R3;
using NUnit.Framework;

namespace HackerCup.Test
{
    public class _2012
    {
        
        [TestCase("WELCOME TO FACEBOOK HACKERCUP", "1")]
        [TestCase("CUP WITH LABEL HACKERCUP BELONGS TO HACKER", "2")]
        [TestCase("QUICK CUTE BROWN FOX JUMPS OVER THE LAZY DOG", "1")]
        [TestCase("MOVE FAST BE BOLD", "0")]
        [TestCase("HACK THE HACKERCUP", "1")]
        public void _2012_q_AlphabetSoup(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<AlphabetSoup>(input));
        }

        [Test]
        public void _AlphabetSoup_large()
        {
            Assert.True(Helper.RunLarge<AlphabetSoup>(TestResources.alphabet_soup, 1));
        }

        [Ignore("TODO")]
        [TestCase("5 1 4 5 7 1 0 1 2", "3 3")]
        [TestCase("3 1 3 3 3 1 0 1 1", "3 3")]
        [TestCase("8 1 3 3 3 1 0 1 2", "2 3")]
        [TestCase("13 5 7 5 9 1 3 2 5", "2 2")]
        [TestCase("11 2 3 5 7 11 13 17 19", "3 1")]
        public void _Auction(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<Auction>(input));
        }


        [TestCase("20 6 hacker cup", "3")]
        [TestCase("10 20 MUST BE ABLE TO HACK", "2")]
        [TestCase("55 25 Can you hack", "8")]
        [TestCase("100 20 Hack your way to the cup", "7")]
        [TestCase("100 20 hacker cup 2013", "10")]
        public void _Billboards(string input, string expectedResult)
        {
            var tested = new Billboards();
            // http://attachment.fbsbx.com/hackercup_source.php?sid=283332768388603
            Assert.AreEqual(expectedResult, tested.Execute(input)[0]);
        }

        [Test]
        public void _Billboards_large()
        {
            Assert.True(Helper.RunLarge<Billboards>(TestResources.billboards, 1));
        }


        [Ignore("todo")]
        public void _2012_r1_Checkpoint(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<Checkpoint>(input));
        }


        [Ignore("todo")]
        public void _2012_r1_RecoverTheSequence(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<RecoverTheSequence>(input));
        }


        [Ignore("todo")]
        public void _2012_r1_SquishedStatus(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<SquishedStatus>(input));
        }


        [Ignore("todo")]
        public void _2012_r2_Monopoly(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<Monopoly>(input));
        }


        [Ignore("todo")]
        public void _2012_r2_RoadRemoval(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<RoadRemoval>(input));
        }


        [Ignore("todo")]
        public void _2012_r2_SequenceSlicing(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<SequenceSlicing>(input));
        }


        [Ignore("todo")]
        public void _2012_r3_DivisorFunctionOptimization(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<DivisorFunctionOptimization>(input));
        }


        [Ignore("todo")]
        public void _2012_r3_Trapezoids(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<Trapezoids>(input));
        }


        [Ignore("todo")]
        public void _2012_r3_Unfriending(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<Unfriending>(input));
        }
    }
}
