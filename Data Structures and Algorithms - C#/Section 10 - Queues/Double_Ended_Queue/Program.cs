namespace Double_Ended_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoubleEndedQueue<int> doubleEndedQueue = new();

            doubleEndedQueue.AddFirst(1);
            doubleEndedQueue.AddFirst(2);
            doubleEndedQueue.AddFirst(3);
            doubleEndedQueue.AddFirst(4);
            doubleEndedQueue.AddFirst(5);

            doubleEndedQueue.RemoveLast();
            doubleEndedQueue.RemoveFirst();

            Console.WriteLine($"Peek: {doubleEndedQueue.Peek()}");

            doubleEndedQueue.Display();
        }
    }
}
