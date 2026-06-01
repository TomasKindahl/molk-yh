using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XErr3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Mata in ett klockslag: ");
                string entry = Console.ReadLine();
                string[] HHMMSS = entry.Split(':');
                if (HHMMSS.Length > 3) {
                    Console.WriteLine("FEL!");
                }
                else if (HHMMSS.Length == 3)
                {
                    int HH, MM, SS;
                    if (HHMMSS[0].Length != 2 || !int.TryParse(HHMMSS[0], out HH)) {
                        Console.WriteLine("FEL på timmen!");
                    }
                    else if (HHMMSS[1].Length != 2 || !int.TryParse(HHMMSS[1], out MM))
                    {
                        Console.WriteLine("FEL på minuterna!");
                    }
                    else if (HHMMSS[2].Length != 2 || !int.TryParse(HHMMSS[2], out SS))
                    {
                        Console.WriteLine("FEL på sekunderna!");
                    }
                    else
                    {
                        Console.WriteLine("godkänt");
                    }
                }
                else if(HHMMSS.Length == 2) {
                    int HH, MM;
                    if (HHMMSS[0].Length != 2 || !int.TryParse(HHMMSS[0], out HH))
                    {
                        Console.WriteLine("FEL på timmen!");
                    }
                    else if (HHMMSS[1].Length != 2 || !int.TryParse(HHMMSS[1], out MM))
                    {
                        Console.WriteLine("FEL på minuterna!");
                    }
                    else
                    {
                        Console.WriteLine("godkänt");
                    }
                }
                else if (HHMMSS.Length == 1)
                {
                    int HH;
                    if (HHMMSS[0].Length != 2 || !int.TryParse(HHMMSS[0], out HH))
                    {
                        Console.WriteLine("FEL på timmen!");
                    }
                    else
                    {
                        Console.WriteLine("godkänt");
                    }
                }
            }
        }
    }
}
