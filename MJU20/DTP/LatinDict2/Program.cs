using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinDict2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dict = new string[7]
            {
                "caput-huvud", "videre-se", "pater-far, pappa",
                "arbor-träd", "luna-måne", "movere-flytta",
                "urbs-stad"
            };

            Console.WriteLine("Välkommen till den latinska ordlistan!");
            Console.WriteLine("Skriv 'sluta' om du vill sluta!");
            string command;
            do
            {
                Console.Write("> ");
                command = Console.ReadLine();
                if (command == "sluta")
                {
                    Console.WriteLine("Hej då!");
                }
                else if (command == "visa")
                {
                    Console.WriteLine("Ordlistan:");
                    for (int i = 0; i < dict.Length; i++)
                    {
                        Console.WriteLine("{0}", dict[i]);
                    }
                }
                else if (command == "svenska")
                {
                    Console.Write("Vilket latinskt ord vill du ha översatt: ");
                    string entry = Console.ReadLine();
                    for (int i = 0; i < dict.Length; i++)
                    {
                        string[] words = dict[i].Split('-');
                        // "caput-huvud" words[0] == "caput" , words[1] = "huvud"
                        if (entry == words[0])
                        {
                            Console.WriteLine("'{0}' är '{1}' på svenska", words[0], words[1]);
                        }
                    }
                }
                else if (command == "sort")
                {
                    for (int j = 0; j < dict.Length; j++)
                    {
                        string smallest = dict[j];
                        int smallIndex = j;
                        for (int i = j+1; i < dict.Length; i++)
                        {
                            int comp = String.Compare(smallest, dict[i]);
                            if (comp > 0)
                            {
                                smallest = dict[i];
                                smallIndex = i;
                            }
                        }
                        string save = dict[j];
                        dict[j] = dict[smallIndex];
                        dict[smallIndex] = save;
                    }
                    Console.WriteLine("Listan är sorterad");
                }
                else
                {
                    Console.WriteLine($"Läst kommando: {command}");
                }
            } while (command != "sluta");
        }
    }
}
