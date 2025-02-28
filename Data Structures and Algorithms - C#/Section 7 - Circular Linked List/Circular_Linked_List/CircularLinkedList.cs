namespace Circular_Linked_List
{
    public class CircularLinkedList<T>
    {
        private Node<T>? head;
        private Node<T>? tail;
        private int size;

        public CircularLinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public bool IsEmpty() => size == 0;

        public void AddLast(T element)
        {
            Node<T> newestEl = new Node<T>(element, null!);

            if (IsEmpty())
            {
                newestEl.next = newestEl;
                head = newestEl;
            }
            else
            {
                newestEl.next = tail!.next;
                tail.next = newestEl;
            }

            tail = newestEl;
            size++;
        }

        public void AddFirst(T element)
        {
            Node<T> newestEl = new Node<T>(element, null!);

            if (IsEmpty())
            {
                newestEl.next = newestEl;
                head = newestEl;
                tail = newestEl;
            }
            else
            {
                tail!.next = newestEl;
                newestEl.next = head;
                head = newestEl;
            }
            size++;
        }
        
        public void AddAny(T element, int position)
        {
            if(position <= 0 || position >= size)
            {
                Console.WriteLine("Invalid position!");
                return;
            }

            Node<T> newestEl = new(element, null!);
            Node<T> node = head!;

            for(int i = 1; i < position - 1; i++)
            {
                node = node.next!;
            }

            newestEl.next = node.next;
            node.next = newestEl;
            size++;
        }

        public T RemoveFirst()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The list is empty!");
                return default!;
            }
            
            T element = head!.element;

            tail!.next = head.next;
            head = head.next;
            size--;

            if (IsEmpty())
            {
                head = null;
                tail = null;
            }

            return element;
        }

        public T RemoveLast()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The list is empty!");
                return default!;
            }

            Node<T> node = head!;

            for(int i = 1; i < size - 1; i++)
            {
                node = node.next!;
            }
            
            tail = node;
            node = node.next!;
            tail.next = head;
            T element = node.element;
            size--;

            return element;
        }

        public T RemoveAny(int position)
        {
            if(position <= 0 || position >= size)
            {
                Console.WriteLine("Invalid position!");
                return default!;
            }

            Node<T> node = head!;

            for(int i = 1; i < position - 1; i++)
            {
                node = node.next!;
            }

            T element = node.next!.element;
            node.next = node.next!.next;
            size--;

            return element;
        }

        public void Display()
        {
            Node<T> node = head!;
            
            for(int i = 0; i < size; i++)
            {
                Console.Write(node!.element + " ");
                node = node.next!;
            }

            Console.WriteLine();
        }
    }
}
