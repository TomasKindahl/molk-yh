using System.Collections;

namespace Ovn_2_1_3
{
    internal class Program
    {
        static bool IsTranspose(double[,] L, double[,] M)
        {
            for (int i = 0; i < L.GetLength(0); i++)
            {
                for(int j = 0; j < L.GetLength(1); j++)
                {
                    if (L[i,j] != M[j,i]) return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            double[,] L = { { 2, 3, 9 }, { 7, 5, 3 }, { 6, 1, 5 } };
            double[,] M = { { 2, 7, 6 }, { 3, 5, 1 }, { 9, 3, 5 } };
            Console.WriteLine(IsTranspose(L,M));
            double[,] M2 = { { 2, 7, 6 }, { 3, 6, 1 }, { 4, 3, 5 } };
            Console.WriteLine(IsTranspose(L, M2));
        }
    }
}
