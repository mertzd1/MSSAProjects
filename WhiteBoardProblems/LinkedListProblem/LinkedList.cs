using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProblem
{
    public class LinkedList<T>
    {
        public Node<T> Head { get; set; }
        public override string ToString()
        {
            string s = "";
            Node<T> tmp = Head;
            while(tmp != null)
            {
                s += $"{tmp.Data}->";
                tmp = tmp.Next;
            }
            return s;
        }
    }
}
