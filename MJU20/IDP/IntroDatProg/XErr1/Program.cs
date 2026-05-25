using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XErr1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange cirkelns diameter: ");
            double diam;
            while(!double.TryParse(Console.ReadLine(), out diam))
            {
                Console.WriteLine("Felaktig inmatning!");
                Console.Write("Ange cirkelns diameter: ");
            }
            Console.WriteLine("\nEn cirkel med diametern 10,5 har:");
            Console.WriteLine("... omkrets: {0}", Math.PI * diam);
            Console.WriteLine("... area: {0}", Math.PI * diam * diam / 4);
        }
    }
}
