namespace Stack_Using_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackLinkedList<int> stackLinkedList = new();

            stackLinkedList.Push(1);
            stackLinkedList.Push(2);
            stackLinkedList.Push(3);
            stackLinkedList.Push(4);
            stackLinkedList.Push(5);

            Console.Write("Stack: ");
            stackLinkedList.Display();

            int removedEl = stackLinkedList.Pop();
            Console.WriteLine($"Removed element: {removedEl}");

            Console.WriteLine($"Peek: {stackLinkedList.Peek()}");

            stackLinkedList.Display();

            Console.WriteLine($"Length of the stack: {stackLinkedList.Lenght}");
        }
    }
}
