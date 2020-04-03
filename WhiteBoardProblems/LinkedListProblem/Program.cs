using System;

namespace LinkedListProblem
{
    class Program
    {
        static LinkedList<int> GetPopulatedLinked()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Head = new Node<int> { Data = 1, Next = null };
            Node<int> node = list.Head;
            node.Next = new Node<int> { Data = 2, Next = null };
            node = node.Next;
            node.Next = new Node<int> { Data = 3, Next = null };
            node = node.Next;
            node.Next = new Node<int> { Data = 4, Next = null };
            return list;
        }
        static void Main(string[] args)
        {
            LinkedList<int> list = GetPopulatedLinked();
            SwapEveryTwoNodes<int> setn = new SwapEveryTwoNodes<int>();
            Console.WriteLine(list);
            setn.SwapPairs(list);
            Console.WriteLine(list);
           

        }
    }
}
