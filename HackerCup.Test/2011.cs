using HackerCup._2011.Qualification;
using HackerCup._2011.R1A;
using HackerCup._2011.R1A2;
using HackerCup._2011.R1B;
using HackerCup._2011.R1C;
using HackerCup._2011.R2;
using HackerCup._2011.R3;
using HackerCup._2011.Test;
using NUnit.Framework;

namespace HackerCup.Test
{
    public class _2011
    {

        [TestCase("10", "1")]
        [TestCase("25", "2")]
        [TestCase("3", "0")]
        [TestCase("0", "1")]
        [TestCase("1", "1")]
        public void _2011_q_DoubleSquares(string input, string @out)
		{
            Assert.AreEqual(@out, Helper.Execute<DoubleSquares>(input));
        }

        [Test]
        public void Should_return_Double_Squares_when_running_large_input()
        {
            Assert.True(Helper.RunLarge<DoubleSquares>(TestResources.double_squares, 1));
        }


        [Ignore("TODO")]
        [TestCase("5 4 0 1 2 2", "0 0.375000")]
        [TestCase("3 4 1 1 1 1", "XXX")]
        [TestCase("3 3 1 2 1 1 1 0", "1 1.000000")]
        [TestCase("3 4 0 2 1 0 1 1", "0 1.000000")]
        [TestCase("3 4 0 1 1 1", "0 0.500000")]
        public void _2011_q_peg_game(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<PegGame>(input));
        }

        [Test]
        public void Should_return_Peg_game_when_running_large_input()
        {
            Assert.True(Helper.RunLarge<PegGame>(TestResources.peg_game, 1));
        }

        [Ignore("TODO")]
        [TestCase("6 facebook hacker cup for studious students", "cupfacebookforhackerstudentsstudious")]
        [TestCase("5 k duz q rc lvraw", "duzklvrawqrc")]
        [TestCase("5 mybea zdr yubx xe dyroiy", "dyroiymybeaxeyubxzdr")]
        [TestCase("5 jibw ji jp bw jibw", "bwjibwjibwjijp")]
        [TestCase("5 uiuy hopji li j dcyi", "dcyihopjijliuiuy")]
        public void _2011_q_studious_student(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<StudiousStudent>(input));
        }


        [Test]
        public void _StudiousStudent_large()
        {
            Assert.True(Helper.RunLarge<StudiousStudent>(TestResources.studious_student, 1));
        }


        [Ignore("todo")]
        public void _AfterTheDanceBattle(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<AfterTheDanceBattle>(input));
        }


        [Ignore("todo")]
        public void _FirstOrLast(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<FirstOrLast>(input));
        }


        [Ignore("todo")]
        public void _PowerOverwhelming(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<PowerOverwhelming>(input));
        }


        [Ignore("todo")]
        public void _DiversityNumber(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<DiversityNumber>(input));
        }


        [Ignore("todo")]
        public void _TurnOnTheLights(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<TurnOnTheLights>(input));
        }


        [Ignore("todo")]
        public void _WineTasting(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<WineTasting>(input));
        }


        [Ignore("todo")]
        public void _Chess2(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<Chess2>(input));
        }


        [Ignore("todo")]
        public void _DiminishingCircle(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<DiminishingCircle>(input));
        }


        [Ignore("todo")]
        public void _SlotMachineHacker(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<SlotMachineHacker>(input));
        }


        [Ignore("todo")]
        public void _NFactorful(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<NFactorful>(input));
        }


        [Ignore("todo")]
        public void _PolynomialFactoring(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<PolynomialFactoring>(input));
        }


        [Ignore("todo")]
        public void _RiskySlide(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<RiskySlide>(input));
        }


        [Ignore("TODO")]
        [TestCase("2 1 2 4 5", "6")]
        [TestCase("2 2 4 3 5", "10")]
        [TestCase("1 5 10 5 10", "0")]
        [TestCase("5 5 7 2 3", "0")]
        [TestCase("5 2 7 5 12", "149190")]
        public void _2011_r2_BonusAssignments(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<BonusAssignments>(input));
        }

        [Ignore("TODO")]
        [TestCase("3 1#4 0 2 2 2 2#2 1 2 1 0 0", "6")]
		[TestCase("3 1#5 2 0 0 1 1#5 1 1 2 0 0", "10")]
		[TestCase("3 3#5 0 0 1 2 2#3 2 1 1 1 1", "15")]
		[TestCase("5 1#5 2 0 4 0 4#3 2 1 2 4 4", "3")]
		[TestCase("5 4#2 2 1 3 1 4#5 1 0 2 3 3", "9")]
        public void _2011_r2_ScottsNewTrick(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<ScottsNewTrick>(input));
        }

        [Ignore("TODO")]
        [TestCase("ab", "3")]
		[TestCase("aba", "13")]
		[TestCase("aabb", "57")]
		[TestCase("ababa", "642")]
		[TestCase("bbbbb", "120")]
        public void _2011_r2_StudiousStudentII(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<StudiousStudentII>(input));
        }

        [Ignore("TODO")]
        [TestCase("3 2#1 2 3", "2")]
		[TestCase("3 2#-2 1 -1", "1")]
		[TestCase("4 2#4 3 2 1", "5")]
		[TestCase("4 3#1 -2 3 -4", "2")]
		[TestCase("5 3#1 2 2 4 -1", "2")]
        public void _2011_r3_AlienGame(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<AlienGame>(input));
        }


        [Ignore("todo")]
        public void _2011_r3_PartyTime(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<PartyTime>(input));
        }


        [Ignore("todo")]
        public void _2011_r3_SafestPlace(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<SafestPlace>(input));
        }


        [Ignore("todo")]
        public void _Almost(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<Almost>(input));
        }


        [Ignore("todo")]
        public void _Characters(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<Characters>(input));
        }


        [Ignore("todo")]
        public void _Reverser(string input, string @out)
        {
            Assert.AreEqual(@out, Helper.Execute<Reverser>(input));
        }
    }
}
