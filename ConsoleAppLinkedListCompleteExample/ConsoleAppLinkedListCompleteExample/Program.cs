using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLinkedListCompleteExample
{
    internal class Program
    {
        public static void PrintLinkedList(LinkedList<string> list)
        {
            Console.WriteLine("LinkedList contains {0} elements \n elements as follows",list.Count);
            var enumerator= list.GetEnumerator();
            while(enumerator.MoveNext())
            {
                var element = enumerator.Current;
                Console.WriteLine(element);
            }
        }
        static void Main(string[] args)
        {
            LinkedList<string> LinkedList = new LinkedList<string>();
            LinkedList.AddLast("Ram");
            LinkedList.AddLast("ROM");
            LinkedList.AddLast("CD");
            LinkedList.AddLast("Printer");

            PrintLinkedList(LinkedList);

            LinkedList.RemoveFirst();
            Console.WriteLine("after Removing first item");

            PrintLinkedList(LinkedList);

            LinkedList.AddFirst("Keyboard");
            Console.WriteLine("After adding one item keyboard at first");

            PrintLinkedList(LinkedList);

            Console.WriteLine("enter hardware");
            string hdName = Console.ReadLine();
            if(LinkedList.Contains(hdName))
            {
                Console.WriteLine("hardware found");
            }
            else
            {
                Console.WriteLine("no such ");
            }

            Console.ReadKey();


        }
    }
}
