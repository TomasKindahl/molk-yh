bool IsPrime(int n)
{
    if (n < 0) return IsPrime(-n);
    if (n < 2) return false;
    for (int i = 2; i*i <= n; i++) { 
        if (n % i == 0) return false;
    }
    return true;
}

// The Three Parts of a LINQ Query:
// 1. Data source.
int[] numbers = Enumerable.Range(0, 100).ToArray();

// 2. Query creation.
// numQuery is an IEnumerable<int>
var numQuery =
    from num in numbers
    where IsPrime(num)
    select num;

// 3. Query execution.
foreach (int num in numQuery)
{
    Console.Write("{0,1} ", num);
}
Console.WriteLine();