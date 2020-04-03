using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProblem
{
    //you can include multiple type parameters if you want.
   public class Node<T>
    {
        public T Data { get; set; }
       public Node<T> Next { get; set; }
    }
}
