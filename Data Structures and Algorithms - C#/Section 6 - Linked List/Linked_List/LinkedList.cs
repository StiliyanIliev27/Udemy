namespace Linked_List
{
    public class LinkedList<T> where T : IComparable<T>
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
            if(position <= 0 || position >= Length)
            {
                Console.WriteLine("Invalid position!");
                return;
            }

            Node<T> newestEl = new Node<T>(element);
            Node<T> currentEl = head!;
            int i = 1;

            while(i < position - 1)
            {
                currentEl = currentEl.next!;
                i++;
            }

            newestEl.next = currentEl.next;
            currentEl.next = newestEl;
            size++;
        }

        public T RemoveFirst()
        {
            if(Length == 0)
            {
                Console.WriteLine("List is empty!");
                return default!;
            }

            T element = head!.element;
            head = head.next;
            size--;

            if(Length == 0)
            {
                tail = null;
            }

            return element;
        }

        public T RemoveLast()
        {
            if (Length == 0)
            {
                Console.WriteLine("List is empty!");
                return default!;
            }

            Node<T> node = head!;
            int i = 1;

            while(i < Length - 1)
            {
                node = node.next!;
                i++;
            }

            tail = node;
            node = node.next!;

            T elementValue = node.element;
            tail.next = null;
            size--;

            return elementValue;
        }

        public T RemoveAny(int position)
        {
            if (position <= 0 || position >= Length)
            {
                Console.WriteLine("Invalid position!");
                return default!;
            }

            Node<T> node = head!;
            int i = 1;

            while(i < position - 1)
            {
                node = node.next!;
                i++;
            }

            T element = node.next!.element;
            node.next = node.next!.next;
            size--;

            return element;
        }

        public int Search(T key)
        {
            Node<T> node = head!;
            int index = 0;

            while (node != null)
            {
                if(EqualityComparer<T>.Default.Equals(node.element, key))
                {
                    return index;
                }

                node = node.next!;
                index++;
            }

            return -1;
        }

        public void InsertSorted(T element)
        {
            Node<T> newest = new Node<T>(element);

            if (Length == 0)
            {
                head = newest;
            }
            else
            {
                Node<T> p = head!;
                Node<T> q = head!;

                while(p != null && IsGreaterThan(element, p.element))
                {
                    q = p;
                    p = p.next!;
                }

                if(p == head)
                {
                    newest.next = head;
                    head = newest;
                }
                else
                {
                    newest.next = q.next;
                    q.next = newest;
                }
            }

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

        public static bool IsGreaterThan(T a, T b)
        {
            return a.CompareTo(b) > 0;
        }
    }
}
