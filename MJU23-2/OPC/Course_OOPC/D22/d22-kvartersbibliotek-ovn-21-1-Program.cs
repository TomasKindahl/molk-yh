namespace d22_ovn_21_1_kvartersbibliotek
{
    internal class Program
    {
        class Låntagare
        {
            public string? namn, telefonnummer;
            public int bötesbelopp;
        }
        abstract class Skrift
        {
            public DateTime lånedatum;
            public Låntagare? låntagare;
        }
        class Bok : Skrift
        {
            public string? titel, bokhylla, författare, ISBN;
        }
        class Tidskrift : Skrift
        {
            public string? tidningshylla, tidskrift, ISSN, nummer;
        }

        // STATISKA DATA
        static List<Låntagare> låntagare = new List<Låntagare>();
        static List<Skrift> kvartersbibliotek = new List<Skrift>();
        static bool Registrera(Låntagare L, string namn, string telefonnummer)
        {
            // if(IsRegistered(L)) {
            // return false;
            // }
            // else {
            låntagare.Add(L);
            L.bötesbelopp = 0;
            return true;
            // }                        
        }
        static bool RegistreraLån(List<Skrift> list, Låntagare lånare)
        {
            // if(lånare.bötesbelopp > 100) return false;
            // foreach(Skrift S in list) : kolla att den finns i kvartersbibliotek
            // och sätt S.låntagare = lånare; och S.lånedatum = IDAG;
            return false;
        }
        static int Påminnelse()
        {
            int antal = 0;
            foreach (Skrift s in kvartersbibliotek)
            {
                switch (s)
                {
                    case Bok b:
                        // if (b.lånedatum för 2 veckor se'n eller mer)
                        // skickapåminnelsemail till b.låntagare
                        // b.låntagare.bötesbelopp += 10;
                        antal++;
                        break;
                    case Tidskrift t:
                        // if (t.lånedatum för 4 veckor se'n eller mer)
                        // skickapåminnelsemail till t.låntagare
                        // bt.låntagare.bötesbelopp += 10;
                        antal++;
                        break;
                }

            }
            return antal;
        }
        // static void BetalaSkulden(Låntaagare L) ...
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
