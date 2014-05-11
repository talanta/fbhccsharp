using HackerCup._2014.Qualification;
using HackerCup._2014.R1;
using HackerCup._2014.R2;
using HackerCup._2014.R3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerCup.Test
{
    [TestClass]
    public class _2014
    {
        [TestMethod]
        public void _SquareDetector()
        {
            var t = new SquareDetector();
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _BasketballGame()
        {
            var t = new BasketballGame();
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _Tennison()
        {
            var t = new Tennison();
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _Labelmaker()
        {
            var t = new Labelmaker();
            Helper.CustomAreEqual("THE", t.Execute("EHT 34"));
            Helper.CustomAreEqual("FACEBOOK", t.Execute("ABCEFKO 4296473"));
            Helper.CustomAreEqual("HACKERCUPTEAM", t.Execute("ACEHKMPRTU 4125383079316"));
            Helper.CustomAreEqual("WISHESYOUGOODLUCK", t.Execute("CDEGHIKLOSUWY 8333092520403744490"));
            Helper.CustomAreEqual("ANDHOPESYOUHAVEFUN", t.Execute("ADEFHNOPSUVY 3365973428406169086"));
        }

        [TestMethod]
        public void _Labelmaker_large()
        {
            Helper.RunLarge<Labelmaker>("Assets/billboards.txt", 1);
        }

        [TestMethod]
        public void _CoinsGame()
        {
            var t = new CoinsGame();
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _AAAAAA()
        {
            var t = new AAAAAA();
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _PreventingAlzheimers()
        {
            var t = new PreventingAlzheimers();
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _MagicPairs()
        {
            var t = new MagicPairs();
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _HoldemNumbers()
        {
            var t = new HoldemNumbers();
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _SkiResortPlanning()
        {
            var t = new SkiResortPlanning();
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _IntervalsOfLove()
        {
            var t = new IntervalsOfLove();
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _LunchAtFacebook()
        {
            var t = new LunchAtFacebook();
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _FortunateWheels()
        {
            var t = new FortunateWheels();
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _Tours()
        {
            var t = new Tours();
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }

    }
}
