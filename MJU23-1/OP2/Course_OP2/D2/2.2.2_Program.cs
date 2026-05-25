namespace ovn_2_2_2
{
    internal class Program
    {
        enum Månad
        {
            Januari, Februari, Mars, April, Maj, Juni,
            Juli, Augusti, September, Oktober, November, December
        }
        enum Typ { Kristen, Folklig, Sekulär }
        class Helg
        {
            string namn;
            Månad månad;
            int dag;
            Typ typ;
            string beskrivning;
            public Helg(string namn, Månad månad, int dag, Typ typ)
            {
                this.namn = namn;
                this.månad = månad;
                this.dag = dag;
                this.typ = typ;
            }
            public string Beskrivning
            {
                get { return beskrivning; }
                set { beskrivning = value; }
            }
            public override string ToString()
            {
                string resultat = "";
                resultat += $"Helgdag: {namn}\n";
                resultat += $"  Dag: {dag}:e {månad}\n";
                resultat += $"  Typ: {typ}\n";
                resultat += $"  Beskrivning: {beskrivning}\n";
                return resultat;
            }
        }
        static void Main(string[] args)
        {
            Helg trettondagen = new Helg("Trettondagen", typ: Typ.Kristen, månad: Månad.Januari, dag: 5);
            trettondagen.Beskrivning = "firas till åminnelse av de vise männens uppvaktande av Jesus-barnet";
            Console.WriteLine(trettondagen);
            Helg förstaMaj = new Helg("Första maj", typ: Typ.Sekulär, månad: Månad.Maj, dag: 1);
            förstaMaj.Beskrivning = "arbetarrörelsens internationella högtidsdag";
            Console.WriteLine(förstaMaj);
            Helg nationaldagen = new Helg("Nationaldagen", typ: Typ.Sekulär, månad: Månad.Juni, dag: 6);
            nationaldagen.Beskrivning = "Sveriges nationaldag";
            Console.WriteLine(nationaldagen);
            Helg lucia = new Helg("Lucia", typ: Typ.Folklig, månad: Månad.December, dag: 13);
            lucia.Beskrivning = "organiskt framväxt ur folkligt midvinterfirande";
            Console.WriteLine(lucia);
        }
    }
}
