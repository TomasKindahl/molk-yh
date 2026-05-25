namespace d11_simpel_avlusning
{
    internal class Program
    {
        class Vector
        {
            double X, Y, Z;
            public Vector(double x, double y, double z)
            {
                X = x; Y = y; Z = z;
            }
            public override string ToString()
            {
                return $"({X} {Y} {Z})";
            }
            public static Vector operator +(Vector u, Vector v)
            {
                return new Vector(u.X + v.X, u.Y + v.Y, u.Z + v.Z);
            }
        }
        static void Main(string[] args)
        {
            Vector?[] vectors = { new Vector(1, 2, 1), new Vector(2, 3, -1), null };
            foreach(Vector? v in vectors)
            {
                Vector vio = new Vector(-1, 1, 2);
                Console.WriteLine(v + vio);
            }
        }
    }
}
