using System;
using System.Diagnostics;

namespace BubbleSort
{
    internal class Program
    {
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
        }

        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "  "); // Changed WriteLine to Write to print on the same line.
            }
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 5, 4, 7, 6 };
            Console.WriteLine("array without bubble sort");
            Print(arr);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            BubbleSort(arr);
            stopwatch.Stop();
            Console.WriteLine("array with bubble sort");
            Print(arr);
            Console.WriteLine($"ArraySize {arr.Length} Time TAken {stopwatch.Elapsed.TotalMilliseconds} milliseconds");

            Console.ReadLine();
        }
    }
}