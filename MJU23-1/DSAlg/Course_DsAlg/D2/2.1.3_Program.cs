using System.Collections;

namespace Ovn_2_1_3
{
    internal class Program
    {
        static bool IsSATOR(char[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] != mat[j, i]) return false;
                    if (mat[i, j] != mat[mat.GetLength(0) - 1 - i, mat.GetLength(1) - 1 - j]) return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            char[,] SATOR = { {'S', 'A', 'T', 'O', 'R'},
                              {'A', 'R', 'E', 'P', 'O'},
                              {'T', 'E', 'N', 'E', 'T'},
                              {'O', 'P', 'E', 'R', 'A'},
                              {'R', 'O', 'T', 'A', 'S'}};
            Console.WriteLine($"SATOR is SATOR? {IsSATOR(SATOR)}");
            char[,] SUNAR = { {'S', 'U', 'N', 'A', 'R'},
                              {'U', 'N', 'A', 'R', 'I'},
                              {'N', 'A', 'R', 'I', 'T'},
                              {'A', 'R', 'I', 'T', 'M'},
                              {'R', 'I', 'T', 'M', 'O'}};
            Console.WriteLine($"SUNAR is SATOR? {IsSATOR(SUNAR)}");
            char[,] TENIR = { {'T', 'E', 'N', 'I', 'R'},
                              {'E', 'R', 'A', 'T', 'I'},
                              {'N', 'A', '6', 'A', 'N'},
                              {'I', 'T', 'A', 'R', 'E'},
                              {'R', 'I', 'N', 'E', 'T'}};
            Console.WriteLine($"TENIR is SATOR? {IsSATOR(TENIR)}");
            char[,] ROMA = { {'R', 'O', 'M', 'A'},
                             {'O', 'L', 'I', 'M'},
                             {'M', 'I', 'L', 'O'},
                             {'A', 'M', 'O', 'R'}};
            Console.WriteLine($"ROMA is SATOR? {IsSATOR(ROMA)}");
        }
    }
}
