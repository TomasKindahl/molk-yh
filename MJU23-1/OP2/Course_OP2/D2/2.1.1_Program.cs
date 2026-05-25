namespace ovn_2_1_1
{
    internal class Program
    {
        class ChemicalElement
        {
            int Z;
            string name, swName, symbol;
            int group, period;
            double meltingPoint, boilingPoint;
            public ChemicalElement(int z, string name, string symbol)
            {
                Z = z;
                this.name = name;
                this.symbol = symbol;
                this.swName = "";
            }
            // Java Classic:
            public void SetGroup(int Group) { group = Group; }
            public void SetPeriod(int period) { this.period = period; }
            public void SetSwedish(string SwName) { swName = SwName; }
            // Property: 
            public string SwName { get { return swName; } set { swName = value; } }
            public int Group { get { return group; } set { group = value; } }
            public int Period { get { return period; } set { period = value; } }
            public double MeltingPoint
            {
                get { return meltingPoint; }
                set { meltingPoint = value; }
            }
            public double BoilingPoint
            {
                get { return boilingPoint; }
                set { boilingPoint = value; }
            }
            public void Print()
            {
                Console.WriteLine($"Element: {name} ({swName})");
                Console.WriteLine($"  symbol: {symbol}");
                Console.WriteLine($"  group: {group}");
                Console.WriteLine($"  period: {period}");
                Console.WriteLine($"  melting point: {meltingPoint} K");
                Console.WriteLine($"  boiling point: {boilingPoint} K");
            }
        }
        static void Main(string[] args)
        {
            ChemicalElement iron = new ChemicalElement(26, "Iron", "Fe");
            iron.SetSwedish("Järn");
            iron.SetGroup(8); iron.Group = 8; 
            iron.SetPeriod(4); iron.Period = 4;
            iron.MeltingPoint = 1881;
            iron.BoilingPoint = 3134;
            iron.Print();
            ChemicalElement hydrogen = new ChemicalElement(1, "Hydrogen", "H");
            hydrogen.SetSwedish("Väte");
            hydrogen.Group = 1;
            hydrogen.Period = 1;
            hydrogen.MeltingPoint = 13.99;
            hydrogen.BoilingPoint = 20.271;
            hydrogen.Print();
            ChemicalElement oxygen = new ChemicalElement(1, "Oxygen", "O");
            oxygen.SetSwedish("Syre");
            oxygen.Group = 16;
            oxygen.Period = 2;
            oxygen.MeltingPoint = 54.36;
            oxygen.BoilingPoint = 90.188;
            oxygen.Print();
            ChemicalElement nitrogen = new ChemicalElement(1, "Nitrogen", "N");
            nitrogen.SetSwedish("Kväve");
            nitrogen.Group = 15;
            nitrogen.Period = 2;
            nitrogen.MeltingPoint = 63.23;
            nitrogen.BoilingPoint = 77.355;
            nitrogen.Print();
        }
    }
}
