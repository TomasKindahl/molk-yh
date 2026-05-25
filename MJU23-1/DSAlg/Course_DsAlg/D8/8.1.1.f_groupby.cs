bool explicite = false;
 
if(!explicite) {

// QUERY SYNTAX med fusk med "typen" var:
var nationgroup =
    from nation in ReadAllNations(filePath)
    where 10000000 < nation.Population && nation.Population < 15000000
    orderby nation.Name
    group nation by nation.Continent;

Console.WriteLine("  name                      population   capital              ");
Console.WriteLine("============================================================");
foreach (var group in nationgroup)
{
    Console.WriteLine(group.Key.ToUpper() + ":");
    foreach (Nation nation in group)
    {
        Console.WriteLine($"  {nation.Name,-25} {nation.Population,10}   {nation.Capital,-25}");
    }
}

} else {

// QUERY SYNTAX utan fusk!
// OBS: krystad datatyp! Man förstår varför folk försöker fuska:
IEnumerable<IGrouping<string, Nation>> nationgroup = 
    from nation in ReadAllNations(filePath)
    where 10000000 < nation.Population && nation.Population < 15000000
    orderby nation.Name
    group nation by nation.Continent;

Console.WriteLine("  name                      population   capital              ");
Console.WriteLine("============================================================");
foreach (IGrouping<string, Nation> group in nationgroup) // Krystad datatyp här också!
{
    Console.WriteLine(group.Key.ToUpper()+":"); // Vi kommer åt kontinentens namn genom property 'Key'
    foreach (Nation nation in group) // Här loopar vi genom nationerna
    {
        Console.WriteLine($"  {nation.Name,-25} {nation.Population,10}   {nation.Capital,-25}");
    }
}
Console.WriteLine("============================================================");

}