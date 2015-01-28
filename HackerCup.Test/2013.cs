using HackerCup._2013.Qualification;
using HackerCup._2013.R1;
using HackerCup._2013.R2;
using HackerCup._2013.R3;
using Xunit;

namespace HackerCup.Test
{
    public class _2013
    {
        [Theory]
        [InlineData("ABbCcc", "152")]
        [InlineData("Good luck in the Facebook Hacker Cup this year!", "754")]
        [InlineData("Ignore punctuation, please :)", "491")]
        [InlineData("Sometimes test cases are hard to make up.", "729")]
        [InlineData("So I just go consult Professor Dalves", "646")]
        public void _BeautifulStrings(string input, string expectedResult)
        {
            var tested = new BeautifulStrings();

            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Fact]
        public void _BeautifulStrings_large()
        {
            Assert.True(Helper.RunLarge<BeautifulStrings>(TestResources.beautiful_strings, 1));
        }

        [Theory]
        [InlineData(":((", "NO")]
        [InlineData("i am sick today (:()", "YES")]
        [InlineData("(:)", "YES")]
        [InlineData("hacker cup: started :):)", "YES")]
        [InlineData(")(", "NO")]
        public void _BalancedSmileys(string input, string expectedResult)
        {
            var tested = new BalancedSmileys();
            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Theory]
        [InlineData("97 39", "34 37 656 97", "8")]
        [InlineData("186 75", "68 16 539 186", "38")]
        [InlineData("137 49", "48 17 461 137", "41")]
        [InlineData("98 59", "6 30 524 98", "40")]
        [InlineData("46 18", "7 11 9 46", "12")]
        public void _FindTheMin(string p0, string p1, string expectedResult)
        {
            var tested = new FindTheMin();

            Assert.Equal(expectedResult, tested.Execute(p0,p1)[0]);
        }

        [Fact]
        public void _FindTheMin_large()
        {
            Assert.True(Helper.RunLarge<FindTheMin>(TestResources.find_the_min, 2));
        }

        [Theory]
        [InlineData("4 3", "3 6 2 8", "30")]
        [InlineData("5 2", "10 20 30 40 50", "400")]
        [InlineData("6 4", "0 1 2 3 5 8", "103")]
        [InlineData("2 2", "1069 1122", "1122")]
        [InlineData("10 5", "10386 10257 10432 10087 10381 10035 10167 10206 10347 10088", "2621483")]
        public void _CardGame(string p0, string p1, string expectedResult)
        {
            var tested = new CardGame();

            Assert.Equal(expectedResult, tested.Execute(p0, p1)[0]);
        }

        public void _CardGame_large()
        {
          //  Assert.True(Helper.RunLarge<CardGame>(TestResources.car, 1));
            //Helper.RunLarge<CardGame>("Assets/card_game.txt", 2);
        }


        public void _Security(string input, string expectedResult)
        {
            /*
            5
            2
            abcd
            c?ab
            3
            ab?c?c
            ac?c??
            3
            ab?c?c
            aabbdd
            2
            aa
            bb
            2
            abcd
            cdab
            ===
            Case #1: abcd
Case #2: abacac
Case #3: IMPOSSIBLE
Case #4: IMPOSSIBLE
Case #5: abcd
                */
            var tested = new Security();
            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        public void _DeadPixels(string input, string expectedResult)
        {
            var tested = new DeadPixels();

            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        public void _CakeCutting(string input, string expectedResult)
        {
            var tested = new CakeCutting();

            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        public void _RoboElection(string input, string expectedResult)
        {
            var tested = new RoboElection();

            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        public void _Permutations(string input, string expectedResult)
        {
            var tested = new Permutations();

            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        public void _DigitsWar(string input, string expectedResult)
        {
            var tested = new DigitsWar();

            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        public void _NameTheBaby(string input, string expectedResult)
        {
            var tested = new NameTheBaby();

            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }


        public void _GreedyEntertainers(string input, string expectedResult)
        {
            var tested = new GreedyEntertainers();

            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }
    }
}
