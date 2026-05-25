public void InsertLast(T value)              // 1
{
    if (next == null)                        // 2
        next = new LispList<T>(value, null); // 3
    else                                     // 4
        next.InsertLast(value);              // 5
}
