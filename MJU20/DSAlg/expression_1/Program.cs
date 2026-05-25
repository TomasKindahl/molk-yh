using System;
using varnamespace;
using exprtree;

namespace expression_1
{
    class Program
    {
        static void Main(string[] args)
        {
            VarNameSpace vars = new VarNameSpace();
            Console.WriteLine("Welcome to the interpreter!");
            string quitCmd = ":q", listCmd = ":l";
            Console.WriteLine($"Write '{quitCmd}' to quit!");
            string cmd;
            do
            {
                Console.Write("> ");
                cmd = Console.ReadLine();
                if (cmd == quitCmd)
                {
                    Console.WriteLine("Goodbye!");
                }
                else if (cmd == listCmd)
                {
                    Console.WriteLine("Variables:");
                    // Not yet implemented!
                    vars.Print();
                }
                else
                {
                    string[] L = Scan.Tokenize(cmd);
                    if (L.Length == 3 && Scan.IsVar(L[0]) && Scan.Is(L[1], "=") && Scan.IsNum(L[2]))
                    {
                        int val = int.Parse(L[2]);
                        string var = L[0];
                        Console.WriteLine($"assign {val} to var {var}");
                        vars.Assign(var, val);
                    }
                    else if (L.Length == 1 && Scan.IsVar(L[0]))
                    {
                        string var = L[0];
                        if (vars.IsSet(var))
                        {
                            int val = vars.Lookup(var);
                            Console.WriteLine($"{var} = {val}");
                        }
                        else
                        {
                            Console.WriteLine($"{var} is not set!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Syntax error or not yet implemented:");
                        for (int i = 0; i < L.Length; i++)
                        {
                            Console.WriteLine($"  {i}: {L[i]}");
                        }
                        ExprTree ET = new ExprTree(L, 0);
                        ET.Print();
                        Console.WriteLine($"res = {ET.Compute()}");
                    }
                }
            } while (cmd != quitCmd);
        }
    }
}
