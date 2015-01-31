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
        public void Should_return_double_squares_when_execute_input(string input, string expectedResult)
		{
            var tested = new DoubleSquares();
	
            Assert.AreEqual(expectedResult, tested.Execute(input)[0]);
        }

        [Test]
        public void Should_return_Double_Squares_when_running_large_input()
        {
            Assert.True(Helper.RunLarge<DoubleSquares>(TestResources.double_squares, 1));
        }

        
        [TestCase("5 4 0 1 2 2", "0 0.375000")]
        [TestCase("3 4 1 1 1 1", "XXX")]
        [TestCase("3 3 1 2 1 1 1 0", "1 1.000000")]
        [TestCase("3 4 0 2 1 0 1 1", "0 1.000000")]
        [TestCase("3 4 0 1 1 1", "0 0.500000")]
        public void Should_return_peg_game_when_execute_input(string input, string expectedResult)
        {
            var tested = new PegGame();

            Assert.AreEqual(expectedResult, tested.Execute(input)[0]);
        }

        [Test]
        public void Should_return_Peg_game_when_running_large_input()
        {
            Assert.True(Helper.RunLarge<PegGame>(TestResources.peg_game, 1));
        }

        
        [TestCase("6 facebook hacker cup for studious students", "cupfacebookforhackerstudentsstudious")]
        [TestCase("5 k duz q rc lvraw", "duzklvrawqrc")]
        [TestCase("5 mybea zdr yubx xe dyroiy", "dyroiymybeaxeyubxzdr")]
        [TestCase("5 jibw ji jp bw jibw", "bwjibwjibwjijp")]
        [TestCase("5 uiuy hopji li j dcyi", "dcyihopjijliuiuy")]
        public void Should_return_studious_student_when_execute_input(string input, string expectedResult)
        {
            var tested = new StudiousStudent();

            Assert.AreEqual(expectedResult, tested.Execute(input)[0]);
        }


        [Test]
        public void _StudiousStudent_large()
        {
            Assert.True(Helper.RunLarge<StudiousStudent>(TestResources.studious_student, 1));
        }

        
        [TestCase("XX", "XX")]
        public void _AfterTheDanceBattle(string input, string expectedResult)
        {
            var tested = new AfterTheDanceBattle();

            Assert.AreEqual(expectedResult, tested.Execute(input)[0]);
        }

        
        [TestCase("XX", "XX")]
        public void _FirstOrLast(string input, string expectedResult)
        {
            var tested = new FirstOrLast();

            Assert.AreEqual(expectedResult, tested.Execute(input)[0]);
        }

        
        [TestCase("XX", "XX")]
        public void _PowerOverwhelming(string input, string expectedResult)
        {
            var tested = new PowerOverwhelming();

            Assert.AreEqual(expectedResult, tested.Execute(input)[0]);
        }

        
        [TestCase("XX", "XX")]
        public void _DiversityNumber(string input, string expectedResult)
        {
            var tested = new DiversityNumber();

            Assert.AreEqual(expectedResult, tested.Execute(input)[0]);
        }

        
        [TestCase("XX", "XX")]
        public void _TurnOnTheLights(string input, string expectedResult)
        {
            var tested = new TurnOnTheLights();

            Assert.AreEqual(expectedResult, tested.Execute(input)[0]);
        }

        
        [TestCase("XX", "XX")]
        public void _WineTasting(string input, string expectedResult)
        {
            var tested = new WineTasting();

            Assert.AreEqual(expectedResult, tested.Execute(input)[0]);
        }

        
        [TestCase("XX", "XX")]
        public void _Chess2(string input, string expectedResult)
        {
            var tested = new Chess2();

            Assert.AreEqual(expectedResult, tested.Execute(input)[0]);
        }

        
        [TestCase("XX", "XX")]
        public void _DiminishingCircle(string input, string expectedResult)
        {
            var tested = new DiminishingCircle();

            Assert.AreEqual(expectedResult, tested.Execute(input)[0]);
        }

        
        [TestCase("XX", "XX")]
        public void _SlotMachineHacker(string input, string expectedResult)
        {
            var tested = new SlotMachineHacker();

            Assert.AreEqual(expectedResult, tested.Execute(input)[0]);
        }

        
        [TestCase("XX", "XX")]
        public void _NFactorful(string input, string expectedResult)
        {
            var tested = new NFactorful();

            Assert.AreEqual(expectedResult, tested.Execute(input)[0]);
        }

        
        [TestCase("XX", "XX")]
        public void _PolynomialFactoring(string input, string expectedResult)
        {
            var tested = new PolynomialFactoring();

            Assert.AreEqual(expectedResult, tested.Execute(input)[0]);
        }

        
        [TestCase("XX", "XX")]
        public void _RiskySlide(string input, string expectedResult)
        {
            var tested = new RiskySlide();

            Assert.AreEqual(expectedResult, tested.Execute(input)[0]);
        }

        
        [TestCase("XX", "XX")]
        public void _BonusAssignments(string input, string expectedResult)
        {
            var tested = new BonusAssignments();

            Assert.AreEqual(expectedResult, tested.Execute(input)[0]);
        }

        
        [TestCase("XX", "XX")]
        public void _ScottsNewTrick(string input, string expectedResult)
        {
            var tested = new ScottsNewTrick();

            Assert.AreEqual(expectedResult, tested.Execute(input)[0]);
        }

        
        [TestCase("XX", "XX")]
        public void _StudiousStudentII(string input, string expectedResult)
        {
            var tested = new StudiousStudentII();

            Assert.AreEqual(expectedResult, tested.Execute(input)[0]);
        }

        
        [TestCase("XX", "XX")]
        public void _AlienGame(string input, string expectedResult)
        {
            var tested = new AlienGame();

            Assert.AreEqual(expectedResult, tested.Execute(input)[0]);
        }

        
        [TestCase("XX", "XX")]
        public void _PartyTime(string input, string expectedResult)
        {
            var tested = new PartyTime();

            Assert.AreEqual(expectedResult, tested.Execute(input)[0]);
        }

        
        [TestCase("XX", "XX")]
        public void _SafestPlace(string input, string expectedResult)
        {
            var tested = new SafestPlace();

            Assert.AreEqual(expectedResult, tested.Execute(input)[0]);
        }

        
        [TestCase("XX", "XX")]
        public void _Almost(string input, string expectedResult)
        {
            var tested = new Almost();

            Assert.AreEqual(expectedResult, tested.Execute(input)[0]);
        }

        
        [TestCase("XX", "XX")]
        public void _Characters(string input, string expectedResult)
        {
            var tested = new Characters();

            Assert.AreEqual(expectedResult, tested.Execute(input)[0]);
        }

        
        [TestCase("XX", "XX")]
        public void _Reverser(string input, string expectedResult)
        {
            var tested = new Reverser();

            Assert.AreEqual(expectedResult, tested.Execute(input)[0]);
        }
    }
}
