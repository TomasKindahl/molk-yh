using System;
using System.Xml;

namespace Ovn3_1_to_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Övning 3:0:
            Console.WriteLine("---- 625, 626, ... 767 ----");
            for (int i = 625; i <= 767; i = i + 2)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
            Console.Write("Press a key!"); Console.ReadKey();

            // Övning 3:1:
            Console.WriteLine("---- delbart med 3 eller 7 ----");
            for (int i = 0; i <= 1000; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    Console.Write(i + ", ");
                }
            }
            Console.WriteLine();
            Console.Write("Press a key!"); Console.ReadKey();

            // Övning 3:2:
            Console.WriteLine("---- delbart med 9 ----");
            Console.Write("Ange ett godtyckligt heltal: ");
            int theInt = int.Parse(Console.ReadLine());
            if (theInt % 9 == 0)
            {
                Console.WriteLine("Talet är jämnt delbart med 9.");
            }
            else
            {
                Console.WriteLine("Talet är inte jämnt delbart med 9.");
            }
            Console.Write("Press a key!"); Console.ReadKey();

            // Övning 3:3:
            Console.WriteLine("---- summation ----");
            int sum = 0;
            for (int i = 0; i < 100; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("0 + 1 + ... + 99 = {0}", sum);
            Console.Write("Press a key!"); Console.ReadKey();

            // Övning 3:4:
            Console.WriteLine("---- intervallsummation ----");
            Console.Write("Ange ett tal: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Ange ett större tal: ");
            int end = int.Parse(Console.ReadLine());
            int sum2 = 0;
            for (int i = start; i <= end; i++)
            {
                sum2 = sum2 + i;
            }
            Console.WriteLine("{0} + {1} + ... + {2} = {3}", start, start + 1, end, sum2);
            Console.Write("Press a key!"); Console.ReadKey();

            // Övning 3:5:
            Console.WriteLine("---- primtal ----");
            Console.Write("Ange ett tal: ");
            int maybePrime = int.Parse(Console.ReadLine());
            if (maybePrime % 2 == 0)
            {
                Console.WriteLine("Talet är inte ett primtal.");
            }
            else
            {
                bool isprime = true;
                for (int p = 3; p < maybePrime; p = p + 2)
                {
                    if (maybePrime % p == 0)
                    {
                        isprime = false;
                    }
                }
                if (isprime)
                {
                    Console.WriteLine("Talet är ett primtal.");
                }
                else
                {
                    Console.WriteLine("Talet är inte ett primtal.");
                }
            }
            Console.Write("Press a key!"); Console.ReadKey();

            // Övning 3:6:
            Console.WriteLine("---- Fibonacci ----");
            long f0 = 0, f1 = 1, f2;
            for (int i = 0; i < 50; i++)
            {
                Console.Write("{0}, ", f0);
                f2 = f0 + f1;
                f0 = f1;
                f1 = f2;
            }
            Console.Write("Press a key!"); Console.ReadKey();

            // Övning 3:7:
            Console.WriteLine("---- primtal ----");
            int num = 0, pk = 2;
            while (num < 100)
            {
                if (pk % 2 == 0)
                {
                    ;
                }
                else
                {
                    bool isprime = true;
                    for (int p = 3; p < pk; p = p + 2)
                    {
                        if (pk % p == 0)
                        {
                            isprime = false;
                        }
                    }
                    if (isprime)
                    {
                        Console.Write("{0}, ", pk);
                        num++;
                    }
                    else
                    {
                        ;
                    }
                }
                pk++;
            }
            Console.Write("Press a key!"); Console.ReadKey();

            // Övning 3:8-9:
            Console.WriteLine("---- tärning ----");
            int[] stat = new int[6];
            for(int i = 0; i < 6; i++) { stat[i] = 0; }
            Random r = new Random();
            for(int i = 0; i < 100; i++)
            {
                int n = r.Next(1, 7);
                stat[n-1] = stat[n-1] + 1;
                Console.Write("{0}, ", n);
            }
            Console.Write("Press a key!"); Console.ReadKey();

            // Övning 3:9:
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine("{0}: {1}", i + 1, stat[i]);
            }
            Console.Write("Press a key!"); Console.ReadKey();
        }
    }
}
