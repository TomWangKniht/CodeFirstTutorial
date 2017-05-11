using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilLib.ClassUtil
{
    public static class RandomUtil
    {
        private static Random _random = new Random();
        private static char[] DEFAULT_LETTERS = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        public static string GetLetters(int Length, char[] chars = null)
        {
            if (chars == null)
            {
                chars = DEFAULT_LETTERS;
            }
            var builder = new StringBuilder();
            for (var i = 0; i < Length; i++)
            {
                var rnd = _random.Next(0, chars.Length);
                builder.Append(chars[rnd]);
            }
            return builder.ToString();
        }
    }
}
