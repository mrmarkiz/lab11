using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{

    internal class Task2
    {
        public static void Run()
        {
            Console.Write("Enter number to check on being even: ");
            if (int.TryParse(Console.ReadLine(), out int num))
                Console.WriteLine($"Result: {num.IsEven()}");
            else
                Console.WriteLine("Wrong input!");
        }
    }
}
