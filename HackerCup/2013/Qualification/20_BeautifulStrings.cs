using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerCup._2013.Qualification
{
    /*
    Beautiful strings

    When John was a little kid he didn't have much to do. There was no internet, no Facebook, and no programs to hack on. 
    So he did the only thing he could... he evaluated the beauty of strings in a quest to discover the most beautiful string 
    in the world.
    Given a string s, little Johnny defined the beauty of the string as the sum of the beauty of the letters in it.
    The beauty of each letter is an integer between 1 and 26, inclusive, and no two letters have the same beauty. Johnny doesn't care about whether letters are uppercase or lowercase, so that doesn't affect the beauty of a letter. (Uppercase 'F' is exactly as beautiful as lowercase 'f', for example.)
    You're a student writing a report on the youth of this famous hacker. You found the string that Johnny considered most beautiful. What is the maximum possible beauty of this string?

    Input
    The input file consists of a single integer m followed by m lines.
    Output
    Your output should consist of, for each test case, a line containing the string "Case #x: y" where x is the case number (with 1 being the first case in the input file, 2 being the second, etc.) and y is the maximum beauty for that test case.
    Constraints
    5 ≤ m ≤ 50
    2 ≤ length of s ≤ 500
    */
    /// <summary>
    /// https://www.facebook.com/hackercup/problems.php?pid=475986555798659&round=185564241586420
    /// </summary>
    public class BeautifulStrings
    {

        public int Execute(string input)
        {
            int result = 0;
            int beauty = 26;
            input = input.ToLower();
            Dictionary<char, int> frequencies = new Dictionary<char,int>();
            foreach (char x in input)
            {
                if (!char.IsLetter(x))
                    continue;
                if (frequencies.ContainsKey(x))
                    continue;
                frequencies.Add(x, input.Where(c => c == x).Count());
            }
            var list = frequencies.OrderByDescending(c => c.Value).Select(c => c.Key);

            foreach (var cc in list)
            {
                result += beauty* frequencies[cc];
                beauty--;
            }

            return result;
        }
    }
}
