using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TidigasteOvningarna
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Tomas Kindahl";
            string street = "Skrivaregatan 11";
            string zip_city = "586 49 Linköping";

            Console.Write("Ange antal tecken från vänsterkanten: ");
            int left = int.Parse(Console.ReadLine());
            Console.Write("Ange antal tecken från översta kanten: ");
            int top = int.Parse(Console.ReadLine());

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            Console.SetCursorPosition(left, top);
            Console.WriteLine("********************");
            Console.SetCursorPosition(left, top+1);
            Console.WriteLine("* {0,-16} *", name);
            Console.SetCursorPosition(left, top+2);
            Console.WriteLine("* {0,-16} *", street);
            Console.SetCursorPosition(left, top+3);
            Console.WriteLine("* {0,-16} *", zip_city);
            Console.SetCursorPosition(left, top+4);
            Console.WriteLine("********************");
        }
    }
}
