namespace mju23h_dtp_genrep_FAS3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] command;
            while (true)
            {
                Console.Write("command: ");
                command = Console.ReadLine().Split();
                if (command[0] == "quit")
                {
                    break;
                }
                else if (command[0] == "add")
                {
                    double X = double.Parse(command[1]);
                    double Y = double.Parse(command[2]);
                    double add = X + Y;
                    Console.WriteLine($"Add: {X}+{Y} = {add}");
                }
                else if (command[0] == "div")
                {
                    double X = double.Parse(command[1]);
                    double Y = double.Parse(command[2]);
                    double div = X / Y;
                    Console.WriteLine($"Div: {X}/{Y} = {div}");
                }
                else if (command[0] == "help")
                {
                    WriteHelp();
                }
                else if (command[0] == "mul")
                {
                    double X = double.Parse(command[1]);
                    double Y = double.Parse(command[2]);
                    double mul = X * Y;
                    Console.WriteLine($"Mul: {X}*{Y} = {mul}");
                }
                else if (command[0] == "sub")
                {
                    double X = double.Parse(command[1]);
                    double Y = double.Parse(command[2]);
                    double sub = X - Y;
                    Console.WriteLine($"Sub: {X}-{Y} = {sub}");
                }
                else
                {
                    Console.WriteLine($"Unknown command '{command[0]}'");
                }
            }
            Console.WriteLine("Bye!");
        }

        private static void WriteHelp()
        {
            Console.WriteLine("Commands:");
            Console.WriteLine("add X Y   - add the numbers X and Y");
            Console.WriteLine("div X Y   - divide the numbers X and Y");
            Console.WriteLine("mul X Y   - multiply the numbers X and Y");
            Console.WriteLine("sub X Y   - subtract the numbers X and Y");
            Console.WriteLine("help      - write this help text");
            Console.WriteLine("quit      - quit the program");
        }
    }
}