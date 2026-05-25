using System.Globalization;
using System.Runtime.CompilerServices;

namespace ReadBuggyFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stat = new Dictionary<string, double>();
            stat["imp"] = 0.0;
            stat["iobj"] = 0.0;
            stat["func"] = 0.0;
            stat["log"] = 0.0;
            using (StreamReader sr = new StreamReader("../../../tiobe21.lis"))
            {
                while (!sr.EndOfStream)
                {
                    string? line = sr.ReadLine();
                    string[] array = line.Split('|');
                    string key = array[3];
                    if (stat.ContainsKey(key))
                    {
                        stat[key] += double.Parse(array[2], CultureInfo.InvariantCulture);
                    }
                }
            }
            foreach (KeyValuePair<string, double> pair in stat)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}