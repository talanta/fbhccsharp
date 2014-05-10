using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerCup.Test
{
    public class Helper
    {
        public static string[] getFileContent(string filePath)
        {
            FileInfo file = new FileInfo(filePath);
            Assert.IsTrue(file.Exists);
            string content = string.Empty;
            using (var sr = new StreamReader(file.OpenRead()))
            {
                content = sr.ReadToEnd();
            }
            string[] split = content.Split(new[] { "\n", Environment.NewLine }, StringSplitOptions.None);
            return split;
        }

        public static void CustomAreEqual(string expected, string[] output)
        {
            Assert.AreEqual(expected, output[0]);
        }

        public static void RunLarge<T>(string filePath, int numOfInputSplit) where T : IExecutable, new()
        {
            string[] split = Helper.getFileContent(filePath);
            int numberOfCases = int.Parse(split[0]);
            T ss = new T();
            int count = 1;
            string[] input = new string[numOfInputSplit];

            for (int i = 1; count <= numberOfCases; i += numOfInputSplit, count++)
            {
                for (int x = 0; x < numOfInputSplit; x++)
                    input[x] = split[i + x];

                var result = ss.Execute(input);
                Console.WriteLine("Case #{0}: {1}", count, result[0]);
            }
            Assert.AreEqual(numberOfCases, count - 1);
        }
    }
}
