using System;
using System.IO;
using System.Reflection;
using System.Linq;

namespace HackerCup.Test
{
    public static class Helper
    {
        public static string Execute<T>(string inputs) where T : IExecutable, new()
        {
            var input = inputs.Split('#');
            var tartget = new T();

            var output  = tartget.Execute(input);

            return string.Join("#", output);

        }
        public static string[] splitContent(string content)
        {
            string[] split = content.Split(new[] { "\n", Environment.NewLine }, StringSplitOptions.None);
            return split;
        }

        private static string Transform(string input)
        {
            const string _type = ";System.String, mscorlib, Version=4.0.0.0";
            if (!input.Contains(_type)) { return input; }
            var assembly = typeof(Helper).GetTypeInfo().Assembly;
            var fileName =(input.Split(';')[0]).Replace('\\','.');

            var allresx = assembly.GetManifestResourceNames();
            var resx = allresx.FirstOrDefault(f => f.ToUpperInvariant().EndsWith(fileName.ToUpper()));
            if (null == resx) { throw new InvalidOperationException("Check this out: https://github.com/dotnet/cli/issues/3695"); }

            using (var stream = new StreamReader(assembly.GetManifestResourceStream(resx)))
            {
                return stream.ReadToEnd();
            }
        }


        public static bool RunLarge<T>(string content, int numOfInputSplit) where T : IExecutable, new()
        {
            content = Transform(content);
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
