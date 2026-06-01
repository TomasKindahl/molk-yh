using System;

namespace Ovn2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange en veckodag: ");
            string weekDay = Console.ReadLine();
            int wdNum = 0;
            switch(weekDay)
            {
                case "måndag": wdNum = 1; break;
                case "tisdag": wdNum = 2; break;
                case "onsdag": wdNum = 3; break;
                case "torsdag": wdNum = 4; break;
                case "fredag": wdNum = 5; break;
                case "lördag": wdNum = 6; break;
                case "söndag": wdNum = 7; break;
                default: wdNum = -1; break;
            }
            if (wdNum == -1)
            {
                Console.WriteLine("Någon sådan dag finns inte!");
            }
            else
            {
                Console.WriteLine("Siffran för {0} är {1}.", weekDay, wdNum);
            }
        }
    }
}
