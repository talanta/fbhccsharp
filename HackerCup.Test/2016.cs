using HackerCup._2016.R2;
using NUnit.Framework;

namespace HackerCup.Test
{
    public class _2016
    {
        [Ignore("TODO")]
        [TestCase("3#0 0#0 1#0 3", "0")]
        [TestCase("5#0 0#0 1#0 2#0 3#0 4", "4")]
        [TestCase("4#0 0#0 100#100 0#100 100", "4")]
        [TestCase("4#0 0#-3 4#0 5#-5 0", "3")]
        [TestCase("6#5 6#6 5#7 6#6#7 8#8 7", "12")]
        public void _2016_q_BoomerangConstellations(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<Boomrang>(input));
        }

        [Ignore("TODO")]
        [TestCase("8#...X.X..#.......X", "3")]
        [TestCase("5#.X.X.#.XXX.", "3")]
        [TestCase("7#.....X.#.X.....", "2")]
        [TestCase("9#..X.X.X..#..X...X.X", "5")]
        [TestCase("15#.X..........X..#.X...XX.X.X....", "6")]
        public void _2016_q_HighSecurity(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<Boomrang>(input));
        }

        [Ignore("TODO")]
        [TestCase("4 50#10 10 10 10", "10")]
        [TestCase("4 50#51 51 51 51", "0")]
        [TestCase("3 1000000000#1000000000 1000000000 1000000000", "3")]
        [TestCase("6 6#1 2 3 4 5 6", "9")]
        [TestCase("10 77#12 3 52 25 9 83 45 21 33 3", "18")]
        public void _2016_q_PriceCorrect(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<Boomrang>(input));
        }

        public void _2016_q_TextEditor(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<Boomrang>(input));
        }

        [TestCase("3#ABC#ABC", "0")]
        [TestCase("3#ABC#CBA", "1")]
        [TestCase("3#ABC#BAC", "2")]
        [TestCase("9#FOXENRULE#NOREAALLY", "3")]
        [TestCase("19#DOYOULIKEBOOMERANGS#OOBOOOOVVBOOEAAAGGS", "4")]
        public void _2016_r2_boomerang(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<Boomrang>(input));
        }
    }
}
