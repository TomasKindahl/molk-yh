using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Text;

namespace Sorting_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a randomizer:
            Random randomizer = new Random();
            Stopwatch swInit = new Stopwatch();
            Stopwatch swBubble = new Stopwatch();
            Stopwatch swSelection = new Stopwatch();
            Stopwatch swInsert = new Stopwatch();
            Stopwatch swHeap = new Stopwatch();
            Stopwatch swQuick = new Stopwatch();

            for (int intMax = 1_024; intMax < 262_144; intMax <<= 1)
            {
                // Generate the array and measure the time:
                Console.WriteLine($"\nStarting timer for initiating an array with length: {intMax}");
                swInit.Start();
                int[] testArray = new int[intMax];

                FillRandomly(randomizer, testArray);
                swInit.Stop();
                Console.WriteLine($"  Elapsed time for populating the array: {swInit.Elapsed}");
                Console.WriteLine($"  This array consist of {testArray.Length} random integer numbers.");

                // Test the sorting algorithm:
                swBubble.Start();
                BubbleSort(testArray);
                swBubble.Stop();
                Console.WriteLine($"  Elapsed time for sorting the array: {swBubble.Elapsed}");

                // Insert new sorting algorithms here:

                // Test that the algorithm actually sorts correctly:
                if (!TestSortedAscending(testArray))
                {
                    Console.WriteLine("ERROR: The implementation actually doesn't sort the array!!");
                    break; // the for loop
                }
            }

            Console.WriteLine("\nPress any key to exit program...");
            Console.ReadKey();
        }

        // Populate the array with random integer values. Negative values are allowed:
        private static void FillRandomly(Random randomizer, int[] testArray)
        {
            for (int i = 0; i < testArray.Length; i++)
                testArray[i] = randomizer.Next();
        }

        // Bubble sort:
        public static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j]) Swap(ref arr[i], ref arr[j]);
                }
            }
        }

        /********************************/
        /********************************/
        /**** ADD ALGORITHMS BELOW!! ****/
        /********************************/
        /********************************/

        // Selection Sort

        // Insertion Sort

        // Heap Sort

        // Quick Sort

        private static void Swap(ref int v1, ref int v2)
        {
            int temp = v1; v1 = v2; v2 = temp;
        }

        public static bool TestSortedAscending(int[] prArray)
        {
            for (int i = 1; i < prArray.Length; i++)
            {
                if (prArray[i - 1] > prArray[i]) return false;
            }
            return true;
        }

    }
}
