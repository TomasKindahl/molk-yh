using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds
{
    /// <summary>
    /// Generic array type of a static size
    /// </summary>
    /// <typeparam name="T">the base type</typeparam>
    public class Array<T>
    {
        private T[] arr;
        /// <summary>
        /// Create an array with a certain size
        /// </summary>
        /// <param name="size">the reserved array size</param>
        public Array(int size)
        {
            arr = new T[size];
        }
        /// <summary>
        /// Get the element at a certain index in the array
        /// </summary>
        /// <param name="ix">the index</param>
        /// <returns>the value of the element</returns>
        public T Get(int ix)
        {
            if (ix < 0)
                throw new IndexOutOfRangeException($"Get: array index too small {ix}");
            if (arr.Length <= ix)
                throw new IndexOutOfRangeException($"Get: array index above array size {ix}");
            return arr[ix];
        }
        /// <summary>
        /// Set the element at a certain index in the array
        /// </summary>
        /// <param name="ix">the index</param>
        /// <param name="val">the new value of the element</param>
        public void Set(int ix, T val)
        {
            if (ix < 0)
                throw new IndexOutOfRangeException($"Set: array index too small {ix}");
            if (ix >= Length())
                throw new IndexOutOfRangeException($"Set: array index above array size {ix}");
            arr[ix] = val;
        }
        /// <summary>
        /// Return the length of the array
        /// </summary>
        /// <returns>the array length</returns>
        public int Length()
        {
            return arr.Length;
        }
    }
    /// <summary>
    /// Generic Single Linked List
    /// </summary>
    /// <typeparam name="T">the base type</typeparam>
    public class SLList<T>
    {
        private T value;
        private SLList<T> next;
        /// <summary>
        /// Create an empty link with no next link
        /// </summary>
        public SLList()
        {
        }
        /// <summary>
        /// Create a link with a certain value and a next link
        /// </summary>
        /// <param name="val">the value</param>
        /// <param name="nx">the next link</param>
        public SLList(T val, SLList<T> nx)
        {
            value = val;
            next = nx;
        }
        /// <summary>
        /// Create an entire link list with a certain lengths
        /// </summary>
        /// <param name="size">the number of links created</param>
        public SLList(int size)
        {
            if (size <= 0)
                throw new ArgumentNullException($"SLList create bad size: {size}");
            if (size > 1)
                next = new SLList<T>(size - 1);
        }
        /// <summary>
        /// Get the value in the current link
        /// </summary>
        /// <returns>the value in the link</returns>
        public T GetVal()
        {
            return value;
        }
        /// <summary>
        /// Set the value in the current link
        /// </summary>
        /// <param name="val">the new value of the link</param>
        public void SetVal(T val)
        {
            value = val;
        }
        /// <summary>
        /// Get the next link appointed from the current link
        /// </summary>
        /// <returns>the next link</returns>
        public SLList<T> GetNext()
        {
            return next;
        }
        /// <summary>
        /// Set a new next link to appoint the current link
        /// </summary>
        /// <param name="nx">the new next link to appoint</param>
        public void SetNext(SLList<T> nx)
        {
            next = nx;
        }
        /*
        public bool IsEq(T val)
        {
            // "==" doesn't work on unspecified T, so:
            return value.Equals(val);
        }
        public SLList<T> GetLink(T val)
        {
            if (IsEq(val))
                return this;
            else if (GetNext() != null)
                return GetNext().GetLink(val);
            else
                return null;
        }
        */
    }
    /// <summary>
    /// Generic Double Linked List
    /// </summary>
    /// <typeparam name="T">the base type</typeparam>
    public class DLList<T>
    {
        private T value;
        private DLList<T> prev, next;
        /// <summary>
        /// Create an empty link with no next link
        /// </summary>
        public DLList()
        {
        }
        /// <summary>
        /// Create a link with a certain value a next and a previous link
        /// </summary>
        /// <param name="val">the value</param>
        /// <param name="nx">the next link</param>
        public DLList(T val, DLList<T> nx)
        {
            value = val;
            next = nx;
            if (next != null) next.prev = this;
        }
        /// <summary>
        /// Create an entire link list with a certain lengths
        /// </summary>
        /// <param name="size">the number of links created</param>
        public DLList(int size)
        {
            if (size <= 0)
                throw new ArgumentNullException($"SLList create bad size: {size}");
            if (size > 1)
                next = new DLList<T>(size - 1);
        }
        /// <summary>
        /// Get the value in the current link
        /// </summary>
        /// <returns>the value in the link</returns>
        public T GetVal()
        {
            return value;
        }
        /// <summary>
        /// Set the value in the current link
        /// </summary>
        /// <param name="val">the new value of the link</param>
        public void SetVal(T val)
        {
            value = val;
        }
        /// <summary>
        /// Get the next link appointed from the current link
        /// </summary>
        /// <returns>the next link</returns>
        public DLList<T> GetNext()
        {
            return next;
        }
        /// <summary>
        /// Set a new next link to appoint the current link
        /// </summary>
        /// <param name="nx">the new next link to appoint</param>
        public void SetNext(DLList<T> nx)
        {
            next = nx;
            next.prev = this;
        }
        /// <summary>
        /// Get the previous link appointed from the current link
        /// </summary>
        /// <returns>the previous link</returns>
        public DLList<T> GetPrev()
        {
            return prev;
        }
        /// <summary>
        /// Set a new previous link to appoint the current link
        /// </summary>
        /// <param name="pv">the new previous link to appoint</param>
        public void SetPrev(DLList<T> pv)
        {
            prev = pv;
            pv.next = this;
        }
        /*
        public bool IsEq(T val)
        {
            // "==" doesn't work on unspecified T, so:
            return value.Equals(val);
        }
        public SLList<T> GetLink(T val)
        {
            if (IsEq(val))
                return this;
            else if (GetNext() != null)
                return GetNext().GetLink(val);
            else
                return null;
        }
        */
    }
}
