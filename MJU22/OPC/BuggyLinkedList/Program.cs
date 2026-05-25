namespace BuggyLinkedList
{
    internal class Program
    {
        class MyLinkedList
        {
            string first; MyLinkedList next;
            public MyLinkedList(string first, MyLinkedList next = null)
            {
                this.first = first; this.next = next;
            }
            public MyLinkedList(string[] strings, int index = 0)
            {
                this.first = strings[index];
                if (index < strings.Length - 1)
                    this.next = new MyLinkedList(strings, index + 1);
                else
                    this.next = null;
            }
            private string Str()
            {
                string S = $"{first}";
                if (next.next == null) return S;
                return S + ", " + next.Str();
            }
            public override string ToString()
            {
                return $"[{Str()}]";
            }
            public string First { get => first; }
            public MyLinkedList Next { get => next; set => next = value; }
        }
        static void Main(string[] args)
        {
            string[] magi = { "abra", "kadabra", "hokus", "pokus", "filiokus",
                "sim", "sala", "bim" };
            MyLinkedList M1 = new MyLinkedList(magi);
            MyLinkedList M2 = new MyLinkedList(magi[0]);
            Console.WriteLine(M1);
            Console.WriteLine(M2);
        }
    }
}