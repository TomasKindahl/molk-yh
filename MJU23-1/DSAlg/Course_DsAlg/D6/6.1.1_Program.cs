// The Three Parts of a LINQ Query:
// 1. Data source.
int[] numbers = Enumerable.Range(0, 20).ToArray();

// 2. Query creation.
// numQuery is an IEnumerable<int>
var numQuery =
    from num in numbers
    where (num % 2) == 0 || (num % 3) == 0
    select num;

// 3. Query execution.
foreach (int num in numQuery)
{
    Console.Write("{0,1} ", num);
}
Console.WriteLine();
