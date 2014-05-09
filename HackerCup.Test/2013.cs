using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerCup._2013.Qualification;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace HackerCup.Test
{
    [TestClass]
    public class _2013
    {
        private string[] getFileContent(string filePath)
        {
            FileInfo file = new FileInfo(filePath);
            Assert.IsTrue(file.Exists);
            string content = string.Empty;
            using (var sr = new StreamReader(file.OpenRead()))
            {
                content = sr.ReadToEnd();
            }
            string[] split = content.Split(new[] { "\n" , Environment.NewLine}, StringSplitOptions.None);
            return split;
        }
        [TestMethod]
        public void _BeautifulStrings()
        {
            var bf = new BeautifulStrings();

            Assert.AreEqual(152, bf.Execute("ABbCcc"));
            Assert.AreEqual(754, bf.Execute("Good luck in the Facebook Hacker Cup this year!"));
            Assert.AreEqual(491, bf.Execute("Ignore punctuation, please :)"));
            Assert.AreEqual(729, bf.Execute("Sometimes test cases are hard to make up."));
            Assert.AreEqual(646, bf.Execute("So I just go consult Professor Dalves"));
        }

        [TestMethod]
        public void _BeautifulStrings_large()
        {
            string[] split = getFileContent("Assets/beautiful_strings.txt");
            int m = int.Parse(split[0]);
            BeautifulStrings ss = new BeautifulStrings();
            StringBuilder output = new StringBuilder();
            int count = 0;

            for (int i = 1; i <= m; i++)
            {
                var result = ss.Execute(split[i]);
                output.AppendFormat("Case #{0}: {1}", i, result);
                output.AppendLine();
                count++;
            }

            Assert.AreEqual(m, count);
        }

        [TestMethod]
        public void _BalancedSmileys() 
        {
            var bm = new BalancedSmileys();

            Assert.AreEqual(0, bm.Execute(":(("));
            Assert.AreEqual(1, bm.Execute("i am sick today (:()"));
            Assert.AreEqual(1, bm.Execute("(:)"));
            Assert.AreEqual(1, bm.Execute("hacker cup: started :):)"));
            Assert.AreEqual(0, bm.Execute(")("));
        }
        [TestMethod]
        public void _FindTheMin() 
        {
            var fm = new FindTheMin();

            Assert.AreEqual(8, fm
                .Execute("97 39", "34 37 656 97"));
            Assert.AreEqual(38, fm
                .Execute("186 75", "68 16 539 186"));
            Assert.AreEqual(41, fm
                .Execute("137 49", "48 17 461 137"));
            Assert.AreEqual(40, fm
                .Execute("98 59", "6 30 524 98"));
            Assert.AreEqual(12, fm
                .Execute("46 18", "7 11 9 46"));
        }

        [TestMethod]
        public void _FindTheMin_large()
        {
            string[] split = getFileContent("Assets/find_the_min.txt");
            int m = int.Parse(split[0]);
            FindTheMin ss = new FindTheMin();
            StringBuilder output = new StringBuilder();
            int count = 1;

            for (int i = 1; count <= m; i+=2, count++)
            {
                var result = ss.Execute(split[i], split[i+1]);
            Console.WriteLine("Case #{0}: {1}", count, result);
                //output.AppendLine();
            }
            //string content = output.ToString();
            //Assert.IsTrue(content.Length > 0);
            Assert.AreEqual(m, count-1);
        }

        [TestMethod]
        public void CardGame() { }
        [TestMethod]
        public void Security() { }
        [TestMethod]
        public void DeadPixels() { }
        [TestMethod]
        public void CakeCutting() { }
        [TestMethod]
        public void RoboElection() { }
        [TestMethod]
        public void Permutations() { }
        [TestMethod]
        public void DigitsWar() { }
        [TestMethod]
        public void NameTheBaby() { }
        [TestMethod]
        public void GreedyEntertainers() { }

    }
}
