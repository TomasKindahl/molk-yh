using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinDict
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            string[] dict = new string[] {
                "caput-huvud", "videre-se", "pater-far, pappa", "arbor-träd",
                "luna-måne", "movere-flytta", "urbs-stad"
            };
            Console.WriteLine("Välkommen till ordlistan!");
            Console.WriteLine("Skriv 'sluta' för att sluta!");
            do
            {
                Console.Write("> ");
                command = Console.ReadLine();
                if (command == "visa")
                {
                    for (int i = 0; i < dict.Length; i++)
                    {
                        Console.WriteLine("{0}", dict[i]);
                    }
                }
                else if (command == "svenska")
                {
                    Console.Write("Vilket ord vill du ha översatt: ");
                    string lookUp = Console.ReadLine();
                    for (int i = 0; i < dict.Length; i++)
                    {
                        string[] word = dict[i].Split('-');
                        if (word[0] == lookUp)
                        {
                            Console.WriteLine("'{0}' är '{1}' på svenska", 
                                word[0], word[1]);
                        }
                    }
                }
                else if (command == "sluta")
                {
                    Console.WriteLine("Adjö!");
                }
                else
                {
                    Console.WriteLine("Okänt kommando: {0}", command);
                }
            } while (command != "sluta");
        }
    }
}
