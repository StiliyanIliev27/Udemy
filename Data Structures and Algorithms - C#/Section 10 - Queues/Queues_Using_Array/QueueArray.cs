namespace Queues_Using_Array
{
    public class QueueArray<T>
    {
        private T[] data;
        private int rear;
        private int front;
        private int size;

        public QueueArray(int n)
        {
            data = new T[n];
            rear = 0;
            front = 0;
            size = 0;
        }

        public int Lenght => size;

        private bool IsEmpty() => size == 0;
        private bool IsFull() => size == data.Length;
        public void Enqueue(T element)
        {
            if (IsFull()) 
            {
                Console.WriteLine("The queue is full!");
                return;
            }

            data[rear] = element;
            rear++;
            size++;
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty!");
                return default!;
            }

            T element = data[front];
            front++;
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

            return data[front];
        }

        public void Display()
        {
            for(int i = front; i < rear; i++)
            {
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
