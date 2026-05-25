class Person
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
    public override string ToString() => $"{förnamn} {efternamn}";
}
class Organisation
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
    public override string ToString() => $"{företagsnamn} {bolagsform}";
}