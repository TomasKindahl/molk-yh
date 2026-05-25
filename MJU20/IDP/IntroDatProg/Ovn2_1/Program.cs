using System;

namespace Ovn2_1
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
                Console.WriteLine("Dessutom blir du av med körkortet!");
            }
        }
    }
}

