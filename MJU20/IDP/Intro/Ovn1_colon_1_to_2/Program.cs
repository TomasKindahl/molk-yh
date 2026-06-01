using System;

namespace Ovn1_colon_1_to_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Övning 1:0:
            string name    = "Tomas Kindahl";
            string address = "Skrivaregatan 11";
            string zipCode = "58649 Linköping";
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            // Övning 0:
            Console.WriteLine(name);
            Console.WriteLine(address);
            Console.WriteLine(zipCode);
            Console.WriteLine();
            // Övning 1:0:
            Console.WriteLine($"******************");
            Console.WriteLine($"*{name,-16}*");
            Console.WriteLine($"*{address,-16}*");
            Console.WriteLine($"*{zipCode,-16}*");
            Console.WriteLine($"******************");
            Console.ReadKey();
            Console.Clear();
            // Övning 1:1:
            Console.SetCursorPosition(15, 15);
            Console.WriteLine($"******************");
            Console.SetCursorPosition(15, 16);
            Console.WriteLine($"*{name,-16}*");
            Console.SetCursorPosition(15, 17);
            Console.WriteLine($"*{address,-16}*");
            Console.SetCursorPosition(15, 18);
            Console.WriteLine($"*{zipCode,-16}*");
            Console.SetCursorPosition(15, 19);
            Console.WriteLine($"******************");
            Console.ReadKey();
            Console.Clear();
            // Övning 1:2:
            Console.Write("Ange kolumn: ");
            int column = Int32.Parse(Console.ReadLine());
            Console.Write("Ange rad:    ");
            int row    = Int32.Parse(Console.ReadLine());
            Console.SetCursorPosition(column, row+0);
            Console.WriteLine($"******************");
            Console.SetCursorPosition(column, row+1);
            Console.WriteLine($"*{name,-16}*");
            Console.SetCursorPosition(column, row+2);
            Console.WriteLine($"*{address,-16}*");
            Console.SetCursorPosition(column, row+3);
            Console.WriteLine($"*{zipCode,-16}*");
            Console.SetCursorPosition(column, row+4);
            Console.WriteLine($"******************");
        }
    }
}
