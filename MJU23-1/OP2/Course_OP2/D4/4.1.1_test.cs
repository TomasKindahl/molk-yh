MyStack<string> ms = new MyStack<string>();
Console.WriteLine("Initial stack size: " + ms.Count);
foreach (string s in new string[] { "doff", "mxyzptlk", "dole", "ole" })
    ms.Push(s);
Console.WriteLine(ms.Count);
Console.WriteLine("Stack size after adding four items: " + ms.Count);
if (ms.Contains("mxyzptlk")) { Console.WriteLine("ms contains mxyzptlk!"); }
if (ms.Remove("mxyzptlk")) { Console.WriteLine("mxyzptlk removed!"); }
Console.WriteLine("Stack size after removing mxyzptlk: " + ms.Count);
Console.WriteLine("Emptying stack:");
while (ms.Count > 0)
{
    string s = ms.Pop();
    Console.WriteLine("  "+s);
}
foreach (string s in new string[] { "hokus", "pokus" })
    ms.Push(s);
ms.Clear();
Console.WriteLine("Stack size after clearing: "+ms.Count);