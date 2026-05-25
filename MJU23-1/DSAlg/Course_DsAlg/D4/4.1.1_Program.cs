using System.Collections;

namespace Ovn_4_1_1
{
    internal class Program
    {
        interface ICircularNumber
        {
            void Next();
            int Value();
            int Start();
            int End();
        }
        class Circ : ICircularNumber
        {
            int start, value, end;
            public Circ(int start, int end) {
                this.start = start;
                this.end = end;
                value = start;
            }
            public void Next()
            {
                if(value < end) 
                    value++;
                else
                    value = start;
            }
            public int Value() {  return value; }
            public int Start() { return start; }
            public int End() { return end; }
        }
        static void Main(string[] args)
        {
            ICircularNumber circ = new Circ(start: 2, end: 6);
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(circ.Value());
                circ.Next();
            }
            Console.WriteLine($"start = {circ.Start()}");
            Console.WriteLine($"end = {circ.End()}");
        }
    }
}
