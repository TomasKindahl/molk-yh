using System;

namespace Uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] dict = new string[][]{
               new string[]{"arc", "båge"},
               new string[]{"bear", "björn"},
               new string[]{"bear", "bära"},
               new string[]{"close", "nära"},
               new string[]{"close", "låsa"},
               new string[]{"fire", "eld"},
               new string[]{"fire", "sätta eld på"},
               new string[]{"lean", "smal"},
               new string[]{"lean", "luta"},
               new string[]{"sun", "sol"},
               new string[]{"tense", "spänd"},
               new string[]{"wolf", "varg"},
               new string[]{"yellow", "gul"}
            };
            WordDict Dict = new WordDict();
            foreach (string[] d in dict)
            {
                Dict.Set(d[0], d[1]);
            }

            foreach (string key in Dict.GetKeys())
            {
                int num = Dict.GetNum(key);
                Console.WriteLine($"{key} ({num}):");
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine($"  {Dict.Get(key, i)}");
                }
            }
        }
    }
}
