using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace lab11
{
    public static class stringExtensions
    {
        public static int CountVowels(this string str)
        {
            int result = 0;
            string vowels = "aeiouy";
            foreach (char ch in str)
            {
                if (vowels.IndexOf(ch) != -1)
                    result++;
            }
            return result;
        }

        public static int CountConsonants(this string str)
        {
            int result = 0;
            string consonants = "bcdfghjklmnpqrstvwxz";
            foreach (char ch in str)
            {
                if (consonants.IndexOf(ch) != -1)
                    result++;
            }
            return result;
        }
    }

    internal class Task4
    {
        public static void Run()
        {
            Console.WriteLine("Enter string to count vowels in:");
            string input = Console.ReadLine();
            Console.WriteLine($"Result: {input.CountVowels()}");
        }
    }
}
