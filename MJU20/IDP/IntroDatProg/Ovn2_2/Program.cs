using System;

namespace Ovn2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange hastighet: ");
            double speed = double.Parse(Console.ReadLine());
            if (speed <= 30)
            {
                Console.WriteLine("Du kör lagligt!");
            }
            if (30 < speed && speed <= 40)
            {
                Console.WriteLine("Du har kört för fort och fått böta 2000 SEK!");
            }
            if (40 < speed && speed <= 50)
            {
                Console.WriteLine("Du har kört för fort och fått böta 3000 SEK!");
            }
            if (50 < speed)
            {
                Console.WriteLine("Du har kört för fort och fått böta 5000 SEK!");
                Console.Write("Dessutom blir du av med körkortet i ");
                double howMuchTooFast = speed - 30;
                if(15 < howMuchTooFast && howMuchTooFast <= 20)
                {
                    Console.Write("1"); 
                }
                if (20 < howMuchTooFast && howMuchTooFast <= 30)
                {
                    Console.Write("2");
                }
                if (30 < howMuchTooFast && howMuchTooFast <= 40)
                {
                    Console.Write("3");
                }
                if (40 < howMuchTooFast && howMuchTooFast <= 50)
                {
                    Console.Write("4");
                }
                if (50 < howMuchTooFast && howMuchTooFast <= 60)
                {
                    Console.Write("5");
                }
                if (60 < howMuchTooFast && howMuchTooFast <= 70)
                {
                    Console.Write("6");
                }
                if (70 < howMuchTooFast)
                {
                    Console.Write("massor");
                }
                Console.WriteLine(" månader.");
            }
        }
    }
}
