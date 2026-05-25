using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovn_7_1_1
{
    class Program
    {
        public static void Main(String[] args)
        {
            Task t = new Task(() => Run());

            //Start the Task
            t.Start();
            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine($"main {i}");
            }
            t.Wait();
            Console.Write("Press enter to continue: ");
            Console.ReadLine();
        }
        public static async void Run()
        {
            for (int i = 1; i <= 6; i++)
            {
                Task.Delay(10);
                Console.WriteLine($"task {i}");
            }
        }
    }
}
