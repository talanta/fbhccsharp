using HackerCup._2016.R2;
using NUnit.Framework;

namespace HackerCup.Test
{
    public class _2016
    {
        
        public void _2016_r1_()
        {

        }
        [TestCase("3#ABC#ABC", "0")]
        [TestCase("3#ABC#CBA", "1")]
        [TestCase("3#ABC#BAC", "2")]
        [TestCase("9#FOXENRULE#NOREAALLY", "3")]
        [TestCase("19#DOYOULIKEBOOMERANGS#OOBOOOOVVBOOEAAAGGS", "4")]
        public void _2016_r2_boomerang(string input, string expected)
        {
            Assert.AreEqual(expected, Helper.Execute<Boomrang>(input));
        }
    }
}
