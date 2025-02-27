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

        public void Add(T element)
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
