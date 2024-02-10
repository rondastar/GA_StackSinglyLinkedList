# GA_StackSinglyLinkedList


Explanation of a stack and its utility.
- Stack is a LIFO data structure. It can be visualized as a stack of plates, where plates are added in a stack, and the top one is always removed first. Stacks are based on singly linked lists in that both are made up of singly linked nodes, but stacks are more restrictive because only the top item can be accessed.

Differences between a stack and a singly linked list.
- Only the top of the stack can be removed, viewed, or added to, so a stack is more restrictive. A singly linked list can be iterated through so that any item in the list can be accessed, although only in one direction (head to tail).

Discuss scenarios where a stack is preferable over other data structures.
- A stack could be preferable when data always needs to be accessed in a LIFO order, such as with undo/redo in text editors. They can also be used recursively, so they can be helpful for certain calculations.

Considerations for choosing between a stack and other data structures.
- The order the data needs to be accessed would be the key criteria. If LIFO is the order that is needed, a stack could be a gret choice. It is dynamic in size, and is efficient at what it does since there are minimal references.

Thoughts on implementing a stack using different approaches (array vs. linked list).
- If the data set is a known length/count, an array could be a good option for a stack, because it is also easy to add an element from the end of an array, or to remove one. 
