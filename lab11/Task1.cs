using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    public static class intExtensions
    {
        public static bool IsOdd(this int number)
        {
            return number % 2 == 1;
        }
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }
        public static bool IsSimple(this int number)
        {
            if (number <= 0) 
                return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

    }

    internal class Task1
    {
        public static void Run()
        {
            Console.Write("Enter number to check on being odd: ");
            if(int.TryParse(Console.ReadLine(), out int num))
                Console.WriteLine($"Result: {num.IsOdd()}");
            else
                Console.WriteLine("Wrong input!");
        }
    }
}
