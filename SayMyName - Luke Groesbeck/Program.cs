/*Luke Groesbeck
Project SayMyName
RCET 2265
Spring 2026
Computer Fundamentals and Introduction to Programming
https://github.com/groeluke/SayMyName.git */
namespace SayMyName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name");
            string? name = Console.ReadLine();
            Console.WriteLine($"Hello, {name} have a great day!");
            Console.Read();
        }
    }
}
