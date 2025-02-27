namespace Linked_List
{
    public class LinkedList<T>
    {
        private Node<T>? head;
        private Node<T>? tail;
        private int size;
        public LinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public int Length => size;

        public void AddLast(T element)
        {
            Node<T> newestEl = new Node<T>(element);
            if(Length == 0)
            {
                head = newestEl;
            }
            else
            {
                tail!.next = newestEl;
            }

            tail = newestEl;
            size++;
        }

        public void AddFirst(T element)
        {
            Node<T> newestEl = new Node<T>(element);
            if(Length == 0)
            {
                head = newestEl;
                tail = newestEl;
            }
            else
            {
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

            Node<T> newestEl = new Node<T>(element);
            Node<T> currentEl = head!;
            int i = 0;

            while(i < position - 1)
            {
                currentEl = currentEl.next!;
                i++;
            }

            newestEl.next = currentEl.next;
            currentEl.next = newestEl;
            size++;
        }
        public void Display()
        {
            Node<T>? node = head;
            while(node != null)
            {
                Console.WriteLine(node.element + " --> ");
                node = node.next;
            }
            Console.WriteLine();
        }
    }
}
