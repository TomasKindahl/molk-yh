using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Registreringsskylt
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            Regex regskylt = new Regex(
                @"\b[A-HJ-PR-UX-Z]{3}?[0-9]{2}?[0-9A-HJ-NPR-UX-Z]{1}?\b", // <===== kan det funka??
                RegexOptions.Compiled);
            do
            {
                Console.Write("Skriv ett regnr: ");
                command = Console.ReadLine();
                if(regskylt.IsMatch(command))
                {
                    Console.WriteLine("{0} är ett registreringsnummer", command);
                }
                else
                {
                    Console.WriteLine("{0} är INTE ett registreringsnummer", command);
                }
            } while (command != "quit");
        }
    }
}
