using System.Xml;

namespace OPC1_uppg_2_5_3_facit
{
    internal class Program
    {
        static void MainHelp()
        {
            Monster m1 = new Monster("Ugluk", 16, 4);
            Monster m2 = new Monster("Aragorn", 14, 6);
            while(true)
            {
                m1.Hit(m2);
                if (m1.IsDead()) break;
                m2.Hit(m1);
                if (m2.IsDead()) break;
            }
            if (m1.IsDead() || !m2.IsDead())
                Console.WriteLine($"{m2.Name} vann!");
            else if (m2.IsDead() || !m1.IsDead())
                Console.WriteLine($"{m1.Name} vann!");
            else
                Console.WriteLine("bägge dog!");
        }
        static void Main(string[] args)
        {
            for(int i = 0; i < 200;  i++)
            {
                MainHelp();
            }
        }
    }
}