using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNoteDeLuxe
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            List<string> wares = new List<string>();
            Console.WriteLine("Hej och välkommen till notan!\nSkriv 'sluta' för att sluta!");
            do
            {
                Console.Write("> ");
                command = Console.ReadLine();
                if (command == "ny")
                {
                    Console.Write("Ange vara: ");
                    string ware = Console.ReadLine();
                    Console.WriteLine($"{ware} tillagt!");
                    wares.Add(ware);
                }
                else
                {
                    Console.WriteLine($"command is {command}"); // Testutskrift
                }
            } while (command != "sluta");
        }
    }
}
