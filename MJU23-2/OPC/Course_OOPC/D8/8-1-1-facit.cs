namespace d8_ovn1_1_interfaces
{
    internal class Program
    {
        interface Flyer
        {
            // Om den abstrakta klassen inte implementerar nåonting
            abstract public bool TakeToFlight();
            abstract public bool Fly();
            abstract public bool Land();
        }
        class Airplane : Flyer
        {
            bool flightmode = false;
            public bool TakeToFlight()
            {
                if (flightmode)
                {
                    Console.WriteLine("Already flying");
                    return false;
                }
                flightmode = true;
                return flightmode;
            }
            public bool Fly()
            {
                if (!flightmode)
                {
                    Console.WriteLine("Not flying");
                    return false;
                }
                return true;
            }
            public bool Land()
            {
                if (!flightmode)
                {
                    Console.WriteLine("Not flying");
                    return false;
                }
                flightmode = false;
                return flightmode;
            }
            public override string ToString()
            {
                string flying = flightmode ? "flying" : "on the ground";
                return $"Airplane ({flying})";
            }
        }
        static void Main(string[] args)
        {
            Airplane a1 = new Airplane();
            Console.WriteLine(a1);
            a1.TakeToFlight();
            Console.WriteLine(a1);
            a1.Land();
            Console.WriteLine(a1);
        }
    }
}
