using System.Collections;

namespace Ovn_2_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] rader = new int[4,4];
            using (StreamReader sr = new StreamReader(@"..\..\..\rader.txt"))
            {
                string? line;
                int i = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] S = line.Split(' ');
                    for(int j = 0; j < S.Length; j++)
                        rader[i,j] = int.Parse(S[j]);
                    i++;
                }
            }
            for (int i = 0; i < rader.GetLength(0); i++)
            {
                for (int j = 0; j < rader.GetLength(1); j++)
                    Console.Write(rader[i,j]+" ");
                Console.WriteLine();
            }
        }
    }
}
