// QUERY SYNTAX
IEnumerable<Nation> nations =
    from nation in ReadAllNations(filePath)
    orderby nation.Name, nation.Capital
    where 10000000 < nation.Population && nation.Population < 15000000
    select nation;

// METHOD SYNTAX
nations = ReadAllNations(filePath)
    .Where(n => 10000000 < n.Population && n.Population < 15000000).OrderBy(n => n.Name);