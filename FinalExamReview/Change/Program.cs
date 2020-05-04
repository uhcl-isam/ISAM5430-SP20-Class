using System;
using System.Collections.Generic;
namespace Change
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write down your sentence here with your pocket change.");
            string sentence = Console.ReadLine();
            if (!string.IsNullOrEmpty(sentence))
            {
                // I have 25 quarters and 30 nickels in my pocket.

                sentence = sentence.ToLowerInvariant();
                string[] words = sentence.Split(new[] { '-', ';', ' ', '\t', '\r', '\n', '.', ',', '!', '(', ')' }, StringSplitOptions.RemoveEmptyEntries); ;
                decimal amount = 0;
                for (int i = 0; i < words.Length; i++)
                {
                    string word = words[i];
                    decimal worth;
                    if (_change.TryGetValue(word, out worth))
                    {
                        if (i > 0)
                        {
                            int number;
                            if (int.TryParse(words[i - 1], out number))
                            {
                                amount = amount + number * worth;
                            }
                        }
                    }
                }
                Console.WriteLine($"The total amount found in the sentence is {amount:C}");
            }
            else
            {
                Console.WriteLine("You did not enter a sentence");
            }

        }

        /// <summary>
        /// This is our lookup table for how much a change is worth.
        /// </summary>
        private static readonly Dictionary<string, decimal> _change = new Dictionary<string, decimal>()
        {
            { "cent", 0.01m },
            { "cents", 0.01m },
            { "penny", 0.01m },
            { "pennies", 0.01m },
            { "nickel", 0.05m },
            { "nickels", 0.05m },
            { "dime", 0.1m },
            { "dimes", 0.1m },
            { "quarter", 0.25m },
            { "quarters", 0.25m }
        };
    }
}
