// Fix to table writing:
Console.WriteLine("name                      population   capital");
Console.WriteLine("--------------------------------------------------------------");
foreach (Nation nation in nations)
{
    Console.WriteLine($"{nation.Name,-25} {nation.Population,10}   {nation.Capital,-25}");
}
Console.WriteLine("--------------------------------------------------------------");

// Fix to class Nation
class Nation
{
    [Index(0)]
    public string Name { get; set; }
    [Index(1)]
    public long Population { get; set; }
    [Index(2)]
    public string Continent { get; set; }
    [Index(3)]
    public string Capital { get; set; }
}
