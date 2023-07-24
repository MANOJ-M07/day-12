using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSelectionSort
{
    internal class Program
    {
        public static void SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n-1; i++)
            {
                int minIndex = i;
                for(int j = i+1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int tep = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = tep;
            }
        }

        public static void Prinnt(int[] arr)
        {
            foreach (var item in arr)
            { Console.WriteLine(item + " "); }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            int[] arr = { 55,88,66,55,22,77 };
            Console.WriteLine("print array without sort");
            Prinnt(arr);
            SelectionSort(arr);
            Console.WriteLine("after sort");
            Prinnt(arr);
            Console.ReadKey();  
        }
    }
}
