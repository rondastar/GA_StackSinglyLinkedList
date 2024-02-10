using System.Runtime.Intrinsics.X86;

namespace GA_StackSinglyLinkedList
{
// Ronda Rutherford
// GA Stack Singly Linked List
// 2-9-2024
    
    internal class Program
    {
        static void Main(string[] args)
        {
            FloatTest();
            StringTest();
        }

        static void StringTest()
        {
            // create a new stack
            Stack<string> stack = new Stack<string>();

            // test push
            stack.Push("apricot");
            stack.Push("banana");
            stack.Push("coconut");
            stack.Push("durian");
            stack.Push("eggplant");

            // test count
            Console.WriteLine(stack.Count); // 5

            // test pop
            stack.Pop();

            // test peek
            Console.WriteLine(stack.Peek()); // durian

            // test clear
            stack.Clear();

            // test count
            Console.WriteLine(stack.Count); // 0

            // test peek
            Console.WriteLine(stack.Peek()); // blank

            // test pop
            Console.WriteLine(stack.Pop()); // blank

            // test push
            stack.Push("apple");

            // test pop
            Console.WriteLine(stack.Pop()); // apple

            // test peek
            Console.WriteLine(stack.Peek()); // blank

        } // StringTest

        static void FloatTest()
        {
            // create a new stack
            Stack<float> stack = new Stack<float>();

            // test push
            stack.Push(1.2F);
            stack.Push(2.3F);
            stack.Push(3.4F);
            stack.Push(4.4F);
            stack.Push(5.6F);

            // test count
            Console.WriteLine(stack.Count); // 5

            // test pop
            stack.Pop();

            // test peek
            Console.WriteLine(stack.Peek()); // 4.4

            // test clear
            stack.Clear();

            // test count
            Console.WriteLine(stack.Count); // 0

            // test peek
            Console.WriteLine(stack.Peek()); // 0

            // test pop
            Console.WriteLine(stack.Pop()); // 0

            // test push
            stack.Push(7.5F);

            // test pop
            Console.WriteLine(stack.Pop()); // 7.5

            // test peek
            Console.WriteLine(stack.Peek()); // 0

        }
    }
}
