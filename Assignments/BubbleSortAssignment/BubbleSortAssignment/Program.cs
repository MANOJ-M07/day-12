using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortAssignment
{
    internal class Program
    {
        
            public static void BubbleSort(int[] array)
            {
                int n = array.Length;
                bool swapped;
                for (int i = 0; i < n - 1; i++)
                {
                    swapped = false;
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                           
                            int temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                            swapped = true;
                        }
                    }
                    
                    if (!swapped)
                        break;
                }
            }

            public static void SelectionSort(int[] array)
            {
                int n = array.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    int minIndex = i;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (array[j] < array[minIndex])
                            minIndex = j;
                    }
                    int temp = array[minIndex];
                    array[minIndex] = array[i];
                    array[i] = temp;
                }
            }
        static bool IsSorted(int[] array)
        {
            int n = array.Length;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                    return false;
            }
            return true;
        }

        public static void print(int[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item+" ");
            }
            Console.WriteLine("\n");
        }

        public static void Main(string[] args)
        {
            int[] array1 = { 25, 55, 88, 99, 44, 66, 33, 11 };
            int[] array2 = { 25, 55, 88, 99, 44, 66, 33, 11 };
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("print without bubble sort");
            print(array1);
            sw.Start();
            BubbleSort(array1);
            sw.Stop();
            Console.WriteLine("After Bubble Sort");
            print(array1);
            Console.WriteLine($"array sorted or not :\t{IsSorted(array1)}");
            Console.WriteLine($"Time taken to sort {array1.Length} in bubble sort: {sw.Elapsed.TotalMilliseconds} milliseconds");


            Console.WriteLine("print without selection sort");
            print(array2);

            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            SelectionSort(array2);
            stopwatch2.Stop();
            Console.WriteLine("After selection Sort");
            print(array2);
            Console.WriteLine($"array sorted or not :\t {IsSorted(array2)}");
            Console.WriteLine($"Time taken to sort {array2.Length}in selection sort: {stopwatch2.Elapsed.TotalMilliseconds} milliseconds");
            Console.ReadKey();

        }
    }
}
    
