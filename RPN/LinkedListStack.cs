using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPN
{
    /// <summary>
    /// A LinkedList stack implementation 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class LinkedListStack<T> : IStack<T>
    {
        /// <summary>
        /// Node class represents a node in the linked list
        /// </summary>
        private class Node
        {

            public T Data;  
            public Node Next;  


            /// <summary>
            /// Node constructor for the Node class. It will store the Data and Pointers 
            /// to the Next node.
            /// </summary>
            /// <param name="data">The data we want to store in the created node</param>
            public Node(T newData)
            {
                Data = newData;
                Next = null;

            }

        }


        private Node _head; // Private field _head, for LinkedListStack
        private T _data;    // Private field _data, for LinkedListStack

        /// <summary>
        /// LinkedListStack constructor. It will store the pointers to the head
        /// </summary>
        public LinkedListStack()
        {
            _head = null;
            
        }


        public void Push(T data)
        {
            
            Node newNode = new Node(data);  // create new node
            newNode.Next = _head;           // point it to the current head
            _head = newNode;                // update the head to point to the new node (start point)

        }


        public T Pop()
        {

            _data = _head.Data;
            _head = _head.Next;     // update the head to the next node
            return _data;            // return the data of the head of the stack

        }


        public T Peek()
        {

            return _head.Data; // return the data of the head of the stack

        }


        public bool IsEmpty()
        {

            if(_head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        } 




    } // EO LinkedListStack
}
