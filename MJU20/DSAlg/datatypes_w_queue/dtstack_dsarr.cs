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
        int top;
        /// <summary>
        /// Constructor that allockates a memory for the stack
        /// </summary>
        /// <param name="maxSize">the size of the memory allockated</param>
        public Stack(int maxSize)
        {
            arr = new ds.Array<T>(maxSize);
            top = 0; 
        }
        /// <summary>
        /// Push an element onto the stack
        /// </summary>
        /// <param name="val">the element to push onto the stack</param>
        public void Push(T val)
        {
            arr.Set(top, val);
            top++;
        }
        /// <summary>
        /// Pop an element from the stack
        /// </summary>
        /// <param name="val">the element to push onto the stack</param>
        public T Pop()
        {
            top--;
            return arr.Get(top);
        }
        /// <summary>
        /// The number of elements currently on the stack
        /// </summary>
        /// <returns>number of elements</returns>
        public int Length()
        {
            return top;
        }
        /// <summary>
        /// Test if stack is full
        /// </summary>
        /// <returns></returns>
        public bool isFull()
        {
            return top == arr.Length();
        }
        /// <summary>
        /// Test if stack is empty
        /// </summary>
        /// <returns></returns>
        public bool isEmpty()
        {
            return top == 0;
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
