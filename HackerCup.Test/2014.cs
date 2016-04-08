using HackerCup._2014.Qualification;
using HackerCup._2014.R1;
using HackerCup._2014.R2;
using HackerCup._2014.R3;
using NUnit.Framework;

namespace HackerCup.Test
{
    public class _2014
    {
        [Ignore("todo")]
        public void _2014_q_SquareDetector(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<SquareDetector>(input));
        }

        [Ignore("todo")]
        public void _2014_q_BasketballGame(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<BasketballGame>(input));
        }

        [Ignore("todo")]
        public void _2014_q_Tennison(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<Tennison>(input));
        }


        [TestCase("EHT 34", "THE")]
        [TestCase("ABCEFKO 4296473", "FACEBOOK")]
        [TestCase("ACEHKMPRTU 4125383079316", "HACKERCUPTEAM")]
        [TestCase("CDEGHIKLOSUWY 8333092520403744490", "WISHESYOUGOODLUCK")]
        [TestCase("ADEFHNOPSUVY 3365973428406169086", "ANDHOPESYOUHAVEFUN")]
        public void _2014_r1_Labelmaker(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<Labelmaker>(input));
        }

        [Test]
        public void _Labelmaker_large()
        {
            Assert.True(Helper.RunLarge<Labelmaker>(TestResources.labelmaker, 1));
        }

        [Ignore("todo")]
        public void _2014_r1_CoinsGame(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<CoinsGame>(input));
        }

        [Ignore("todo")]
        public void _2014_r1_AAAAAA(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<AAAAAA>(input));
        }

        [Ignore("todo")]
        public void _2014_r1_PreventingAlzheimers(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<PreventingAlzheimers>(input));
        }

        [Ignore("todo")]
        public void _2014_r2_MagicPairs(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<MagicPairs>(input));
        }

        [Ignore("todo")]
        public void _2014_r2_HoldemNumbers(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<HoldemNumbers>(input));
        }

        [Ignore("todo")]
        public void _2014_r2_SkiResortPlanning(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<SkiResortPlanning>(input));
        }

        [Ignore("todo")]
        public void _2014_r3_IntervalsOfLove(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<IntervalsOfLove>(input));
        }

        [Ignore("todo")]
        public void _2014_r3_LunchAtFacebook(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<LunchAtFacebook>(input));
        }

        [Ignore("todo")]
        public void _2014_r3_FortunateWheels(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<FortunateWheels>(input));
        }

        [Ignore("todo")]
        public void _2014_r3_Tours(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<Tours>(input));
        }

    }
}
