using System;
using System.Linq;

namespace HackerCup._2012.Qualification
{
    /// <summary>
    /// https://www.facebook.com/hackercup/problems.php?pid=215823855164332&round=146094915502528
    /// </summary>
    public class Billboards : IExecutable
    {
        public string[] Execute(params string[] input)
        {
            string[] split = input[0].Split();
            int w = int.Parse(split[0]);
            int h = int.Parse(split[1]);
            int bestFont = 0;
            string initialWord = string.Join(" ", split.Skip(2));
            int numberOfWords = split.Skip(2).Count();

            /// We start to loop down the fontsize since the given width
            for (int fontSize = w; fontSize >= 0; fontSize--)
            {
                int width = 0;
                int height = fontSize;
                bool gofurther = false;
                if (fontSize > h)
                    continue;
                /// foreach workd
                for (int j = 0; j < numberOfWords; j++)
                {
                    /// if its lengh  with the current fontsize is greather than the given width
                    /// we continue the upper loop
                    if (split[2 + j].Length * fontSize > w)
                    {
                        gofurther = true;
                        break;
                    }
                    /// we count the space when the widht is greather than 0
                    int space = width == 0 ? 0 : 1;
                    /// we add the next word to the total width
                    if (width + (split[2 + j].Length + space) * fontSize <= w)
                        width += (split[2 + j].Length + space) * fontSize;
                    else
                    {
                        /// After exploring the width we continue with the height.
                        height += fontSize;
                        /// if total height is greater, we continue the upper looop (reduce the fontsize)
                        if (height > h)
                        {
                            gofurther = true;
                            break;
                        }
                        /// current width is replace by the current word width.
                        width = split[2 + j].Length * fontSize;
                    }
                }
                bestFont = fontSize;
                // since we the greatest font, no need to continue.
                if (false == gofurther)
                    break;
            }

            return new[] { bestFont.ToString() };
        }
    }
}
