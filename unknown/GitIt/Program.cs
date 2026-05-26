using System.Data;

namespace GitIt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the program!");
            Console.WriteLine("For help write 'help', to quit write 'quit'!");
            while (true)
            {
                string command = Input("Command: ");
                if(command == "quit")
                {
                    Console.WriteLine("Bye");
                    break;
                }
                if (command == "help")
                    WriteHelp();
                else
                {
                    Console.WriteLine($"Unknown command {command}!");
                }
            }
        }
        static void WriteHelp()
        {
            Console.WriteLine("Commands");
            Console.WriteLine("help    - get help");
            Console.WriteLine("quit    - quit the program");
        }
        static string Input(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}
