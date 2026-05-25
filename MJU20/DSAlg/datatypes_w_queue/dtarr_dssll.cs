using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ds;

/// <summary>
/// Data Type Array implemented by Data Structure Array
/// </summary>
namespace dtarr_dssll
{
    class Array<T>
    {
        private ds.SLList<T> sllist;
        //==== Constructors ====
        /// <summary>
        /// Constructor that allocates an array of elements with the
        /// </summary>
        /// <param name="size">desired size</param>
        /// <exception cref="ArgumentOutOfRangeException">if size ≤ 0</exception>
        public Array(int size)
        {
            if (size < 1) throw new ArgumentOutOfRangeException("size must be greater than 0");
            sllist = new ds.SLList<T>(size);
        }
        /// <summary>
        /// Constructor that allocates an array of elements copying the content from
        /// a raw datatype array
        /// </summary>
        /// <param name="rawArray">raw datatype array to copy from</param>
        public Array(T[] rawArray)
        {
            sllist = new ds.SLList<T>(rawArray.Length);
            ds.SLList<T> link = sllist;
            for (int ix = 0; ix < rawArray.Length; ix++)
            {
                link.SetVal(rawArray[ix]);
                link = link.GetNext();
            }
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
            ds.SLList<T> link = sllist;
            for (int i = 0; i < ix; i++)
            {
                link = link.GetNext();
            }
            link.SetVal(val);
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
            ds.SLList<T> link = sllist;
            for (int i = 0; i < ix; i++)
            {
                link = link.GetNext();
            }
            return link.GetVal();
        }
        /// <summary>
        /// Get the length of the Array
        /// </summary>
        /// <returns>the length</returns>
        public int Length()
        {
            ds.SLList<T> link = sllist;
            int len = 0;
            while (link != null)
            {
                link = link.GetNext();
                len++;
            }
            return len;
        }
        /// <summary>
        /// Accessor property for bracketed array access and assignment
        /// </summary>
        /// <param name="ix">the bracket index</param>
        /// <returns></returns>
        public T this[int ix]
        {
            get => Get(ix);
            set => Set(ix, value);
        }
        /// <summary>
        /// Autoconvert method for printout
        /// </summary>
        /// <returns>a string representing the content of the array</returns>
        public override string ToString()
        {
            string res = "{";
            bool first = true;
            for (int ix = 0; ix < Length(); ix++)
            {
                if (first)
                    first = false;
                else
                    res += ", ";
                res += $"{Get(ix)}";
            }
            res += "}";
            return res;
        }
    }
}
