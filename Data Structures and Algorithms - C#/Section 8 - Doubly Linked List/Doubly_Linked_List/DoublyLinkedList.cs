namespace Doubly_Linked_List
{
    public class DoublyLinkedList<T>
    {
        private Node<T>? head;
        private Node<T>? tail;
        private int size;

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public bool IsEmpty() => size == 0;

        public void AddLast(T element)
        {
            Node<T> newest = new Node<T>(element, null!, null!);

            if (IsEmpty())
            {
                head = newest;
                tail = newest;
            }
            else
            {
                tail!.next = newest;
                newest.prev = tail;
                tail = newest;
            }
            size++;
        }

        public void AddFirst(T element)
        {
            Node<T> newest = new Node<T>(element, null!, null!);

            if (IsEmpty())
            {
                head = newest;
                tail = newest;
            }
            else
            {
                head!.prev = newest;
                newest.next = head;
                head = newest;
            }
            size++;
        }

        public void AddAny(T element, int position)
        {
            if(position <= 0 || position >= size)
            {
                Console.WriteLine("The position is invalid!");
                return;
            }

            Node<T> node = head!;

            for(int i = 1; i < position - 1; i++)
            {
                node = node.next!;
            }

            Node<T> newest = new Node<T>(element, null!, null!);

            newest.next = node.next;
            node.next!.prev = newest;
            node.next = newest;
            newest.prev = node;

            size++;
        }
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The list is empty!");
                return;
            }

            Node<T> node = head!;

            while(node != null)
            {
                Console.Write(node.element + " ");
                node = node.next!;
            }

            Console.WriteLine();
        }
    }
}
