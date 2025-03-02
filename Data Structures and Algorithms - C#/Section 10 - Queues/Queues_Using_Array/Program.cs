namespace Queues_Using_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            QueueArray<int> queueArray = new(5);

            queueArray.Enqueue(1);
            queueArray.Enqueue(2);
            queueArray.Enqueue(3);
            queueArray.Enqueue(4);
            queueArray.Enqueue(5);

            queueArray.Dequeue();
            int peekNumber = queueArray.Peek();
            Console.WriteLine(peekNumber);

            queueArray.Display();
        }
    }
}
