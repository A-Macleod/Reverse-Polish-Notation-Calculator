using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPN
{
    /// <summary>
    /// An Array based stack. Last In First Out, like a stack of books. If we add or remove from the stack we are always using the top.
    /// Implimenting the Istack Interface, a contract this class will adhere to.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ArrayStack<T> : IStack<T>
    {

        private T[] _array; // Private array field of generic type
        private int _top;   // Private integer field to track the current position of the top index


        /// <summary>
        /// Constructor that takes in an array size argument and uses this to initialise the stack.
        /// The top field is set to -1, to track the current position of the top index, the array is empty so it is  -1
        /// </summary>
        /// <param name="size">The size of the array to be created</param>
        public ArrayStack(int size)
        {
            _array = new T[size]; // Setting the new generic array to the size argument
            _top = -1;            // We MUST set the top to -1, to show that the stack is empty.
                                  // When we PUSH items, we will increment by one, and add item to that top Position.
                                  // We can check if the array is empty by compairing if TOP == -1

        }


        /// <summary>
        /// A Method to "Push" an item onto the top of the array based.
        /// Before pushing we check that the array based stack is full - then return an error if true
        /// </summary>
        /// <param name="item">The item of generic type to be added to the array stack</param>
        public void Push(T item)
        {
            if ( _top >= _array.Length - 1)
            {
                throw new OverflowException("OverFlowException: The Array is Full");
            }

            _array[++_top] = item; // Increment the top index, add item to that index, before insertion
                                   // -1 becomes 0, then the item is added to that index position

        }


        /// <summary>
        /// A Method to Return and Remove the element from the top of the array based stack
        /// Before popping we check that the array based stack is not empty - then return an error if true
        /// </summary>
        /// <returns>The top index value from the array based stack, then decrements top by 1, removing the item</returns>
        public T Pop()
        {
            if ( IsEmpty() ) // if true do this
            {   
                // How to add UnderFlowException Class https://stackoverflow.com/questions/41849215/how-to-throw-an-underflow-exception
                throw new UnderflowException("UnderFlowException: The Array is Empty");
                
            }

            T value = _array[_top--]; // AFTER the array top index has been returned, decrement top
                                      // The -- after the variable states to decrement after the variable value has been returned
                                      // if it was before the variable, it would be to decrement then return the value

            return value;

        }


        /// <summary>
        /// A Method to view the top item of the array based stack, without removing it.
        /// Checking if the array based stack is empty first
        /// </summary>
        /// <returns>The top index value from the array based stack</returns>
        public T Peek()
        {
            if ( IsEmpty() ) // if true do this
            {
                throw new UnderflowException("UnderFlowException: The Array is Empty");
            }

            return _array[_top];

        }


        /// <summary>
        /// A Method to check if the array based stack is empty and return either True or False
        /// </summary>
        /// <returns>True or False if the array is Empty or not</returns>
        public bool IsEmpty()
        {

            if (_top == -1) // if the array is empty
            {
                return true;

            } else {

                return false;

            }

        }


        /// <summary>
        /// A Method to check if the array based stack is full and return either True of False
        /// </summary>
        /// <returns>True or False if the array is Full or not</returns>
        public bool isFull()
        {
            if (_top == _array.Length - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
