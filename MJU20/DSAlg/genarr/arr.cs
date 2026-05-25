using System;
using System.Collections.Generic;
using System.Text;

namespace arr
{
    /// <summary>
    /// Generic array datatype
    /// </summary>
    /// <typeparam name="T">specific type</typeparam>
    public class Array<T>
    {
        // T arr[];
        class List<T> {
            public T value;
            public List<T> next;
            public List(int size)
            {
                if (size > 1)
                    next = new List<T>(size - 1);
                else
                    next = null;
            }
            public int Length() {
                if(next == null)
                    return 1;
                return 1 + next.Length();
            }
            public T Get(int N)
            {
                if (N == 0)
                    return this.value;
                else
                    return next.Get(N - 1);
            }
            public void Set(int N, T value)
            {
                if (N == 0)
                    this.value = value;
                else
                    next.Set(N - 1, value);
            }
            public void Print()
            {
                Console.Write($"{value} ");
                if (next != null)
                    next.Print();
                else
                    Console.WriteLine();
            }
        }
        List<T> list;
        //==== Constructors ====
        /// <summary>
        /// Constructor that allocates an array of elements with the
        /// </summary>
        /// <param name="size">desired size</param>
        /// <exception cref="ArgumentOutOfRangeException">if size ≤ 0</exception>
        public Array(int size)
        {
            if (size < 1) throw new ArgumentOutOfRangeException("size must be greater than 0");
            list = new List<T>(size);
        }
        /// <summary>
        /// Get the length of the Array
        /// </summary>
        /// <returns>the length</returns>
        public int Length()
        {
            return list.Length();
        }
        // Access:
        /// <summary>
        /// Access element at certain index
        /// </summary>
        /// <param name="ix">the index</param>
        /// <returns>the element at a certain index in the array</returns>
        /// <exception cref="IndexOutOfRangeException">if index &lt; 0 or Length() ≤ index</exception>
        public T Get(int ix)
        {
            if (ix < 0)
                throw new IndexOutOfRangeException("index must be within range 0 to Length()");
            if (Length() <= ix)
                throw new IndexOutOfRangeException("index must be within range 0 to Length()");
            return list.Get(ix);
        }
        /// <summary>
        /// Change element at a certain index to a new value
        /// </summary>
        /// <param name="ix">the index</param>
        /// <param name="val">the new value</param>
        /// <exception cref="IndexOutOfRangeException">if index &lt; 0 or Length() ≤ index</exception>
        public void Set(int ix, T val)
        {
            if (ix < 0)
                throw new IndexOutOfRangeException("index must be within range 0 to Length()");
            if (Length() <= ix)
                throw new IndexOutOfRangeException("index must be within range 0 to Length()");
            list.Set(ix, val);
        }
        /// <summary>
        /// Indexed access of individual element
        /// </summary>
        /// <param name="ix">the index</param>
        /// <returns>get: returns the value at the index</returns>
        /// <returns>set: return nothing</returns>
        public T this[int ix]
        {
            get => Get(ix);
            set => Set(ix, value);
        }
        public void Print()
        {
            list.Print();
        }
    }
}
