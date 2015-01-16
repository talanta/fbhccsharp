using System;
using System.IO;

namespace HackerCup.Test
{
    public class Helper
    {
        public static string[] splitContent(string content)
        {
            string[] split = content.Split(new[] { "\n", Environment.NewLine }, StringSplitOptions.None);
            return split;
        }


        public static bool RunLarge<T>(string content, int numOfInputSplit) where T : IExecutable, new()
        {
            string[] split = Helper.splitContent(content);
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
            return numberOfCases == count - 1;
        }
    }
}
