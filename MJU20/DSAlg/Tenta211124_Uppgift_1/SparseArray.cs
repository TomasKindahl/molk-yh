using System;

namespace Uppgift_1
{
    public class SparseArray<T>
    {
        // Insert data fields here:
        public SparseArray(long maxSize)
        {
            throw new NotImplementedException("SparseArray constructor not yet implemented!");
        }
        public void Set(long index, T value)
        {
            throw new NotImplementedException("SparseArray.Set not yet implemented!");
        }
        public T Get(long index)
        {
            throw new NotImplementedException("SparseArray.Get not yet implemented!");
        }
        public long Length()
        {
            throw new NotImplementedException("SparseArray.Length not yet implemented!");
        }
        public T this[long ix] 
        {
            // Bonus code for the convenience of the API user:
            get => Get(ix);         // Makes sparse[ix] work
            set => Set(ix, value);  // Makes sparse[ix] = value work
        }
    }
}