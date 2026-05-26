using System.Xml;

namespace D14_ovn_1_1_uppg_8t15
{
    internal class Program
    {
        // Uppg 8:
        class Land
        {
            public string namn, styrestyp, huvudstad;
            public int invånarantal;
            // Uppg 10:
            public void Print()
            {
                Console.WriteLine($"Land: {namn}");
                Console.WriteLine($"  styrestyp: {styrestyp}");
                Console.WriteLine($"  huvudstad: {huvudstad}");
                Console.WriteLine($"  invånarantal: {invånarantal}");
            }
        }
        static void Main(string[] args)
        {
            // Uppg 9:
            Land sverige = new Land()
            {
                namn = "Sverige",
                styrestyp = "monarki",
                huvudstad = "Stockholm",
                invånarantal = 10512820
            };
            Land tyskland = new Land()
            {
                namn = "Tyskland",
                styrestyp = "republik",
                huvudstad = "Berlin",
                invånarantal = 83783902
            };
            Land sanMarino = new Land()
            {
                namn = "San Marino",
                styrestyp = "republik",
                huvudstad = "San Marino",
                invånarantal = 33600
            };
            // Uppg 10:
            /* sverige.Print();
               tyskland.Print();
               sanMarino.Print(); */

            // Uppg 11:
            Land[] länder = new Land[7]
            {
                sverige,
                tyskland,
                sanMarino,
                new Land()
                {
                    namn = "Danmark",
                    styrestyp = "monarki",
                    huvudstad = "Köpenhamn",
                    invånarantal = 5928364
                },
                new Land()
                {
                    namn = "Italien",
                    styrestyp = "republik",
                    huvudstad = "Rom",
                    invånarantal = 58853482
                },
                new Land()
                {
                    namn = "Tjekien",
                    styrestyp = "republik",
                    huvudstad = "Prag",
                    invånarantal = 10551219
                },
                new Land()
                {
                    namn = "Rumänien",
                    styrestyp = "republik",
                    huvudstad = "Bukarest",
                    invånarantal = 19760314
                },
            };
            // Uppg 12:
            foreach (Land L in länder)
            {
                L.Print();
            }
            // Uppg 13:
            Console.WriteLine("==== Lista alla republiker ====");
            for (int i = 0; i < länder.Length; i++)
            {
                if (länder[i].styrestyp == "republik")
                    Console.WriteLine($"{i}: {länder[i].namn}" /* Uppg 14! */);
            }
            // Uppg 15:
            int min = -1;
            int max = -1;
            for (int i = 0; i < länder.Length; i++)
            {
                if (länder[i].styrestyp == "republik")
                {
                    if (min == -1)
                    {
                        min = i;
                        max = i;
                    }
                    else
                    {
                        if (länder[i].invånarantal < länder[min].invånarantal)
                            min = i;
                        if (länder[i].invånarantal > länder[max].invånarantal)
                            max = i;
                    }
                }
            }
            // Console.WriteLine($"{min} vs. {max}");
            Console.WriteLine("==== Republik med minsta invånarantal ====");
            länder[min].Print();
            Console.WriteLine("==== Republik med största invånarantal ====");
            länder[max].Print();
        }
    }
}