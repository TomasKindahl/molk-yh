using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vartree
{
    public class VarTree
    {
        VarTree left, right;
        string varName;
        public int value;
        public VarTree(string name, int val)
        {
            varName = name; value = val;
        }
        public VarTree Insert(string name, int val)
        {
            int comp = String.Compare(name, varName);
            if (comp < 0)
            {
                if (left == null)
                    left = new VarTree(name, val);
                return left.Insert(name, val);
            }
            else if (comp == 0)
            {
                value = val;
                return this;
            }
            else
            {
                if (right == null)
                    right = new VarTree(name, val);
                return right.Insert(name, val);
            }
        }
        public VarTree Lookup(string name)
        {
            // NYI!
            // Console.WriteLine("  Not yet implemented!");
            return null;
        }
        public void Print()
        {
            // TBD!!
            // Console.WriteLine("  Not yet implemented!");
        }
    }
}
