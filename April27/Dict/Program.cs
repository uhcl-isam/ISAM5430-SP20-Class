using System;
using System.Collections.Generic;

namespace Dict
{
    class Program
    {
        static void Main(string[] args)
        {
            // Count the occurrences of every unique word in a sentence

            Console.WriteLine("Enter a sentence");
            string sentence = Console.ReadLine();

            // how do we get each word from a sentence?
            string[] words = sentence.Split(new char[] { ' ', '\n', '\r', '\t', '.', ';', ',' }, StringSplitOptions.RemoveEmptyEntries);

            // create a new instance of a dictionary
            var dict = new SortedDictionary<string, int>();
            // iterate through all the words.

            foreach(string word in words)
            {
                string wordlc = word.ToLowerInvariant();
                // when the word exists
                if (dict.ContainsKey(wordlc))
                {
                    dict[wordlc] = dict[wordlc] + 1;
                }
                // when the word is new
                else
                {
                    dict[wordlc] = 1;
                }
            }

            // Show the frequencies of all the words
            foreach(var kvp in dict)
            {
                Console.WriteLine($"The word '{kvp.Key}' occurs {kvp.Value} times.");
            }
        }
    }
}
