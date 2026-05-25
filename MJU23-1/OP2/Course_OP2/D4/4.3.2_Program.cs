namespace ovn_4_3_2
{
    internal class Program
    {
        public delegate double binop(double a1, double a2);
        public static void VäljNamnSjälv(double param1, double param2, binop callback)
        {
            Console.WriteLine($"{param1} callback {param2} = {callback(param1, param2)}");
        }
        public static double add(double a1, double a2) => a1 + a2;
        public static double multiply(double a1, double a2) => a1 * a2;
        static void Main(string[] args)
        {
            VäljNamnSjälv(3, 5, add);
            VäljNamnSjälv(3, 5, multiply);
            VäljNamnSjälv(3, 5, (x, y) => x-y );
            VäljNamnSjälv(3, 5, double (double x, double y) => x/y );
        }
    }
}
