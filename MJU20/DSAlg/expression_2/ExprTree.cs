using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using expression_2;
using varnamespace;

namespace exprtree
{
    public class ExprTree
    {
        // TODO:
        // Not yet implemented:
        string op;
        ExprTree left, right;
        public ExprTree(string[] list, int prio)
        {
            if (list.Length == 1)
            {
                // How shall we do if list.Length == 1, that is: if the expression is just a number
                //    or a variable?
                op = list[0];
            }
            else
            {
                int ix = -1;
                while (ix == -1)
                {
                    switch (prio)
                    {
                        case 0:
                            // Additive operators: +, -
                            ix = Array.FindLastIndex(list, w => w == "+" || w == "-");
                            break;

                        case 1:
                            // Multiplicative operators: *, /
                            ix = Array.FindLastIndex(list, w => w == "*" || w == "/");
                            break;

                        default:
                            break;

                    }
                    if (ix == -1) prio++;
                    // Console.WriteLine($"track: {ix} ~ {list.Length}");
                }
                // How shall we do when ix == -1, that is: we didn't find an operator of priority prio?
                // Console.WriteLine($"track: {ix} ~ {list.Length}");

                string[] leftList = list[0..ix];
                string opStr = list[ix];
                string[] rightList = list[(ix + 1)..];
                // TODO:
                // set operator string here!
                // create a new ExprTree for the leftList
                // then create a new ExprTree for the rightList

                // Test printout code:
                /*
                Console.WriteLine($"track: {list[ix]}:");
                Console.Write($"  track: ");
                for (int i = 0; i < leftList.Length; i++) Console.Write($"{leftList[i]}");
                Console.WriteLine();
                Console.Write($"  track: ");
                for (int i = 0; i < rightList.Length; i++) Console.Write($"{rightList[i]}");
                Console.WriteLine();
                */

                op = opStr;
                left = new ExprTree(leftList, prio);
                right = new ExprTree(rightList, prio);
            }
        }
        public void Print(int indent = 0)
        {
            string ind = new string(' ', indent);
            if (left == null && right == null)
                Console.Write($"{op}");
            else
            {
                Console.Write($"({op} ");
                if (left != null) left.Print(indent + 2);
                Console.Write($" ");
                if (right != null) right.Print(indent + 2);
                Console.Write(")");
                if (indent == 0) Console.WriteLine();
            }
        }
        public int Compute(VarNameSpace vars)
        {
            if (Scan.IsVar(op))
            {
                return vars.Lookup(op);
            }
            else if (Scan.IsNum(op))
            {
                return Convert.ToInt32(op);
            }
            else
            {
                switch (op)
                {
                    case "+": return left.Compute(vars) + right.Compute(vars);
                    case "-": return left.Compute(vars) - right.Compute(vars);
                    case "*": return left.Compute(vars) * right.Compute(vars);
                    case "/": return left.Compute(vars) / right.Compute(vars);
                    default: throw new NotImplementedException($"operator not yet implemented {op}");
                }
            }
        }
        public List<string> Compile(int level = 0)
        {
            // NYI!
            return new List<string>(0); // Stub code
        }
    }
}
