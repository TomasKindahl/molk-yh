using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XErr4
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
                if (HHMMSS.Length > 3)
                {
                    Console.WriteLine("FEL!");
                }
                else if (HHMMSS.Length == 3)
                {
                    int HH, MM, SS;
                    if (HHMMSS[0].Length != 2 || !int.TryParse(HHMMSS[0], out HH))
                    {
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
                        bool OK = true;
                        if(HH < 0 || 23 < HH) {
                            Console.WriteLine($"timmen {HH} inte inom [0, 23]");
                            OK = false;
                        }
                        if (MM < 0 || 59 < MM)
                        {
                            Console.WriteLine($"minuten {MM} inte inom [0, 59]");
                            OK = false;
                        }
                        if (SS < 0 || 59 < SS)
                        {
                            Console.WriteLine($"sekunden {SS} inte inom [0, 59]");
                            OK = false;
                        }
                        if (OK) {
                            Console.WriteLine("godkänt");
                        }
                    }
                }
                else if (HHMMSS.Length == 2)
                {
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
                        bool OK = true;
                        if (HH < 0 || 23 < HH)
                        {
                            Console.WriteLine($"timmen {HH} inte inom [0, 23]");
                            OK = false;
                        }
                        if (MM < 0 || 59 < MM)
                        {
                            Console.WriteLine($"minuten {MM} inte inom [0, 59]");
                            OK = false;
                        }
                        if (OK)
                        {
                            Console.WriteLine("godkänt");
                        }
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
                        bool OK = true;
                        if (HH < 0 || 23 < HH)
                        {
                            Console.WriteLine($"timmen {HH} inte inom [0, 23]");
                            OK = false;
                        }
                        if (OK)
                        {
                            Console.WriteLine("godkänt");
                        }
                    }
                }
            }
        }
    }
}
