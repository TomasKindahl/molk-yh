using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skriv ut talen 1, 2, 3 ... upp t.o.m. 20 på en rad var:
            int i; // Måste ha en räknevariabel som vi skriver ut värdet på
            for(i = 0; i <= 20; i++) 
                // <== For-loop, i initieras med 0, i mindre än och lika med 20, i ökas med 1
            {
                Console.WriteLine(i); // Skriv ut i
            }
        }
    }
}
