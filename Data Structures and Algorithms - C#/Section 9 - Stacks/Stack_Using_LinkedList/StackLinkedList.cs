namespace Stack_Using_LinkedList
{
    public class StackLinkedList<T>
    {
        private Node<T>? top;
        private int size;

        public StackLinkedList()
        {
            top = null;
            size = 0;
        }

        public int Lenght => size;
        private bool IsEmpty() => size == 0;
        public void Push(T element)
        {
            Node<T> newest = new(element, null!);

            if (!IsEmpty())
            {
                newest.next = top!;
            }

            top = newest;
            size++;
        }
        public T Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The stack is empty!");
                return default!;
            }

            T element = top!.element;
            top = top.next;
            size--;

            return element;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The stack is empty!");
                return default!;
            }

            return top!.element;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The stack is empty!");
                return;
            }

            Node<T> node = top!;
            for(int i = 0; i < size; i++)
            {
                Console.Write(node.element + " ");
                node = node.next;
            }
            Console.WriteLine();
        }

    }
}
