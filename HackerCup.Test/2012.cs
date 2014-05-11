using HackerCup._2012.Qualification;
using HackerCup._2012.R1;
using HackerCup._2012.R2;
using HackerCup._2012.R3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerCup.Test
{
    [TestClass]
    public class _2012
    {
        [TestMethod]
        public void _AlphabetSoup()
        {
            var t = new AlphabetSoup();
            Helper.CustomAreEqual("1", t.Execute("WELCOME TO FACEBOOK HACKERCUP"));
            Helper.CustomAreEqual("2", t.Execute("CUP WITH LABEL HACKERCUP BELONGS TO HACKER"));
            Helper.CustomAreEqual("1", t.Execute("QUICK CUTE BROWN FOX JUMPS OVER THE LAZY DOG"));
            Helper.CustomAreEqual("0", t.Execute("MOVE FAST BE BOLD"));
            Helper.CustomAreEqual("1", t.Execute("HACK THE HACKERCUP"));
        }

        [TestMethod]
        public void _AlphabetSoup_large()
        {
            Helper.RunLarge<AlphabetSoup>("Assets/alphabet_soup.txt", 1);
        }

        [TestMethod]
        public void _Auction()
        {
            var t = new Auction();
            Helper.CustomAreEqual("3 3", t.Execute("5 1 4 5 7 1 0 1 2"));
            Helper.CustomAreEqual("3 3", t.Execute("3 1 3 3 3 1 0 1 1"));
            Helper.CustomAreEqual("2 3", t.Execute("8 1 3 3 3 1 0 1 2"));
            Helper.CustomAreEqual("2 2", t.Execute("13 5 7 5 9 1 3 2 5"));
            Helper.CustomAreEqual("3 1", t.Execute("11 2 3 5 7 11 13 17 19"));
        }
        [TestMethod]
        public void _Billboards()
        {
            var t = new Billboards();
            Helper.CustomAreEqual("3", t.Execute("20 6 hacker cup"));
            Helper.CustomAreEqual("2", t.Execute("10 20 MUST BE ABLE TO HACK"));
            Helper.CustomAreEqual("8", t.Execute("55 25 Can you hack"));
            Helper.CustomAreEqual("7", t.Execute("100 20 Hack your way to the cup"));
            Helper.CustomAreEqual("10", t.Execute("100 20 hacker cup 2013"));

        }
        [TestMethod]
        public void _Billboards_large()
        {
            Helper.RunLarge<AlphabetSoup>("Assets/billboards.txt", 1);
        }

        [TestMethod]
        public void _Checkpoint()
        {
            var t = new Checkpoint(); 
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _RecoverTheSequence()
        {
            var t = new RecoverTheSequence(); 
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _SquishedStatus()
        {
            var t = new SquishedStatus(); 
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _Monopoly()
        {
            var t = new Monopoly(); 
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _RoadRemoval()
        {
            var t = new RoadRemoval(); 
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _SequenceSlicing()
        {
            var t = new SequenceSlicing(); 
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _DivisorFunctionOptimization()
        {
            var t = new DivisorFunctionOptimization(); 
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _Trapezoids()
        {
            var t = new Trapezoids(); 
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _Unfriending()
        {
            var t = new Unfriending(); 
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
    }
}
