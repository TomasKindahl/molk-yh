using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vartree;

namespace varnamespace
{
    public class VarNameSpace
    {
        VarTree vars;
        public VarNameSpace()
        {
        }
        public void Assign(string var, int value)
        {
            if (vars == null)
            {
                vars = new VarTree(var, value);
            }
            else
            {
                vars.Insert(var, value);
            }
        }
        public bool IsSet(string var)
        {
            if (vars == null)
            {
                return false;
            }
            else
            {
                var tmp = vars.Lookup(var);
                if (tmp == null) return false;
                return true;
            }
        }
        public int Lookup(string var)
        {
            if (vars == null)
            {
                throw new IndexOutOfRangeException($"Lookup {var}: is not set!");
            }
            else
            {
                var tmp = vars.Lookup(var);
                if (tmp == null) throw new IndexOutOfRangeException($"Lookup {var}: is not set!");
                return tmp.value;
            }
        }
        public void Print()
        {
            if (vars != null)
                vars.Print();
            else
                Console.WriteLine("  (no variables defined)");
        }
    }
}
