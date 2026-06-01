using System;

namespace Ovn2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange ett positivt heltal: ");
            int posInt = int.Parse(Console.ReadLine());
            if (posInt < 0)
            {
                Console.WriteLine("Valfritt meddelande.");
            }
            else
            {
                if (posInt % 2 == 0)
                {
                    Console.WriteLine("Ditt tal är jämnt.");
                }
                else
                {
                    Console.WriteLine("Ditt tal är udda.");
                }
            }
        }
    }
}
