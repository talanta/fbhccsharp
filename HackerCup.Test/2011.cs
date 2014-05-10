using HackerCup._2011.Qualification;
using HackerCup._2011.R1A;
using HackerCup._2011.R1A2;
using HackerCup._2011.R1B;
using HackerCup._2011.R1C;
using HackerCup._2011.R2;
using HackerCup._2011.R3;
using HackerCup._2011.Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerCup.Test
{
    [TestClass]
    public class _2011
    {
        [TestMethod]
        public void _DoubleSquares()
        {
            DoubleSquares ds = new DoubleSquares();

            Helper.CustomAreEqual("1", ds.Execute("10"));
            Helper.CustomAreEqual("2", ds.Execute("25"));
            Helper.CustomAreEqual("0", ds.Execute("3"));
            Helper.CustomAreEqual("1", ds.Execute("0"));
            Helper.CustomAreEqual("1", ds.Execute("1"));
        }

        [TestMethod]
        public void _DoubleSquares_large()
        {
            Helper.RunLarge<DoubleSquares>("Assets/double_squares.txt", 1);
        }

        [TestMethod]
        public void _PegGame()
        {
            PegGame ds = new PegGame();

            Helper.CustomAreEqual("0 0.375000", ds.Execute("5 4 0 1 2 2"));
            Helper.CustomAreEqual("XXX", ds.Execute("3 4 1 1 1 1"));
            Helper.CustomAreEqual("1 1.000000", ds.Execute("3 3 1 2 1 1 1 0"));
            Helper.CustomAreEqual("0 1.000000", ds.Execute("3 4 0 2 1 0 1 1"));
            Helper.CustomAreEqual("0 0.500000", ds.Execute("3 4 0 1 1 1"));
        }

        [TestMethod]
        public void _PegGame_large()
        {
            Helper.RunLarge<DoubleSquares>("Assets/peg_game.txt", 1);
        }

        [TestMethod]
        public void _StudiousStudent()
        {
            StudiousStudent ds = new StudiousStudent();

            Helper.CustomAreEqual("cupfacebookforhackerstudentsstudious", ds.Execute("6 facebook hacker cup for studious students"));
            Helper.CustomAreEqual("duzklvrawqrc", ds.Execute("5 k duz q rc lvraw"));
            Helper.CustomAreEqual("dyroiymybeaxeyubxzdr", ds.Execute("5 mybea zdr yubx xe dyroiy"));
            Helper.CustomAreEqual("bwjibwjibwjijp", ds.Execute("5 jibw ji jp bw jibw"));
            Helper.CustomAreEqual("dcyihopjijliuiuy", ds.Execute("5 uiuy hopji li j dcyi"));
        }


        [TestMethod]
        public void _StudiousStudent_large()
        {
            Helper.RunLarge<StudiousStudent>("Assets/studious_student.txt", 1);
        }

        [TestMethod]
        public void _AfterTheDanceBattle()
        {

            var t = new AfterTheDanceBattle();

            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _FirstOrLast()
        {
            var t = new FirstOrLast();

            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _PowerOverwhelming()
        {
            var t = new PowerOverwhelming();

            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _DiversityNumber()
        {
            var t = new DiversityNumber();

            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _TurnOnTheLights()
        {
            var t = new TurnOnTheLights();

            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _WineTasting()
        {
            var t = new WineTasting();

            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _Chess2()
        {
            var t = new Chess2();

            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _DiminishingCircle()
        {
            var t = new DiminishingCircle();

            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _SlotMachineHacker()
        {
            var t = new SlotMachineHacker();

            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _NFactorful()
        {
            var t = new NFactorful();

            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _PolynomialFactoring()
        {
            var t = new PolynomialFactoring();

            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _RiskySlide()
        {
            var t = new RiskySlide();

            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _BonusAssignments()
        {
            var t = new BonusAssignments();

            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _ScottsNewTrick()
        {
            var t = new ScottsNewTrick();

            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _StudiousStudentII()
        {
            var t = new StudiousStudentII();

            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _AlienGame()
        {
            var t = new AlienGame();

            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _PartyTime()
        {
            var t = new PartyTime();

            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _SafestPlace()
        {
            var t = new SafestPlace();

            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _Almost()
        {
            var t = new Almost();

            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _Characters()
        {
            var t = new Characters();

            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
        [TestMethod]
        public void _Reverser()
        {
            var t = new Reverser();

            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
            Helper.CustomAreEqual("XX", t.Execute("XX"));
        }
    }
}
