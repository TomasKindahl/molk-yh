namespace mju23h_dtp_genrep_FAS4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string runmode = "Select runmode!";
            while (true)
            {
                Console.WriteLine("---- " + runmode + " ----");
                if (runmode == "Select runmode!")
                {
                    Console.WriteLine("Select mode:");
                    Console.WriteLine("1 = check if IsPalindrom");
                    Console.WriteLine("2 = Reverse string");
                    Console.WriteLine("3 = Caesar cipher");
                    Console.WriteLine("4 = Vigenere cipher");
                    Console.WriteLine("5 = quit");
                    Console.Write("mode: ");
                    int mnum;
                    try
                    {
                        mnum = int.Parse(Console.ReadLine());
                        if (mnum == 1)
                            runmode = "check if IsPalindrom";
                        else if (mnum == 2)
                            runmode = "Reverse string";
                        else if (mnum == 3)
                            runmode = "Caesar cipher";
                        else if (mnum == 4)
                            runmode = "Vigenere cipher";
                        else if (mnum == 5)
                        {
                            Console.WriteLine("Bye!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Choose one of 1, 2, 3, 4, 5!");
                        }
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Not a number!");
                        Console.WriteLine("Choose one of 1, 2, 3, 4, 5!");
                    }
                }
                else if (runmode == "check if IsPalindrom")
                {
                    Console.WriteLine("Write 'quit' to quit!");
                    Console.Write("string: ");
                    string S = Console.ReadLine();
                    if (S == "quit") { runmode = "Select runmode!"; continue; }
                    Console.WriteLine($"ciphertext: {MyStrLib.IsPalindrom(S)}");
                }
                else if (runmode == "Reverse string")
                {
                    Console.WriteLine("Write 'quit' to quit!");
                    Console.Write("string: ");
                    string S = Console.ReadLine();
                    if (S == "quit") { runmode = "Select runmode!"; continue; }
                    Console.WriteLine($"ciphertext: {MyStrLib.Reverse(S)}");
                }
                else if (runmode == "Caesar cipher")
                {
                    Console.WriteLine("Write 'quit' to quit!");
                    Console.Write("string: ");
                    string S = Console.ReadLine();
                    if (S == "quit") { runmode = "Select runmode!"; continue; }
                    Console.Write("shift: ");
                    int shift;
                    try
                    {
                        shift = int.Parse(Console.ReadLine());
                        Console.WriteLine($"ciphertext: {MyStrLib.Caesar(S, shift)}");
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Write a number!");
                    }
                }
                else if (runmode == "Vigenere cipher")
                {
                    Console.WriteLine("Write 'quit' to quit!");
                    Console.Write("key: ");
                    string key = Console.ReadLine();
                    if (key == "quit") { runmode = "Select runmode!"; continue; }
                    Console.Write("plaintext: ");
                    string plaintext = Console.ReadLine();
                    if (plaintext == "quit") { runmode = "Select runmode!"; continue; }
                    Console.WriteLine($"ciphertext: {MyStrLib.Vigenere(plaintext, key)}");
                }
            }
        }
    }
}