using System;

namespace Ovn1_colon_3_to_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Övning 1:3
            Console.Write("Ange cirkelns diameter: ");
            double diam = double.Parse(Console.ReadLine());
            Console.WriteLine("En cirkel med diametern {0} har:", diam);
            double circ = diam * Math.PI;
            Console.WriteLine("... omkretsen: {0}", circ);
            double radius = diam / 2.0;
            double area = radius * radius * Math.PI;
            Console.WriteLine("... arean: {0}", area);
            Console.Write("Press key ..."); Console.ReadKey(); Console.Clear();
            // Övning 1:4:
            Console.Write("Mata in grader i Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = celsius * 1.8 + 32;
            Console.WriteLine("det blir {0} grader Fahrenheit", fahrenheit);
            Console.Write("Press key ..."); Console.ReadKey(); Console.Clear();
            // Övning 1:5:
            Console.WriteLine("Beräkna avståndet mellan två punkter.\n");
            Console.Write("Ange x-koordinaten för p1: ");
            double x1 = int.Parse(Console.ReadLine());
            Console.Write("Ange y-koordinaten för p1: ");
            double y1 = int.Parse(Console.ReadLine());
            Console.Write("Ange x-koordinaten för p2: ");
            double x2 = int.Parse(Console.ReadLine());
            Console.Write("Ange y-koordinaten för p2: ");
            double y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nAvståndet är: {0}\n",
                Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1))
                );
        }
    }
}
