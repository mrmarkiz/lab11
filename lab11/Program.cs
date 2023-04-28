using System.Xml.Serialization;

namespace lab11
{
    public class Program
    {
        public static void Main()
        {
            int choice;
            do
            {
                Console.Write("Enter task to run: ");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        Task1.Run();
                        break;
                    case 2:
                        Task2.Run();
                        break;
                    case 3:
                        Task3.Run();
                        break;
                }
            } while (choice != 0);
        }
    }
}