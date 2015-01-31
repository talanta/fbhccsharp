using HackerCup._2013.Qualification;
using HackerCup._2013.R1;
using HackerCup._2013.R2;
using HackerCup._2013.R3;
using NUnit.Framework;

namespace HackerCup.Test
{
    public class _2013
    {
        
        [TestCase("ABbCcc", "152")]
        [TestCase("Good luck in the Facebook Hacker Cup this year!", "754")]
        [TestCase("Ignore punctuation, please :)", "491")]
        [TestCase("Sometimes test cases are hard to make up.", "729")]
        [TestCase("So I just go consult Professor Dalves", "646")]
        public void _BeautifulStrings(string input, string expectedResult)
        {
            var tested = new BeautifulStrings();

            Assert.AreEqual(expectedResult, tested.Execute(input)[0]);
        }

        [Test]
        public void _BeautifulStrings_large()
        {
            Assert.True(Helper.RunLarge<BeautifulStrings>(TestResources.beautiful_strings, 1));
        }

        
        [TestCase(":((", "NO")]
        [TestCase("i am sick today (:()", "YES")]
        [TestCase("(:)", "YES")]
        [TestCase("hacker cup: started :):)", "YES")]
        [TestCase(")(", "NO")]
        public void _BalancedSmileys(string input, string expectedResult)
        {
            var tested = new BalancedSmileys();
            Assert.AreEqual(expectedResult, tested.Execute(input)[0]);
        }

        
        [TestCase("97 39", "34 37 656 97", "8")]
        [TestCase("186 75", "68 16 539 186", "38")]
        [TestCase("137 49", "48 17 461 137", "41")]
        [TestCase("98 59", "6 30 524 98", "40")]
        [TestCase("46 18", "7 11 9 46", "12")]
        public void _FindTheMin(string p0, string p1, string expectedResult)
        {
            var tested = new FindTheMin();

            Assert.AreEqual(expectedResult, tested.Execute(p0,p1)[0]);
        }

        [Test]
        public void _FindTheMin_large()
        {
            Assert.True(Helper.RunLarge<FindTheMin>(TestResources.find_the_min, 2));
        }

        
        [TestCase("4 3", "3 6 2 8", "30")]
        [TestCase("5 2", "10 20 30 40 50", "400")]
        [TestCase("6 4", "0 1 2 3 5 8", "103")]
        [TestCase("2 2", "1069 1122", "1122")]
        [TestCase("10 5", "10386 10257 10432 10087 10381 10035 10167 10206 10347 10088", "2621483")]
        public void _CardGame(string p0, string p1, string expectedResult)
        {
            var tested = new CardGame();

            Assert.AreEqual(expectedResult, tested.Execute(p0, p1)[0]);
        }

		[Test]
        public void _CardGame_large()
        {
            Assert.True(Helper.RunLarge<CardGame>(TestResources.card_game, 2));
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
            Assert.AreEqual(expectedResult, tested.Execute(input)[0]);
        }

        public void _DeadPixels(string input, string expectedResult)
        {
            var tested = new DeadPixels();

            Assert.AreEqual(expectedResult, tested.Execute(input)[0]);
        }

        public void _CakeCutting(string input, string expectedResult)
        {
            var tested = new CakeCutting();

            Assert.AreEqual(expectedResult, tested.Execute(input)[0]);
        }

        public void _RoboElection(string input, string expectedResult)
        {
            var tested = new RoboElection();

            Assert.AreEqual(expectedResult, tested.Execute(input)[0]);
        }

        public void _Permutations(string input, string expectedResult)
        {
            var tested = new Permutations();

            Assert.AreEqual(expectedResult, tested.Execute(input)[0]);
        }

        public void _DigitsWar(string input, string expectedResult)
        {
            var tested = new DigitsWar();

            Assert.AreEqual(expectedResult, tested.Execute(input)[0]);
        }

        public void _NameTheBaby(string input, string expectedResult)
        {
            var tested = new NameTheBaby();

            Assert.AreEqual(expectedResult, tested.Execute(input)[0]);
        }


        public void _GreedyEntertainers(string input, string expectedResult)
        {
            var tested = new GreedyEntertainers();

            Assert.AreEqual(expectedResult, tested.Execute(input)[0]);
        }
    }
}
