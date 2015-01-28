using HackerCup._2012.Qualification;
using HackerCup._2012.R1;
using HackerCup._2012.R2;
using HackerCup._2012.R3;
using Xunit;

namespace HackerCup.Test
{
    public class _2012
    {
        [Theory]
        [InlineData("WELCOME TO FACEBOOK HACKERCUP", "1")]
        [InlineData("CUP WITH LABEL HACKERCUP BELONGS TO HACKER", "2")]
        [InlineData("QUICK CUTE BROWN FOX JUMPS OVER THE LAZY DOG", "1")]
        [InlineData("MOVE FAST BE BOLD", "0")]
        [InlineData("HACK THE HACKERCUP", "1")]
        public void _AlphabetSoup(string input, string expectedResult)
        {
            var tested = new AlphabetSoup();

            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Fact]
        public void _AlphabetSoup_large()
        {
            Assert.True(Helper.RunLarge<AlphabetSoup>(TestResources.alphabet_soup, 1));
        }

        [Theory]
        [InlineData("5 1 4 5 7 1 0 1 2", "3 3")]
        [InlineData("3 1 3 3 3 1 0 1 1", "3 3")]
        [InlineData("8 1 3 3 3 1 0 1 2", "2 3")]
        [InlineData("13 5 7 5 9 1 3 2 5", "2 2")]
        [InlineData("11 2 3 5 7 11 13 17 19", "3 1")]
        public void _Auction(string input, string expectedResult)
        {
            var tested = new Auction();
            // http://attachment.fbsbx.com/hackercup_source.php?sid=225247877559478
            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Theory]
        [InlineData("20 6 hacker cup", "3")]
        [InlineData("10 20 MUST BE ABLE TO HACK", "2")]
        [InlineData("55 25 Can you hack", "8")]
        [InlineData("100 20 Hack your way to the cup", "7")]
        [InlineData("100 20 hacker cup 2013", "10")]
        public void _Billboards(string input, string expectedResult)
        {
            var tested = new Billboards();
            // http://attachment.fbsbx.com/hackercup_source.php?sid=283332768388603
            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Fact]
        public void _Billboards_large()
        {
            Assert.True(Helper.RunLarge<Billboards>(TestResources.billboards, 1));
        }

        [Theory]
        [InlineData("XX", "XX")]
        public void _Checkpoint(string input, string expectedResult)
        {
            var tested = new Checkpoint();
            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Theory]
        [InlineData("XX", "XX")]
        public void _RecoverTheSequence(string input, string expectedResult)
        {
            var tested = new RecoverTheSequence();
            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Theory]
        [InlineData("XX", "XX")]
        public void _SquishedStatus(string input, string expectedResult)
        {
            var tested = new SquishedStatus();
            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Theory]
        [InlineData("XX", "XX")]
        public void _Monopoly(string input, string expectedResult)
        {
            var tested = new Monopoly();
            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Theory]
        [InlineData("XX", "XX")]
        public void _RoadRemoval(string input, string expectedResult)
        {
            var tested = new RoadRemoval();
            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Theory]
        [InlineData("XX", "XX")]
        public void _SequenceSlicing(string input, string expectedResult)
        {
            var tested = new SequenceSlicing();
            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Theory]
        [InlineData("XX", "XX")]
        public void _DivisorFunctionOptimization(string input, string expectedResult)
        {
            var tested = new DivisorFunctionOptimization();
            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Theory]
        [InlineData("XX", "XX")]
        public void _Trapezoids(string input, string expectedResult)
        {
            var tested = new Trapezoids();
            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Theory]
        [InlineData("XX", "XX")]
        public void _Unfriending(string input, string expectedResult)
        {
            var tested = new Unfriending();
            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }
    }
}
