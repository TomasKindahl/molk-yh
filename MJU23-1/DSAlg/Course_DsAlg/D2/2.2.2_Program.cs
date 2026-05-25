using System.Collections;

namespace Ovn_2_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> arl = new List<double>();
            arl.Add(1);
            arl.Add(3.2);
            arl.Add(1229234983273642);
            foreach (object a in arl)
            {
                Console.WriteLine($"{a}");
            }
        }
    }
}