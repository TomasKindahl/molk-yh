Console.WriteLine("name          population   capital         continent");
Console.WriteLine("----------------------------------------------------------------------------------");
foreach (Nation nation in nations)
{
    Console.WriteLine($"{nation.Name,-25} {nation.Population,10}   {nation.Capital,-25}   {nation.Continent,-20}");
}
Console.WriteLine("----------------------------------------------------------------------------------");
