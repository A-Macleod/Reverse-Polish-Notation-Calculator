using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPN
{
    /// <summary>
    /// A LinkedList stack implementation inheriting from the IStack interface.
    /// We must adhere to the IStack methods. The contract. 
    /// </summary>
    /// <typeparam name="T">Generic type</typeparam>
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
            /// <param name="newData">The data we want to store in the created node</param>
            public Node(T newData)
            {
                Data = newData;
                Next = null;

            }
        }


        private Node _head; // Private field _head, for LinkedListStack
        private T _data;    // Private field _data, for LinkedListStack

        /// <summary>
        /// LinkedListStack constructor. It will store the pointers to the head or "top" item on the stack
        /// </summary>
        public LinkedListStack()
        {
            _head = null;
            
        }


        /// <summary>
        /// Method to create a newNode object with a generic data argument. 
        /// Point the newNode pointer to the current head.
        /// Update the head to point to the new node.
        /// </summary>
        /// <param name="data">Generic type</param>
        public void Push(T data)
        {
            
            Node newNode = new Node(data);  // create new node
            newNode.Next = _head;           // point it to the current head
            _head = newNode;                // update the head to point to the new node (start point)

        }


        /// <summary>
        /// Method to Return and remove a Node from the LinkedListStack 
        /// </summary>
        /// <returns>The data in the Node</returns>
        public T Pop()
        {

            _data = _head.Data;
            _head = _head.Next;      // update the head to the next node
            return _data;            // return the data of the head of the stack

        }


        /// <summary>
        /// Method to return the Data from the head or "top" of the LinkedListStack
        /// </summary>
        /// <returns>Head data</returns>
        public T Peek()
        {

            return _head.Data; // return the data of the head of the stack

        }


        /// <summary>
        /// Method to check if the LinkedListStack is empty. 
        /// If the head is Null, no Nodes have been created.
        /// </summary>
        /// <returns>true or false</returns>
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
