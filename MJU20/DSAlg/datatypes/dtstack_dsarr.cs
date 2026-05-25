using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ds;

/// <summary>
/// Data Type Stack implemented by Data Structure Array
/// </summary>
namespace dtstack_dsarr
{
    class Stack<T>
    {
        private Array<T> arr;
        int insert;
        public Stack(int maxSize)
        {
            /// \todo NYI!
        }
        public void Push(T val)
        {
            /// \todo NYI!
        }
        public T Pop()
        {
            /// \todo NYI!
            return arr.Get(0);
        }
        public int Length()
        {
            /// \todo NYI!
            return 0;
        }
        public bool isFull()
        {
            /// \todo NYI!
            return false;
        }
        public bool isEmpty()
        {
            /// \todo NYI!
            return false;
        }
        /*
        public override string ToString()
        {
            string res = "{";
            bool first = true;
            for (int ix = Length() - 1; ix >= 0; ix--)
            {
                if (first)
                    first = false;
                else
                    res += ", ";
                res += $"{arr.Get(ix)}";
            }
            res += "}";
            return res;
        }
        */
    }
}
