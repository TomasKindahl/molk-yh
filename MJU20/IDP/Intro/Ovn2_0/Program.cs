using System;

namespace Ovn2_0
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
            else
            {
                if (speed <= 40)
                {
                    Console.WriteLine("Du har kört för fort och fått böta 2000 SEK!");
                }
                else
                {
                    if (speed <= 50)
                    {
                        Console.WriteLine("Du har kört för fort och fått böta 3000 SEK!");
                    }
                    else
                    {
                        Console.WriteLine("Du har kört för fort och fått böta 5000 SEK!");
                        Console.WriteLine("Dessutom blir du av med körkortet!");
                    }
                }
            }
        }
    }
}
