using HackerCup._2011.Qualification;
using HackerCup._2011.R1A;
using HackerCup._2011.R1A2;
using HackerCup._2011.R1B;
using HackerCup._2011.R1C;
using HackerCup._2011.R2;
using HackerCup._2011.R3;
using HackerCup._2011.Test;
using Xunit;

namespace HackerCup.Test
{
    public class _2011
    {
        [Theory]
        [InlineData("10", "1")]
        [InlineData("25", "2")]
        [InlineData("3", "0")]
        [InlineData("0", "1")]
        [InlineData("1", "1")]
        public void Should_return_double_squares_when_execute_input(string input, string expectedResult)
        {
            var tested = new DoubleSquares();

            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Fact]
        public void Should_return_Double_Squares_when_running_large_input()
        {
            Assert.True(Helper.RunLarge<DoubleSquares>(TestResources.double_squares, 1));
        }

        [Theory]
        [InlineData("5 4 0 1 2 2", "0 0.375000")]
        [InlineData("3 4 1 1 1 1", "XXX")]
        [InlineData("3 3 1 2 1 1 1 0", "1 1.000000")]
        [InlineData("3 4 0 2 1 0 1 1", "0 1.000000")]
        [InlineData("3 4 0 1 1 1", "0 0.500000")]
        public void Should_return_peg_game_when_execute_input(string input, string expectedResult)
        {
            var tested = new PegGame();

            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Fact]
        public void Should_return_Peg_game_when_running_large_input()
        {
            Assert.True(Helper.RunLarge<PegGame>(TestResources.peg_game, 1));
        }

        [Theory]
        [InlineData("6 facebook hacker cup for studious students", "cupfacebookforhackerstudentsstudious")]
        [InlineData("5 k duz q rc lvraw", "duzklvrawqrc")]
        [InlineData("5 mybea zdr yubx xe dyroiy", "dyroiymybeaxeyubxzdr")]
        [InlineData("5 jibw ji jp bw jibw", "bwjibwjibwjijp")]
        [InlineData("5 uiuy hopji li j dcyi", "dcyihopjijliuiuy")]
        public void Should_return_studious_student_when_execute_input(string input, string expectedResult)
        {
            var tested = new StudiousStudent();

            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }


        [Fact]
        public void _StudiousStudent_large()
        {
            Assert.True(Helper.RunLarge<StudiousStudent>(TestResources.studious_student, 1));
        }

        [Theory]
        [InlineData("XX", "XX")]
        public void _AfterTheDanceBattle(string input, string expectedResult)
        {
            var tested = new AfterTheDanceBattle();

            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Theory]
        [InlineData("XX", "XX")]
        public void _FirstOrLast(string input, string expectedResult)
        {
            var tested = new FirstOrLast();

            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Theory]
        [InlineData("XX", "XX")]
        public void _PowerOverwhelming(string input, string expectedResult)
        {
            var tested = new PowerOverwhelming();

            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Theory]
        [InlineData("XX", "XX")]
        public void _DiversityNumber(string input, string expectedResult)
        {
            var tested = new DiversityNumber();

            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Theory]
        [InlineData("XX", "XX")]
        public void _TurnOnTheLights(string input, string expectedResult)
        {
            var tested = new TurnOnTheLights();

            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Theory]
        [InlineData("XX", "XX")]
        public void _WineTasting(string input, string expectedResult)
        {
            var tested = new WineTasting();

            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Theory]
        [InlineData("XX", "XX")]
        public void _Chess2(string input, string expectedResult)
        {
            var tested = new Chess2();

            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Theory]
        [InlineData("XX", "XX")]
        public void _DiminishingCircle(string input, string expectedResult)
        {
            var tested = new DiminishingCircle();

            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Theory]
        [InlineData("XX", "XX")]
        public void _SlotMachineHacker(string input, string expectedResult)
        {
            var tested = new SlotMachineHacker();

            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Theory]
        [InlineData("XX", "XX")]
        public void _NFactorful(string input, string expectedResult)
        {
            var tested = new NFactorful();

            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Theory]
        [InlineData("XX", "XX")]
        public void _PolynomialFactoring(string input, string expectedResult)
        {
            var tested = new PolynomialFactoring();

            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Theory]
        [InlineData("XX", "XX")]
        public void _RiskySlide(string input, string expectedResult)
        {
            var tested = new RiskySlide();

            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Theory]
        [InlineData("XX", "XX")]
        public void _BonusAssignments(string input, string expectedResult)
        {
            var tested = new BonusAssignments();

            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Theory]
        [InlineData("XX", "XX")]
        public void _ScottsNewTrick(string input, string expectedResult)
        {
            var tested = new ScottsNewTrick();

            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Theory]
        [InlineData("XX", "XX")]
        public void _StudiousStudentII(string input, string expectedResult)
        {
            var tested = new StudiousStudentII();

            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Theory]
        [InlineData("XX", "XX")]
        public void _AlienGame(string input, string expectedResult)
        {
            var tested = new AlienGame();

            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Theory]
        [InlineData("XX", "XX")]
        public void _PartyTime(string input, string expectedResult)
        {
            var tested = new PartyTime();

            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Theory]
        [InlineData("XX", "XX")]
        public void _SafestPlace(string input, string expectedResult)
        {
            var tested = new SafestPlace();

            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Theory]
        [InlineData("XX", "XX")]
        public void _Almost(string input, string expectedResult)
        {
            var tested = new Almost();

            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Theory]
        [InlineData("XX", "XX")]
        public void _Characters(string input, string expectedResult)
        {
            var tested = new Characters();

            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Theory]
        [InlineData("XX", "XX")]
        public void _Reverser(string input, string expectedResult)
        {
            var tested = new Reverser();

            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }
    }
}
