namespace Double_Ended_Queue
{
    public class DoubleEndedQueue<T>
    {
        private Node<T>? front;
        private Node<T>? rear;
        private int size;

        public DoubleEndedQueue()
        {
            front = null;
            rear = null;
            size = 0;
        }

        public int Lenght => size;
        private bool IsEmpty() => size == 0;

        public void AddLast(T element)
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

        public void AddFirst(T element)
        {
            Node<T> newest = new Node<T>(element, null!);

            if (IsEmpty())
            {
                front = newest;
                rear = newest;
            }
            else
            {
                newest.next = front!;
                front = newest;
            }

            size++;
        }

        public T RemoveFirst()
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

        public T RemoveLast()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty!");
                return default!;
            }

            Node<T> node = front!;
            for(int i = 1; i < size - 1; i++)
            {
                node = node.next;
            }

            rear = node;
            node = node.next;
            T element = node.element;
            rear.next = null!;
            size--;

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

        public int Search(T key)
        {
            Node<T> node = front!;
            int index = 0;

            while(node != null)
            {
                if(EqualityComparer<T>.Default.Equals(node.element, key))
                {
                    return index;
                }

                node = node.next;
                index++;
            }
            return -1;
        }

        public void Display()
        {
            Node<T> node = front!;

            while (node != null)
            {
                Console.Write(node.element + " ");
                node = node.next;
            }

            Console.WriteLine();
        }
    }
}
