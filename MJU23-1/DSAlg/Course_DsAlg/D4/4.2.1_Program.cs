using System.Collections;

namespace Ovn_4_2_1
{
    internal class Program
    {
        class Vec<T>
        {
            T[] arr;
            public Vec(int size, T defaultvalue)
            {
                arr = new T[size];
                for (int i = 0; i < arr.Length; i++) arr[i] = defaultvalue;
            }
            public T GetAt(int index) => arr[index];
            public void SetAt(int index, T newValue) => arr[index] = newValue;
            public override string ToString()
            {
                string res = $"{arr[0]}";
                for (int i = 1; i < arr.Length; i++)
                    res += $"; {arr[0]}";
                return res;
            }
        }
        static void Main(string[] args)
        {
            Vec<int> iv = new Vec<int>(5, 1);
            Console.WriteLine(iv);
            Vec<string> sv = new Vec<string>(5, "mat");
            Console.WriteLine(sv);
        }
    }
}
