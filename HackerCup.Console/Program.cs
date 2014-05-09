using HackerCup._2013.Qualification;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerCup
{
    class Program
    {

        static void Main(string[] args)
        {
            FileInfo file = new FileInfo("beautiful_strings.txt");
            if (!file.Exists)
                return;
            string content = string.Empty;
            using(var sr = new StreamReader(file.OpenRead()))
            {
                content = sr.ReadToEnd();
            }
            string[] split = content.Split(new[] { "\n" }, StringSplitOptions.None);
            int m = int.Parse(split[0]);
            BeautifulStrings ss = new BeautifulStrings();


            for (int i = 1; i <= m; i++)
            {
                var result = ss.Execute(split[i]);
                System.Console.WriteLine("Case #{0}: {1}", i, result);
            }
            
        }
    }
}
