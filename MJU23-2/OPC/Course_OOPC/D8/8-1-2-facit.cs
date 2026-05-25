namespace d8_ovn1_2_circnumber
{
    internal class Program
    {
        interface ICircularNumber
        {
            ICircularNumber next();
            ICircularNumber first();
            ICircularNumber last();
            int number();
        }
        class Circ : ICircularNumber
        {
            int max, value;
            public Circ(int max, int value) { this.max = max; this.value = value; }
            public ICircularNumber next() => new Circ(max, (value+1)%(max+1));
            public ICircularNumber first() => new Circ(max, 0);
            public ICircularNumber last() => new Circ(max, max);
            public int number() => value;
        }
        static void Main(string[] args)
        {
            ICircularNumber circ = new Circ(max: 5, value: 2);
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(circ.number());
                circ = circ.next();
            }
            Console.WriteLine($"first = {circ.first().number()}");
            Console.WriteLine($"last = {circ.last().number()}");
        }
    }
}
