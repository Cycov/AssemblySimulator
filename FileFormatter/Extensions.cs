using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFormatter
{
    public static class Extensions
    {
        public static string[] Trim(this string[] input, params char[] trimChars)
        {
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input[i].Trim(trimChars);
            }
            return input;
        }
        public static string[] Trim(this string[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input[i].Trim();
            }
            return input;
        }
    }
}
