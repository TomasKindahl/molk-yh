using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ds;

/// <summary>
/// Data Type Stack implemented by Data Structure Single Linked List
/// </summary>
namespace dtstack_dssll
{
    class Stack<T>
    {
        private SLList<T> sllist;
        int size, maxSize;
        /// <summary>
        /// Constructor that allockates a memory for the stack
        /// </summary>
        /// <param name="maxSz">the size of the memory allockated</param>
        public Stack(int maxSz)
        {
            /// \todo TBD!
        }
        /// <summary>
        /// Push an element onto the stack
        /// </summary>
        /// <param name="val">the element to push onto the stack</param>
        public void Push(T val)
        {
            /// \todo TBD!
        }
        /// <summary>
        /// Pop an element from the stack
        /// </summary>
        /// <param name="val">the element to push onto the stack</param>
        public T Pop()
        {
            /// \todo TBD!
            return sllist.GetVal(); // Dummy code!
        }
        /// <summary>
        /// The number of elements currently on the stack
        /// </summary>
        /// <returns>number of elements</returns>
        public int Length()
        {
            /// \todo TBD!
            return 0; // Dummy code!
        }
        /// <summary>
        /// Test if stack is full
        /// </summary>
        /// <returns></returns>
        public bool isFull()
        {
            /// \todo TBD!
            return false; // Dummy code!
        }
        /// <summary>
        /// Test if stack is empty
        /// </summary>
        /// <returns></returns>
        public bool isEmpty()
        {
            /// \todo TBD!
            return false; // Dummy code!
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
