using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    internal class Task3
    {
        public static void Run()
        {
            Console.Write("Enter number to check on being simple: ");
            if (int.TryParse(Console.ReadLine(), out int num))
                Console.WriteLine($"Result: {num.IsSimple()}");
            else
                Console.WriteLine("Wrong input!");
        }
    }
}
