using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBubbleSort
{
    internal class Program
    {
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;
            for (int i = 0; i < n-1; i++)
            {
                swapped = false;
                for (int j = 0; j < n-i-1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;    
                        swapped = true;
                    }
                }
                if (!swapped) { break; }
            }
        }

        public static void Print(int[] arr)
        {
            for (int i = 0;i< arr.Length;i++)
            {
                Console.WriteLine(arr[i]+" ");
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            int[] arr = { 5, 11, 22, 33, 55, 88, 99 };
            Console.WriteLine("Print array without sort");
            Print(arr);
            BubbleSort(arr);
            Console.WriteLine("after bubble sort");
            Print(arr);
            Console.ReadKey();  
        }
    }
}
