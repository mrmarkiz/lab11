namespace lab11
{
    internal class Program
    {



        public static void Main()
        {
            
        }
    }
}

public static class intExtensions
{
    public static int myConvertDolar(this int input)
    {
        return input * 8;
    }
}
public class Program
{
    public static void Main()
    {
        int num = 5; Console.WriteLine(num.myConvertDolar()); Console.ReadLine();
    }
}