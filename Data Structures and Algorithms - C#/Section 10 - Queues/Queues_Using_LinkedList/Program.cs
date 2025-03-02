namespace Queues_Using_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QueueLinkedList<int> queueLinkedList = new QueueLinkedList<int>();

            queueLinkedList.Enqueue(1);
            queueLinkedList.Enqueue(2);
            queueLinkedList.Enqueue(3);
            queueLinkedList.Enqueue(4);
            queueLinkedList.Enqueue(5);

            queueLinkedList.Dequeue();

            int peekedNumber = queueLinkedList.Peek();
            Console.WriteLine($"Peek number: {peekedNumber}");

            queueLinkedList.Display();
        }
    }
}
