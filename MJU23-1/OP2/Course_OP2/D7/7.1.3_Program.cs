using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ovn_7_1_3
{
    class Program
    {
        public static void Main(String[] args)
        {
            Task Parent = new Task(() => OuterTask());

            //Start the Task
            Parent.Start();
            Parent.Wait();
            Console.ReadLine();
        }
        public static void OuterTask()
        {

            Task Child = new Task(() => InnerTask(), TaskCreationOptions.AttachedToParent);

            //Start Child Task
            Child.Start();
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Outer Task Finish");
        }
        public static void InnerTask()
        {
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Inner Task Finish");
        }
    }
}