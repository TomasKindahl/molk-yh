namespace dtp14_console_MyIO
{
    /// <summary>
    /// class <b>MyIO</b> - IO facilities for console programming
    /// </summary>
    public class MyIO
    {
        /// <summary>
        /// <b>Greet</b> - asks the user for a name and greets him/her
        /// </summary>
        static public void Greet()
        {
            Console.Write("What's your name? ");
            string? name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
        }
        /// <summary>
        /// <b>IntInput</b> - asks for an integer number by writing
        /// a prompt, keeps asking till the integer is valid
        /// </summary>
        /// <param name="prompt">the prompt string, defaults to "write an integer"</param>
        /// <returns>the integer provided</returns>
        static public int IntInput(string prompt = "write an integer")
        {
            do
            {
                Console.Write($"{prompt}: ");
                try
                {
                    return Int32.Parse(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Not an integer number, please try again!");
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine("Number too large or too small, please try again!");
                }
            } while (true);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyIO.Greet();
            int ival;
            Console.WriteLine("Enter values, exit by entering 0!");
            do
            {
                ival = MyIO.IntInput("enter value");

                Console.WriteLine($"ival = {ival}");
            }
            while (ival != 0);
        }
    }
}