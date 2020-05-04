using System;
using System.Collections.Generic;

namespace FinalExamReview
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build a Login system using a dictionary.
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            if (LoginInfo.ContainsKey(username))
            {
                if (LoginInfo[username] == password)
                {
                    Console.WriteLine($"{username} is Logged On");
                }
                else
                {
                    Console.WriteLine($"The password entered is incorrect.");
                }
            }
            else
            {
                Console.WriteLine($"The username {username} is not found.");
            }
            Console.WriteLine("Another way");
            string correctPassword;

            if (LoginInfo.TryGetValue(username, out correctPassword))
            {
                if (correctPassword == password)
                {
                    Console.WriteLine($"{username} is Logged On");
                }
                else
                {
                    Console.WriteLine($"The password entered is incorrect.");
                }
            }
            else
            {
                Console.WriteLine($"The username {username} is not found.");
            }

            foreach(var kvp in LoginInfo)
            {
                Console.WriteLine($"{kvp.Key, 10} {kvp.Value}");
            }

            string[] keys = new string[LoginInfo.Keys.Count];
            LoginInfo.Keys.CopyTo(keys, 0);

            for (int i =0; i<keys.Length; i++)
            {
                Console.WriteLine($"{keys[i], 10} {LoginInfo[keys[i]]}");
            }

            foreach(var key in LoginInfo.Keys)
            {
                Console.WriteLine($"{key,10} {LoginInfo[key]}");
            }
        }

        // Static constructor: it is called whenever you first reference the class.
        static Program()
        {
            LoginInfo["wum"] = "abc";
            LoginInfo["mo"] = "123";
            LoginInfo["saleem"] = "admin";
        }

        private static readonly Dictionary<string, string> LoginInfo = new Dictionary<string, string>
        {
            { "wum", "abc" },
            { "mo", "123" },
            { "saleem", "" }
        };

        private static readonly Dictionary<string, string> LoginInfo6 = new Dictionary<string, string>()
        {
            ["wum"] = "abc",
            ["mo"] ="123",
            ["saleem"] = ""
        };
    }
}
