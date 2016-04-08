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
        public void _2013_q_BeautifulStrings(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<BeautifulStrings>(input));
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
        public void _2013_q_BalancedSmileys(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<BalancedSmileys>(input));
        }


        [TestCase("97 39#34 37 656 97", "8")]
        [TestCase("186 75#68 16 539 186", "38")]
        [TestCase("137 49#48 17 461 137", "41")]
        [TestCase("98 59#6 30 524 98", "40")]
        [TestCase("46 18#7 11 9 46", "12")]
        public void _2013_q_FindTheMin(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<FindTheMin>(input));
        }

        [Test]
        public void _FindTheMin_large()
        {
            Assert.True(Helper.RunLarge<FindTheMin>(TestResources.find_the_min, 2));
        }


        [TestCase("4 3#3 6 2 8", "30")]
        [TestCase("5 2#10 20 30 40 50", "400")]
        [TestCase("6 4#0 1 2 3 5 8", "103")]
        [TestCase("2 2#1069 1122", "1122")]
        [TestCase("10 5#10386 10257 10432 10087 10381 10035 10167 10206 10347 10088", "2621483")]
        public void _2013_r1_CardGame(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<CardGame>(input));
        }

        [Test]
        public void _CardGame_large()
        {
            Assert.True(Helper.RunLarge<CardGame>(TestResources.card_game, 2));
        }

        [Ignore("TODO")]
        [TestCase("2#abcd#c?ab", "abcd")]
        [TestCase("3#ab?c?c#ac?c??", "abacac")]
        [TestCase("3#ab?c?c#aabbdd", "IMPOSSIBLE")]
        [TestCase("2#aa#bb", "IMPOSSIBLE")]
        [TestCase("2#abcd#cdab", "abcd")]
        public void _2013_r1_Security(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<Security>(input));
        }

        [Ignore("todo")]
        public void _2013_r1_DeadPixels(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<DeadPixels>(input));
        }

        [Ignore("todo")]
        public void _2013_r2_CakeCutting(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<CakeCutting>(input));
        }

        [Ignore("todo")]
        public void _2013_r2_RoboElection(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<RoboElection>(input));
        }

        [Ignore("todo")]
        public void _2013_r2_Permutations(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<Permutations>(input));
        }

        [Ignore("todo")]
        public void _2013_r3_DigitsWar(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<DigitsWar>(input));
        }

        [Ignore("todo")]
        public void _2013_r3_NameTheBaby(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<NameTheBaby>(input));
        }

        [Ignore("todo")]
        public void _2013_r3_GreedyEntertainers(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<GreedyEntertainers>(input));
        }
    }
}
