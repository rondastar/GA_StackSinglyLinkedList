using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_StackSinglyLinkedList
{
    internal class Stack<T>
    {
        StackNode<T> top;
        int count;

        public Stack()
        {
            top = null;
            count = 0;
        } // Stack constructor

        class StackNode<T> // Internal class for the nodes of the stack
        {
            public T Value { get; set; }            // Data stored in the node
            public StackNode<T> Next { get; set; }    // Reference to the next node

            public StackNode(T value)   // creates a node with the given value
            {
                Value = value;
                Next = null;
            } // StackNode constructor

        } // StackNode nested class

        // Count provides access to the number of elements in the stack
        public int Count { get => count; set => count = value; }

        // Push adds an element to the top
        internal void Push(T value)
        {
            // Create a new node with the input value
            StackNode<T> newNode = new StackNode<T>(value);

            if (newNode != null)
            {
                // Create a temporary node to keep track of the current top node
                StackNode<T> current = top;

                // Update the references of the new node so that the current top follows the new node
                newNode.Next = current;
            }

            // Assign the new node to be the top
            top = newNode;

            // increment count to reflect added element
            count++;

        } // Push

        // Pop removes and returns the element from the top
        public T Pop()
        {
            // If top is null, return default
            if(top == null)
            {
                return default(T);
            }

            // Assign value to be removed from top to a temporary variable
            T temp = top.Value;

            // If the next node is empty, reset top to null
            if (top.Next == null) top = null;

            // If the next node is not null, update reference so it is the new top
            else if (top.Next != null)
            {
                top = top.Next;
            }

            // decrement the count
            count--;

            // return the value that was removed
            return temp;
        } // Pop
        
        // Peek returns the value of the top without removing it
        public T Peek()
        {
            // If top is null, return default
            if (top == null)
            {
                return default(T);
            }

            // return the value of the top
            return top.Value;
        } // Peek

        public void Clear()
        {
            // runs until the stack is empty
            while(top != null)
            {
                // If the next node is empty, reset top to null
                if (top.Next == null) top = null;

                // If the next node is not null, update reference so it is the new top
                else if (top.Next != null)
                {
                    top = top.Next;
                }

                // decrement the count
                count--;
            }
        } // Clear

    } // Stack class
}
