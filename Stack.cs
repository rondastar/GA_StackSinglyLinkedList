using System;
using System.Collections.Generic;
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

        internal class StackNode<T> // Internal class for the nodes of the stack
        {
            T Value;

            public StackNode(T value)   // creates a node with the given value
            {
                Value = value;
            } // StackNode constructor

        } // StackNode nested class

    } // Stack class
}
