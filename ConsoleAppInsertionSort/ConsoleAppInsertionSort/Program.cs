using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInsertionSort
{
    internal class Program
    {
        public static void InsertionSort(int[] arr)
        {
            
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j+1] = key;
            }
        }

        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            int[] arr = { 1,2,7, 8, 9, 10, 11 };
            Console.WriteLine("print array without sort");
            Print(arr);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            InsertionSort(arr);
            stopwatch.Stop();
            Console.WriteLine("after insertion sort");
            Print(arr);
            Console.WriteLine($"ArraySize {arr.Length} Time Taken {stopwatch.Elapsed.TotalMilliseconds} milliseconds");
            Console.ReadKey();

        }
    }
}
