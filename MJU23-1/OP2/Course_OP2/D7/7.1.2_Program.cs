using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovn_7_1_2
{
    class Program
    {
        public static void Main(String[] args)
        {
            Task ta = new Task(() => Run("taskA"));
            Task tb = new Task(() => Run("taskB"));

            //Start the Tasks:
            ta.Start();
            tb.Start();
            ta.Wait();
            tb.Wait();
            // or: Task.WaitAll(ta, tb);
            Console.Write("Press enter to continue: ");
            Console.ReadLine();
        }
        public static async void Run(string name)
        {
            Random rnd = new Random();
            for (int i = 1; i <= 6; i++)
            {
                await Task.Delay(rnd.Next(2, 10));
                Console.WriteLine($"{name} {i}");
            }
        }
    }
}
