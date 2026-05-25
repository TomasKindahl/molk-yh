namespace ovn_2_4_1
{
    internal class Program
    {
        interface JuridiskPerson
        {
            public string Bokföringsnummer { get; }
            public string FulltNamn { get; }
        }
        class Person : JuridiskPerson
        {
            string personnummer;
            string förnamn;
            string efternamn;
            public Person(string personnummer, string förnamn, string efternamn)
            {
                this.personnummer = personnummer;
                this.förnamn = förnamn;
                this.efternamn = efternamn;
            }
            public string Bokföringsnummer { get => personnummer; }
            public string FulltNamn { get => ToString(); }
            public override string ToString() => $"{förnamn} {efternamn}";
        }
        class Organisation : JuridiskPerson
        {
            string organisationsnummer;
            string företagsnamn;
            string bolagsform;
            public Organisation(string organisationsnummer, string företagsnamn, string bolagsform)
            {
                this.organisationsnummer = organisationsnummer;
                this.företagsnamn = företagsnamn;
                this.bolagsform = bolagsform;
            }
            public string Bokföringsnummer { get => organisationsnummer; }
            public string FulltNamn { get => ToString(); }
            public override string ToString() => $"{företagsnamn} {bolagsform}";
        }
        static void Main(string[] args)
        {
            JuridiskPerson[] personer = new JuridiskPerson[]
            {
                new Person("331215-2350", "Arne", "Svensson"),
                new Person("291211-2342", "Berith", "Qvist"),
                new Organisation("212000-0142", "Arboreal", "AB"),
                new Organisation("212000-1355", "Svenne", "HB")
            };
            foreach (JuridiskPerson entitet in personer)
            {
                Console.WriteLine($"{entitet.Bokföringsnummer}: {entitet}");
            }
        }
    }
}
