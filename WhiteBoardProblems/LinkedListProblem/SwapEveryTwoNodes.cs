using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProblem
{
    //given the head of a signly liked list swap every two nodes and return its head.
    // for exampel given 1->2->3->4, return 2->1->4->3
    public class SwapEveryTwoNodes<T>
    {
        public Node<T> SwapPairs(LinkedList<T> list)
        {
            if (list == null || list.Head.Next==null)
                return list.Head;
            
            //tmp node is going to point to the node prior to the pair of nodes to swap
            Node<T> tmp = list.Head;
            //started with 1->2->3->4
            //2nd iteration 2->1->3->4
            //3rd iteration 2->1->4->3

            while (tmp != null && tmp.Next!=null)
            {
                //if we are swapping the first two nodes
                if (tmp == list.Head)
                {
                    //creating a copy of the first two node of the pair that we would like to swap.
                    //ie. node with value 1
                    Node<T> node = list.Head;
                    //skip over the 1st node of the pair in out liked list
                    //by setting the head node to point to the 2nd node
                    //ie node with a value 2
                    list.Head = list.Head.Next;
                    //update teh 1st node's poiter to next to be the 2nd node's pointer to next
                    //ie: the element after the node with a value of 1 will be the node with a value of three
                    node.Next = list.Head.Next;
                    //update the 2nd node's poiunter to next to be the first node
                    //ie: the element after the node with the value of 2 will be the node with a value of 1
                    list.Head.Next = node;
                }
                else if(tmp.Next.Next !=null)
                {
                    //creating a copy of the first two node of the pair that we would like to swap.
                    //ie: node with value 3
                    Node<T> node = tmp.Next; //tmp is pointing to 1 so node is pointint to 3
                    //skip over the 1st node of the pair in out liked list
                    //ie: node with value 4
                    tmp.Next = tmp.Next.Next;
                    //update teh 1st node's poiter to next to be the 2nd node's pointer to next
                    //ie the element after the node with a value of 3 will be null
                    node.Next = tmp.Next.Next; //temp.next.next == null 
                    //update the 2nd node's poiunter to next to be the first node
                    //is the element after the node with a value of 4 will be the node wiht a value of 3
                    tmp.Next.Next = node; //now temp.next.next === 3
                    //move out tmp pointer to the node prior to the next pair of nodes to swap
                    tmp= node;
                }
                else
                {
                    //if there is only 1 node in "the pair" (ie the last node of a list with an odd number of elements)
                    //then no swap is neccessary
                    break;
                }

            }




            return list.Head;
        }

            
    }
}
