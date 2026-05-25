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
                    // TODO: refaktorera så att dublettkod mellan operatorer försvinner:
                    // FIXME: System.IndexOutOfRangeException om index 1 eller 2 inte finns
                    double Y;
                    double X;
                    try
                    {
                        X = double.Parse(command[1]);
                        Y = double.Parse(command[2]);
                    }
                    catch (System.IndexOutOfRangeException)
                    {
                        Console.WriteLine("Too few arguments for function add!");
                        continue;
                    }
                    catch (System.FormatException)
                    {

                        if(command.Length < 3)
                            Console.WriteLine($"'{command[1]}' is not a number!");
                        else
                            Console.WriteLine($"One of '{command[1]}' or '{command[2]}' is not a number!");
                        continue;
                    }
                    double add = X + Y;
                    Console.WriteLine($"Add: {X}+{Y} = {add}");
                }
                else if (command[0] == "div")
                {
                    // FIXME: System.IndexOutOfRangeException om index 1 eller 2 inte finns
                    double X = double.Parse(command[1]); // FIXME: System.FormatException om command[1] inte innehåller siffra
                    double Y = double.Parse(command[2]); // FIXME: System.FormatException om command[2] inte innehåller siffra
                    double div = X / Y;
                    Console.WriteLine($"Div: {X}/{Y} = {div}");
                }
                else if (command[0] == "help")
                {
                    WriteHelp();
                }
                else if (command[0] == "mul")
                {
                    // FIXME: System.IndexOutOfRangeException om index 1 eller 2 inte finns
                    double X = double.Parse(command[1]); // FIXME: System.FormatException om command[1] inte innehåller siffra
                    double Y = double.Parse(command[2]); // FIXME: System.FormatException om command[2] inte innehåller siffra
                    double mul = X * Y;
                    Console.WriteLine($"Mul: {X}*{Y} = {mul}");
                }
                else if (command[0] == "sub")
                {
                    // FIXME: System.IndexOutOfRangeException om index 1 eller 2 inte finns
                    double X = double.Parse(command[1]); // FIXME: System.FormatException om command[1] inte innehåller siffra
                    double Y = double.Parse(command[2]); // FIXME: System.FormatException om command[2] inte innehåller siffra
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