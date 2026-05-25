using System.Collections;

namespace Ovn_2_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] rader = new int[5][];
            using (StreamReader sr = new StreamReader(@"..\..\..\rader.txt"))
            {
                string? line;
                int i = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] S = line.Split(' ');
                    rader[i] = new int[S.Length];
                    for(int j = 0; j < S.Length; j++)
                        rader[i][j] = int.Parse(S[j]);
                    i++;
                }
            }
            for (int i = 0; i < rader.Length; i++)
            {
                for (int j = 0; j < rader[i].Length; j++)
                    Console.Write(rader[i][j]+" ");
                Console.WriteLine();
            }
        }
    }
}
