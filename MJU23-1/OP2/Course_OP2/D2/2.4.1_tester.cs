object[] personer = new Object[]
{
    new Person("331215-2350", "Arne", "Svensson"),
    new Person("291211-2342", "Berith", "Qvist"),
    new Organisation("212000-0142", "Arboreal", "AB"),
    new Organisation("212000-1355", "Svenne", "HB")
};
foreach(object entitet in personer)
{
    if(entitet is Person person)
        Console.WriteLine($"{person.Bokföringsnummer}: {person}");
    else if(entitet is Organisation organisation)
        Console.WriteLine($"{organisation.Bokföringsnummer}: {organisation}");
}