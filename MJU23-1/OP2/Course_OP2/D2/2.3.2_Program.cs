namespace ovn_2_3_2
{
    internal class Program
    {
        class AstronomicalObject
        {
            protected string name { get; set; }
            double maxMag, minMag;
            public AstronomicalObject(string name, double maxMag, double minMag)
            {
                this.name = name;
                this.maxMag = maxMag;
                this.minMag = minMag;
            }
            public void PrintMagnitude()
            {
                Console.Write($"  Magnitude: ");
                if (maxMag == minMag)
                    Console.WriteLine($"{maxMag} (constant)");
                else
                    Console.WriteLine($"min {minMag} max {maxMag}");
            }
            public override string ToString()
            {
                string res = $"{name}\n  ";
                if (maxMag == minMag)
                    res += $"{maxMag} (constant)\n";
                else
                    res += $"min {minMag} max {maxMag}\n";
                return res;
            }
            public virtual void Print() { Console.WriteLine(this); }
        }
        class Planet : AstronomicalObject
        {
            public enum Type { Terrestrial, Asteroid, Jovian, TNO }
            Type type;
            double AU;
            int numberOfMoons;
            public Planet(string name, double maxMag, double minMag, Type type, double AU, int numberOfMoons = 0)
                : base(name, maxMag, minMag)
            {
                this.type = type;
                this.AU = AU;
                this.numberOfMoons = numberOfMoons;
            }
            public override string ToString()
            {
                string res = $"Planet: {base.ToString()}";
                res += $"  Type: {type}\n";
                res += $"  Distance: {AU}\n";
                res += $"  Number of Moons: {numberOfMoons}";
                return res;
            }
            public override void Print()
            {
                Console.WriteLine(this);
            }
        }
        class Star : AstronomicalObject
        {
            string SP;
            double age, distance;
            public Star(string name, double maxMag, double minMag, string SP, double age, double distance)
                : base(name, maxMag, minMag)
            {
                this.SP = SP;
                this.age = age;
                this.distance = distance;
            }
            public override string ToString()
            {
                string res = $"Planet: {base.ToString()}";
                res += $"  Spectral Type: {SP}\n";
                res += $"  Distance: {distance} lightyears\n";
                res += $"  Age: {age}";
                return res;
            }
            public override void Print()
            {
                Console.WriteLine(this);
            }
        }
        static void Main(string[] args)
        {
            List<AstronomicalObject> aobj = new List<AstronomicalObject>();
            aobj.Add(new Planet("Venus", -4.92, -2.98, Planet.Type.Terrestrial, 0.723332));
            aobj.Add(new Planet("Ceres", 7.6, 9.27, Planet.Type.Asteroid, 2.77));
            aobj.Add(new Planet("Jupiter", -2.94, -1.66, Planet.Type.Jovian, 5.2038, 95));
            aobj.Add(new Star("Sun", -26.74, -26.74, "G2V", 4.57, 1.5210282150733897e-05));
            aobj.Add(new Star("Sirius", -1.46, -1.46, "A0mA1 Va", 0.228, 8.60));
            aobj.Add(new Star("Proxima Centauri", +10.43, +11.11, "M5.5Ve", 4.85, 4.2465));
            foreach (AstronomicalObject obj in aobj)
            {
                obj.Print();
            }
        }
    }
}
