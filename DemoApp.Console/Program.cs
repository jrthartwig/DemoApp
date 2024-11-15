namespace DemoApp.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine() ?? string.Empty;
            PrintGreeting(name);
        }

        public static void PrintGreeting(string name)
        {
            Console.WriteLine($"Hello, {name}!!");
            int letterCount = name.Length;
            Console.WriteLine($"Your name has {letterCount} letters.");
        }
    }
}