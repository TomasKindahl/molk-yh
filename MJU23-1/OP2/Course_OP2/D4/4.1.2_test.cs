MyStack<string> ms = new MyStack<string>();
foreach (string s in new string[] { "doff", "mxyzptlk", "dole", "ole" })
    ms.Push(s);
for (int i = 0; i < ms.Count; i++)
    Console.WriteLine($"{i}: {ms.GetAt(i)}");
ms.RemoveAt(1);
for (int i = 0; i < ms.Count; i++)
    Console.WriteLine($"{i}: {ms.GetAt(i)}");
