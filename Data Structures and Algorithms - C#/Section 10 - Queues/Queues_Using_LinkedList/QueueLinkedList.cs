namespace Queues_Using_LinkedList
{
    public class QueueLinkedList<T>
    {
        private Node<T>? front;
        private Node<T>? rear;
        private int size;

        public QueueLinkedList()
        {
            front = null;
            rear = null;
            size = 0;
        }

        public int Lenght => size;
        private bool IsEmpty() => size == 0;

        public void Enqueue(T element)
        {
            Node<T> newest = new Node<T>(element, null!);

            if (IsEmpty())
            {
                front = newest; 
            }
            else
            {
                rear!.next = newest;
            }

            rear = newest;
            size++;
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty!");
                return default!;
            }

            T element = front!.element;
            front = front.next;
            size--;

            if (IsEmpty())
            {
                rear = null;
            }

            return element;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty!");
                return default!;
            }

            return front!.element;
        }

        public void Display()
        {
            Node<T> node = front!;

            while(node != null)
            {
                Console.Write(node.element + " ");
                node = node.next;
            }

            Console.WriteLine();
        }
    }
}
