namespace Doubly_Linked_List
{
    public class Node<T>
    {
        public Node<T>? next;
        public Node<T>? prev;
        public T element;

        public Node(T element, Node<T> next, Node<T> prev)
        {
            this.element = element;
            this.next = next;
            this.prev = prev;
        }
    }
}
