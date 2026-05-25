namespace d7_ovn_7_2_1_REPL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Command: ");
                string command = Console.ReadLine();
                if (command == "exit" || command == "quit")
                {
                    break;
                }
                else if (command == "")
                    ;
                else if (command == "para")
                {
                    Task para = new Task(() => Para());
                    para.Start();
                    para.Wait();
                }
                else
                {
                    Console.WriteLine($"Unknown command: {command}");
                }
            } while (true);
            Console.WriteLine("Bye!");
        }
        static async void Para()
        {
            for (int i = 0; i < 20; i++)
            {
                await Task.Delay(333);
                Console.WriteLine($"{i}");
            }
        }
    }
}
