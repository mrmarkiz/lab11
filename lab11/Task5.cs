using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    internal class Task5
    {
        public static void Run()
        {
            Console.WriteLine("Enter string to count consostants in:");
            string input = Console.ReadLine();
            Console.WriteLine($"Result: {input.CountConsonants()}");
        }
    }
}
