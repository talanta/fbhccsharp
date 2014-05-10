using HackerCup._2013.Qualification;
using HackerCup._2013.R1;
using HackerCup._2013.R2;
using HackerCup._2013.R3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerCup.Test
{
    [TestClass]
    public class _2013
    {

        [TestMethod]
        public void _BeautifulStrings()
        {
            var bf = new BeautifulStrings();

            Helper.CustomAreEqual("152", bf.Execute("ABbCcc"));
            Helper.CustomAreEqual("754", bf.Execute("Good luck in the Facebook Hacker Cup this year!"));
            Helper.CustomAreEqual("491", bf.Execute("Ignore punctuation, please :)"));
            Helper.CustomAreEqual("729", bf.Execute("Sometimes test cases are hard to make up."));
            Helper.CustomAreEqual("646", bf.Execute("So I just go consult Professor Dalves"));
        }

        [TestMethod]
        public void _BeautifulStrings_large()
        {
            Helper.RunLarge<BeautifulStrings>("Assets/beautiful_strings.txt", 1);
        }

        [TestMethod]
        public void _BalancedSmileys()
        {
            var bm = new BalancedSmileys();

            Helper.CustomAreEqual("NO", bm.Execute(":(("));
            Helper.CustomAreEqual("YES", bm.Execute("i am sick today (:()"));
            Helper.CustomAreEqual("YES", bm.Execute("(:)"));
            Helper.CustomAreEqual("YES", bm.Execute("hacker cup: started :):)"));
            Helper.CustomAreEqual("NO", bm.Execute(")("));
        }
        [TestMethod]
        public void _FindTheMin()
        {
            var fm = new FindTheMin();

            Helper.CustomAreEqual("8", fm
                .Execute("97 39", "34 37 656 97"));
            Helper.CustomAreEqual("38", fm
                .Execute("186 75", "68 16 539 186"));
            Helper.CustomAreEqual("41", fm
                .Execute("137 49", "48 17 461 137"));
            Helper.CustomAreEqual("40", fm
                .Execute("98 59", "6 30 524 98"));
            Helper.CustomAreEqual("12", fm
                .Execute("46 18", "7 11 9 46"));
        }

        [TestMethod]
        public void _FindTheMin_large()
        {
            Helper.RunLarge<FindTheMin>("Assets/find_the_min.txt", 2);
        }

        [TestMethod]
        public void _CardGame()
        {
            var t = new CardGame();

            Helper.CustomAreEqual("30", t
                .Execute("4 3", "3 6 2 8"));
            Helper.CustomAreEqual("400", t
                .Execute("5 2", "10 20 30 40 50"));
            Helper.CustomAreEqual("103", t
                .Execute("6 4", "0 1 2 3 5 8"));
            Helper.CustomAreEqual("1122", t
                .Execute("2 2", "1069 1122"));
            Helper.CustomAreEqual("2621483", t
                .Execute("10 5", "10386 10257 10432 10087 10381 10035 10167 10206 10347 10088"));

        }

        [TestMethod]
        public void _CardGame_large()
        {
            Helper.RunLarge<CardGame>("Assets/card_game.txt", 2);
        }

        [TestMethod]
        public void _Security()
        {
            var t = new Security();

            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _DeadPixels()
        {
            var t = new DeadPixels();

            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));

        }
        [TestMethod]
        public void _CakeCutting()
        {
            var t = new CakeCutting();

            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));

        }
        [TestMethod]
        public void _RoboElection()
        {
            var t = new RoboElection();

            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));

        }
        [TestMethod]
        public void _Permutations()
        {
            var t = new Permutations();

            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));

        }
        [TestMethod]
        public void _DigitsWar()
        {
            var t = new DigitsWar();

            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));

        }
        [TestMethod]
        public void _NameTheBaby()
        {
            var t = new NameTheBaby();

            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));

        }
        [TestMethod]
        public void _GreedyEntertainers()
        {
            var t = new GreedyEntertainers();

            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));

        }

    }
}
