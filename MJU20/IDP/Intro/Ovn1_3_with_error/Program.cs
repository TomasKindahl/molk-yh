using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn1_3_with_error
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange cirkelns diameter: ");
            double diam;
            while(!double.TryParse(Console.ReadLine(), out diam))
            {
                Console.WriteLine("Du skrev inte en siffra!");
                Console.Write("Ange cirkelns diameter: ");
            }
            Console.WriteLine("En cirkel med diametern {0} har:", diam);
            Console.WriteLine("... omkretsen: {0}", Math.PI * diam);
            Console.WriteLine("... arean: {0}", Math.PI * diam*diam/4);
        }
    }
}
