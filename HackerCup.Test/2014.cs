﻿using HackerCup._2014.Qualification;
using HackerCup._2014.R1;
using HackerCup._2014.R2;
using HackerCup._2014.R3;
using Xunit;

namespace HackerCup.Test
{
    public class _2014
    {
        public void _SquareDetector(string input, string expectedResult)
        {
            var tested = new SquareDetector();
            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        public void _BasketballGame(string input, string expectedResult)
        {
            var tested = new BasketballGame();
            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        public void _Tennison(string input, string expectedResult)
        {
            var tested = new Tennison();
            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Theory]
        [InlineData("EHT 34", "THE")]
        [InlineData("ABCEFKO 4296473", "FACEBOOK")]
        [InlineData("ACEHKMPRTU 4125383079316", "HACKERCUPTEAM")]
        [InlineData("CDEGHIKLOSUWY 8333092520403744490", "WISHESYOUGOODLUCK")]
        [InlineData("ADEFHNOPSUVY 3365973428406169086", "ANDHOPESYOUHAVEFUN")]
        public void _Labelmaker(string input, string expectedResult)
        {
            var tested = new Labelmaker();
            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        [Fact]
        public void _Labelmaker_large()
        {
            Assert.True(Helper.RunLarge<Labelmaker>(TestResources.labelmaker, 1));
        }


        public void _CoinsGame(string input, string expectedResult)
        {
            var tested = new CoinsGame();
            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        public void _AAAAAA(string input, string expectedResult)
        {
            var tested = new AAAAAA();
            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        public void _PreventingAlzheimers(string input, string expectedResult)
        {
            var tested = new PreventingAlzheimers();
            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        public void _MagicPairs(string input, string expectedResult)
        {
            var tested = new MagicPairs();

        }

        public void _HoldemNumbers(string input, string expectedResult)
        {
            var tested = new HoldemNumbers();
            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        public void _SkiResortPlanning(string input, string expectedResult)
        {
            var tested = new SkiResortPlanning();
            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        public void _IntervalsOfLove(string input, string expectedResult)
        {
            var tested = new IntervalsOfLove();
            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        public void _LunchAtFacebook(string input, string expectedResult)
        {
            var tested = new LunchAtFacebook();
            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        public void _FortunateWheels(string input, string expectedResult)
        {
            var tested = new FortunateWheels();
            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

        public void _Tours(string input, string expectedResult)
        {
            var tested = new Tours();
            Assert.Equal(expectedResult, tested.Execute(input)[0]);
        }

    }
}
