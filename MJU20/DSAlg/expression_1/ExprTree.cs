using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exprtree
{
    public class ExprTree
    {
        // TODO:
        // Not yet implemented:
        // a string for the operator
        // a left for the left part of the subdivided expression
        // a right for the right part of the subdivided expression
        public ExprTree(string[] list, int prio)
        {
            // How shall we do if list.Length == 1, that is: if the expression is just a number
            //    or a variable?

            int ix = 0;
            if (prio == 0)
            { // Additive operators: +, -
                ix = Array.FindLastIndex(list, w => w == "+" || w == "-");
            }
            else if (prio == 1)
            { // Multiplicative operators: *, /
                ix = Array.FindLastIndex(list, w => w == "*" || w == "/");
            }
            // How shall we do when ix == -1, that is: we didn't find an operator of priority prio?
            Console.WriteLine($"track: {ix} ~ {list.Length}");

            string[] leftList = list[0..ix];
            string[] rightList = list[(ix + 1)..];
            // TODO:
            // set operator string here!
            // create a new ExprTree for the leftList
            // then create a new ExprTree for the rightList

            // Test printout code:
            Console.WriteLine($"track: {list[ix]}:");
            Console.Write($"  track: ");
            for (int i = 0; i < leftList.Length; i++) Console.Write($"{leftList[i]}");
            Console.WriteLine();
            Console.Write($"  track: ");
            for (int i = 0; i < rightList.Length; i++) Console.Write($"{rightList[i]}");
            Console.WriteLine();
        }
        public void Print()
        {
            // NYI!
        }
        public int Compute()
        {
            // NYI!
            return -666;
        }
    }
}
