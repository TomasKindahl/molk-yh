using System.Collections; // <= DENNA RAD ÄNDRADES!

namespace Ovn_2_2_1
{
    internal class Program
    {
        class Bäng
        {
            public int Knas;
        }
        static void Main(string[] args)
        {
            ArrayList arl = new ArrayList(); // <= DENNA RAD ÄNDRADES!
            arl.Add(1);
            arl.Add("Nisse");
            arl.Add(new Bäng() { Knas = 77 });
            foreach (object a in arl)
            {
                switch (a)
                {
                    case int i:
                        Console.WriteLine($"int: {i}");
                        break;
                    case string s:
                        Console.WriteLine($"string: {s}");
                        break;
                    case Bäng b:
                        Console.WriteLine($"Bäng: {b}");
                        break;
                }
            }
        }
    }
}