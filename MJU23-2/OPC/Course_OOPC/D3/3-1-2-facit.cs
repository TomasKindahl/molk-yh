namespace opc1_d3_3_1_ovn_2
{
    internal class Program
    {
        class Fordon
        {
            protected double hastighetKmH;
            public double TidAttFärdas(double avståndKm)
            {
                return (avståndKm / hastighetKmH)*60;
            }
        }
        class Tillfots : Fordon
        {
            public Tillfots() { hastighetKmH = 6.0; }
        }
        class Cykel : Fordon
        {
            public Cykel() { hastighetKmH = 20.0; }
        }
        class Bil : Fordon
        {
            string märke;
            double bensinPerKm;
            public Bil(string märke, double bensinPerKm)
            {
                this.märke = märke;
                this.bensinPerKm = bensinPerKm;
                this.hastighetKmH = 70.0;
            }
            public double BränsleÅtgång(double avståndKm)
            {
                return avståndKm * bensinPerKm;
            }
        }
        static void Main(string[] args)
        {
            List<Fordon> fordon = new List<Fordon>();
            fordon.Add(new Tillfots());
            fordon.Add(new Cykel());
            fordon.Add(new Bil(märke: "Volvo V70", bensinPerKm: 0.045));
            foreach (Fordon F in fordon)
            {
                Console.WriteLine($"{F.TidAttFärdas(avståndKm: 6)} minuter");
                if (F is Bil b)
                {
                    Console.WriteLine($" drar {b.BränsleÅtgång(avståndKm: 6)} liter bensin");
                }
            }
        }
    }
}