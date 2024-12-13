using System.Collections;
using System.Collections.Generic;
using System.Net.WebSockets;

namespace Zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //da se naprawi spusychna struktura s ednakwi elementi idwashti ot masiv ot celi chisla
            // da se vuvede chislo ot klaviaturata i da se postawi na 3to mqsto;
            //3 razlichni metoda
            //ArrayList
            //Stack
            //LinkedList
            int[] arr = { 10, -15, 100, 0, -200 };
            int number = int.Parse(Console.ReadLine());
            ArrayList arrList = AddInArrayList(arr, number);
            PrintArrayList(arrList);
            LinkedList<int> linkedList = AddInLinkedList(arr, number);
            PrintLinkedList(linkedList);
            Stack<int> stck = AddInStack(arr, number);
            PrintStack(stck);
        }
        static void PrintStack(Stack<int> stck)
        {
            while (stck.Count != 0)
            {
                Console.Write(stck.Pop() + " ,");
            }
            Console.WriteLine();
        }
        static void PrintArrayList(ArrayList arrList)
        {
            foreach (int item in arrList)
            {
                Console.Write(item + " ,");
            }
            Console.WriteLine();
        }
        static void PrintLinkedList(LinkedList<int> linkedList)
        {
            foreach (int item in linkedList)
            {
                Console.Write(item + " ,");
            }
            Console.WriteLine();
        }
        private static ArrayList AddInArrayList(int[] arr, int number)
        {
            ArrayList list = new ArrayList(arr);
            list.Insert(2, number);
            return list;
        }
        private static LinkedList<int> AddInLinkedList(int[] arr, int number)
        {
            LinkedList<int> list = new LinkedList<int>(arr);
            LinkedListNode<int> node = list.First;
            node = node.Next;
            list.AddAfter(node,number);
            return list;
        }
        private static Stack<int> AddInStack(int[] arr, int number)
        {
            Stack<int> stack = new Stack<int>(arr);
            int firstElem = stack.Pop();
            int secondElem = stack.Pop();
            stack.Push(number);
            stack.Push(secondElem);
            stack.Push(firstElem);
            return stack;
        }
    }
}
