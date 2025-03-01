namespace Stack_Using_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            StackArray<int> stackArray = new(n);

            stackArray.Push(1);
            stackArray.Push(2);
            stackArray.Push(3);
            stackArray.Push(4);

            Console.Write("Stack elements: ");
            stackArray.Display();

            int removedEl = stackArray.Pop();
            Console.WriteLine($"Removed element: {removedEl}");

            Console.WriteLine($"Peek element: {stackArray.Peek()}");

            stackArray.Display();

            Console.WriteLine($"Length of the stack: {stackArray.Length()}");
        }
    }
}
