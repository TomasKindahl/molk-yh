namespace ovn_2_1_2
{
    internal class Program
    {
        class ChemicalElement
        {
            int Z;
            string name, swName, symbol;
            int group, period;
            double meltingPoint, boilingPoint;
            public enum ElementType { Metal, Metalloid, Nonmetal }
            ElementType type;
            public ChemicalElement(int z, string name, string symbol)
            {
                Z = z;
                this.name = name;
                this.symbol = symbol;
                this.swName = "";
            }
            public string SwedishName { get { return swName; } set { swName = value; } }
            public int Group { get { return group; } set { group = value; } }
            public int Period { get { return period; } set { period = value; } }
            public ElementType Type { get { return type; } set { type = value; } }
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
            static double KelvinToCelsius(double kelvin) => kelvin - 273.16;
            public override string ToString()
            {
                string str = "";
                str += $"Element: {name} ({swName})\n";
                str += $"  type: {type}\n";
                str += $"  symbol: {symbol}\n";
                str += $"  group: {group}\n";
                str += $"  period: {period}\n";
                str += $"  melting point: {meltingPoint:0.##} K ({KelvinToCelsius(meltingPoint):0.##} C°)\n";
                str += $"  boiling point: {boilingPoint:0.##} K ({KelvinToCelsius(boilingPoint):0.##} C°)";
                return str;
            }
            public void Print()
            {
                Console.WriteLine(this);
            }
        }
        static void Main(string[] args)
        {
            ChemicalElement iron = new ChemicalElement(26, "Iron", "Fe");
            iron.SwedishName = "Järn";
            iron.Type = ChemicalElement.ElementType.Metal;
            iron.Group = 8; 
            iron.Period = 4;
            iron.MeltingPoint = 1881;
            iron.BoilingPoint = 3134;
            iron.Print();
            ChemicalElement hydrogen = new ChemicalElement(1, "Hydrogen", "H");
            hydrogen.SwedishName = "Väte";
            hydrogen.Type = ChemicalElement.ElementType.Nonmetal;
            hydrogen.Group = 1;
            hydrogen.Period = 1;
            hydrogen.MeltingPoint = 13.99;
            hydrogen.BoilingPoint = 20.271;
            hydrogen.Print();
            ChemicalElement oxygen = new ChemicalElement(1, "Oxygen", "O");
            oxygen.SwedishName = "Syre";
            oxygen.Type = ChemicalElement.ElementType.Nonmetal;
            oxygen.Group = 16;
            oxygen.Period = 2;
            oxygen.MeltingPoint = 54.36;
            oxygen.BoilingPoint = 90.188;
            oxygen.Print();
            ChemicalElement nitrogen = new ChemicalElement(1, "Nitrogen", "N");
            nitrogen.SwedishName = "Kväve";
            nitrogen.Type = ChemicalElement.ElementType.Nonmetal;
            nitrogen.Group = 15;
            nitrogen.Period = 2;
            nitrogen.MeltingPoint = 63.23;
            nitrogen.BoilingPoint = 77.355;
            nitrogen.Print();
        }
    }
}
