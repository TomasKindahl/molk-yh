int alternative = 1;

if(alternative == 1) {

// QUERY SYNTAX:
IEnumerable<Nation> nations =
    from nation in ReadAllNations(filePath)
    orderby nation.Name
    where nation.Continent == "Europe"
       && nation.Population > 10000000
    select nation;

// METHOD SYNTAX:
nations = ReadAllNations(filePath).OrderBy(n => n.Name)
    .Where(n => n.Continent == "Europe" && n.Population > 10000000);

}
else if(alternative == 2) {

// QUERY SYNTAX:
IEnumerable<Nation> nations =
    from nation in ReadAllNations(filePath)
    where nation.Continent == "Europe"
       && nation.Population > 10000000
    orderby nation.Name
    select nation;

// METHOD SYNTAX:
nations = ReadAllNations(filePath)
    .Where(n => n.Continent == "Europe" && n.Population > 10000000).OrderBy(n => n.Name);

}
