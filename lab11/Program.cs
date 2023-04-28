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
    }

    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter numeber: ");
            if(int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine($"Odd check result: {number.IsOdd()}");
                Console.WriteLine($"Even check result: {number.IsEven()}");
            }
        }
    }
}