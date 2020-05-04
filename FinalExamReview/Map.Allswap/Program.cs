using System;
using System.Collections.Generic;

namespace Map.Allswap
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = new[] { "ay", "by", "", null, "ax", "bx", "aj", "ai", "by", "bx" };
            Console.WriteLine(string.Join(", ", AllSwap(strings)));
        }

        /// <summary>
        /// We'll say that 2 strings "match" if they are non-empty and their first chars are the same. Loop over and then return the given array of non-empty strings as follows: if a string matches an earlier string in the array, swap the 2 strings in the array. When a position in the array has been swapped, it no longer matches anything. Using a Dictionary, this can be solved making just one pass over the array. More difficult than it looks.
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        public static string[] AllSwap(string[] strings)
        {
            // what kind of dictionary do we need to solve this problem? TKey (first character), TValue (index/position)?
            var dict = new Dictionary<char, int>();
            for (int i =0; i < strings.Length; i++)
            {
                if (string.IsNullOrEmpty(strings[i]))
                {
                    continue;
                }
                int previousIndex;
                char c = strings[i][0];
                if (dict.TryGetValue(c, out previousIndex) && dict[c] >= 0)
                {
                    var t = strings[i];
                    strings[i] = strings[previousIndex];
                    strings[previousIndex] = t;
                    // dict.Remove(c);
                    dict[c] = -1;
                }
                else
                {
                    dict[c] = i;
                }
            }
            return strings;
        }

        /// <summary>
        /// We'll say that 2 strings "match" if they are non-empty and their first chars are the same. Loop over and then return the given array of non-empty strings as follows: if a string matches an earlier string in the array, swap the 2 strings in the array. A particular first char can only cause 1 swap, so once a char has caused a swap, its later swaps are disabled. Using a Dictionary, this can be solved making just one pass over the array. More difficult than it looks.
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        public static string[] FirstSwap(string[] strings)
        {
            // what kind of dictionary do we need to solve this problem? TKey (first character), TValue (index/position)?
            var dict = new Dictionary<char, int>();
            for (int i = 0; i < strings.Length; i++)
            {
                if (string.IsNullOrEmpty(strings[i]))
                {
                    continue;
                }
                int previousIndex;
                char c = strings[i][0];
                if (dict.TryGetValue(c, out previousIndex))
                {
                    if (dict[c] >= 0)
                    {
                        var t = strings[i];
                        strings[i] = strings[previousIndex];
                        strings[previousIndex] = t;
                        // dict.Remove(c);
                        dict[c] = -1;
                   }
                }
                else
                {
                    dict[c] = i;
                }
            }
            return strings;
        }
    }
}
