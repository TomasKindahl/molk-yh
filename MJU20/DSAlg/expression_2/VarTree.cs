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
        public VarTree Lookup(string name)
        {
            int comp = String.Compare(name, varName);
            if (comp < 0)
            {
                if (left == null)
                    return null;
                else
                    return left.Lookup(name);
            }
            else if (comp == 0)
            {
                return this;
            }
            else
            {
                if (right == null)
                    return null;
                else
                    return right.Lookup(name);
            }
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
        public void Print()
        {
            if (left != null)
                left.Print();
            Console.WriteLine($"  {varName} = {value}");
            if (right != null)
                right.Print();
        }
    }
}
